using EtyTool.Context;
using EtyTool.Entities;
using EtyTool.JsonSchema;
using EtyTool.Models;
using Microsoft.EntityFrameworkCore;
using static System.Char;


namespace EtyTool.Services;

public class EtymologyService(EtyToolContext ctx, IConfiguration config, IHttpClientFactory clientFactory)
{
    private readonly string _apiKey = config["Dictionary:MW:Key"]!;

    private async Task<List<MerriamResponse>> GetDef(string word)

    {
        if (word.Contains(' '))
        {
            throw new Exception("Word cannot contain spaces");
        }

        string? httpClientName = config["MWHttpClientName"];
        HttpClient client = clientFactory.CreateClient(httpClientName!);
        var results = await client.GetAsync($"{word}?key={_apiKey}");
        var contents = await results.Content.ReadAsStringAsync();
        var json = MerriamResponse.FromJson(contents);

        return await Task.FromResult(json);
    }

    private void CacheEtymology(EtymologyDto eDto)
    {
        try
        {
            Word w = new Word()
            {
                Lang = 1, // hardcode english
                Word1 = eDto.Word.ToUpperInvariant(),
                EtymologyNavigation = new Etymology()
                {
                    Name = eDto.OriginLanguage.ToUpperInvariant()
                }
            };
            ctx.Add(w);
            ctx.SaveChanges();
        }
        catch (Exception e)
        {
            // ignored
        }
    }

    private EtymologyDto GetEtymology(string word)
    {
        EtymologyDto eDto = new EtymologyDto();
        if (ctx.Words.Count(x => x.Word1 == word.ToUpperInvariant()) == 1)
        {
            Word w = ctx.Words.Include(w => w.EtymologyNavigation)
                .First(x => x.Word1.Equals(word.ToUpperInvariant()))!;
            eDto.Word = w.Word1.ToUpperInvariant();
            eDto.OriginLanguage = w.EtymologyNavigation.Name.ToUpperInvariant();
        }
        else
        {
            var x = GetDef(word);
            x.Wait();
            MerriamResponse mr = x.Result.First()!;
            /*
             * Etymology is of the form
             * et: [
             * ["text", language name],
             * ["notes", dont care]
             * ]
             * So we must drop all the rest. we only want the one
             * with "text"
             */
            var e = (from et
                        in mr.Et
                    where et[0] == "text"
                    select et[1])
                .FirstOrDefault()
                ?.ToUpperInvariant();

            // Remove words like "middle" or "ancient"
            e = string.Concat(e?.Split(' ').First(x => x is not ("Middle" or "Ancient" or "Old"))!
                                  .TakeWhile(IsAsciiLetter)
                              ?? Array.Empty<char>()).ToLowerInvariant();
            eDto.Word = word.ToUpperInvariant();
            eDto.OriginLanguage = e.ToUpperInvariant();
            CacheEtymology(eDto);
        }

        return eDto;
    }

    public void Do()
    {
        GetEtymology("the");
        GetEtymology("whole");
        GetEtymology("juggernaut");
    }
}