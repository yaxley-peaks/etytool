using System.Text.Json;
using System.Text.Json.Nodes;
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

    private async Task<List<(string,string)>> GetApiResponse(string word)

    {
        if (word.Contains(' '))
        {
            throw new Exception("Word cannot contain spaces");
        }

        string? httpClientName = config["MWHttpClientName"];
        HttpClient client = clientFactory.CreateClient(httpClientName!);
        var results = await client.GetAsync($"{word}?key={_apiKey}");
        var contents = await results.Content.ReadAsStringAsync();
       JsonNode? j =  JsonSerializer.Deserialize<JsonNode>(contents);
       // j[n]["et"][0][1].ToString();
       List<(string, string)> returnList = [];
       if (returnList == null) throw new ArgumentNullException(nameof(returnList));
       foreach (var node in j!.AsArray())
       {
           try
           {
               if (node?["et"] == null)
               {
                   continue;
               }

               if (node["et"]?[0]?[0]?.ToString() == "text")
               {
                  returnList.Add((word, node["et"]?[0]?[1]?.ToString())!); 
               }
           }
           catch (NullReferenceException)
           {
           }
       }

       return returnList;
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
            var etymologyResultSet = (
                from x
                    in ctx.Etymologies
                where x.Name == eDto.OriginLanguage.ToUpperInvariant()
                select x);
            if (etymologyResultSet.Count() == 1)
            {
                var eId = (from e in etymologyResultSet select e.Id).First();
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
        catch (Exception)
        {
            // ignored
        }
    }

    private EtymologyDto GetEtymology(string word)
    {
        EtymologyDto eDto = new EtymologyDto();
        if (ctx.Words.Count(x => x.Word1 == word.ToUpperInvariant()) == 1)
        {
            Word w = (from a in ctx.Words.Include(w => w.EtymologyNavigation)
                where a.Word1.Equals(word.ToUpperInvariant())
                select a).First()!;
            eDto.Word = w.Word1.ToUpperInvariant();
            eDto.OriginLanguage = w.EtymologyNavigation.Name.ToUpperInvariant();
        }
        else
        {
            var etymologies = GetApiResponse(word);
            etymologies.Wait();
            /*
             * Etymology is of the form
             * et: [
             * ["text", language name],
             * ["notes", dont care]
             * ]
             * So we must drop all the rest. we only want the one
             * with "text"
             */
            var e = etymologies.Result.First().Item2;

                    

            // Remove words like "middle" or "ancient"
            e = string.Concat(e.Split(' ').First(x => x is not ("Middle" or "Ancient" or "Old" or "New" or "Modern"))
                .TakeWhile(IsAsciiLetter)).ToLowerInvariant();
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