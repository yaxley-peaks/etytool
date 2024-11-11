using EtyTool.Entities;
using EtyTool.Models;
using EtyTool.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EtyTool.Pages;

public class IndexModel(ILogger<IndexModel> logger, LangService ls)
    : PageModel
{
    public SelectList? SelectList { get; set; }

    [BindProperty] public FormDto? FormDto { get; set; }

    public PageResult OnGet()
    {
        logger.Log(LogLevel.Information, "Get Page");
        SelectList = new SelectList(ls.Langs,
            nameof(Lang.Id), nameof(Lang.Name));
        return Page();
    }

    public IActionResult OnPost()
    {
        if (FormDto == null || !ModelState.IsValid) return RedirectToPage();
        logger.Log(LogLevel.Information,
            $"Language: {FormDto.Language} Text: {FormDto.Text}");
        return RedirectToPage();
    }
}