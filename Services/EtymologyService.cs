using EtyTool.Context;
using EtyTool.Entities;
using EtyTool.JsonSchema;
using EtyTool.Models;
using Microsoft.EntityFrameworkCore;
using static System.Char;
using Exception = System.Exception;


namespace EtyTool.Services;

public class EtymologyService(
    ILogger<EtymologyService> logger,
    EtyToolContext ctx,
    IConfiguration config,
    IHttpClientFactory clientFactory)
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
            };
            // If language already seen, don't add another entry.
            if (ctx.Etymologies.Count(x => x.Name == eDto.OriginLanguage.ToUpperInvariant()) == 1)
            {
                var eId = ctx.Etymologies.Where(x => eDto.OriginLanguage.ToUpperInvariant() == x.Name).Select(e => e.Id)
                    .First()!;
                w.Etymology = eId;
            }
            else
            {
                w.EtymologyNavigation = new Etymology()
                {
                    Name = eDto.OriginLanguage.ToUpperInvariant()
                };
            }

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
                ;

            // Remove words like "middle" or "ancient"
            e = string.Concat(e?.Split(' ').First(x => x is not ("Middle" or "Ancient" or "Old" or "New" or "Modern"))!
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
        var e = GetEtymology("the");
        logger.Log(LogLevel.Information, $"Word: {e.Word}, origin: {e.OriginLanguage}");
        e = GetEtymology("whole");
        logger.Log(LogLevel.Information, $"Word: {e.Word}, origin: {e.OriginLanguage}");
        e = GetEtymology("juggernaut");
        logger.Log(LogLevel.Information, $"Word: {e.Word}, origin: {e.OriginLanguage}");
        e = GetEtymology("jungle");
        logger.Log(LogLevel.Information, $"Word: {e.Word}, origin: {e.OriginLanguage}");
        e = GetEtymology("shampoo");
        logger.Log(LogLevel.Information, $"Word: {e.Word}, origin: {e.OriginLanguage}");
        e = GetEtymology("beef");
        logger.Log(LogLevel.Information, $"Word: {e.Word}, origin: {e.OriginLanguage}");
        e = GetEtymology("purchase");
        logger.Log(LogLevel.Information, $"Word: {e.Word}, origin: {e.OriginLanguage}");
        e = GetEtymology("armistice");
        logger.Log(LogLevel.Information, $"Word: {e.Word}, origin: {e.OriginLanguage}");
        e = GetEtymology("wagyu");
        logger.Log(LogLevel.Information, $"Word: {e.Word}, origin: {e.OriginLanguage}");
    }
}