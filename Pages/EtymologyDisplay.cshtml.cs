using EtyTool.Models;
using EtyTool.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EtyTool.Pages;

public class EtymologyDisplay(SharedDataService sds, ILogger<EtymologyDisplay> logger) : PageModel
{
    [ViewData] public List<EtymologyDto>? EtymologyDtos { get; set; }
    public PageResult OnGet()
    {
        if (!sds.IsSet)
        {
            logger.Log(LogLevel.Information, "Direct page access.");
            RedirectToPage("Index");
        }

        EtymologyDtos = sds.EDtos;
        return Page();
    }
}