using EtyTool.Context;
using EtyTool.Entities;
using EtyTool.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace EtyTool.Pages;

public class IndexModel(ILogger<IndexModel> logger, EtyToolContext context) : PageModel
{
    private readonly ILogger<IndexModel> _logger = logger;
    private EtyToolContext _context = context;

    public IEnumerable<Lang> Langs = context.Langs.AsEnumerable();
    public SelectList SelectList = new(context.Langs.AsEnumerable(), nameof(Lang.Id), nameof(Lang.Name));

    [BindProperty] public FormDto? FormDto { get; set; }

    public PageResult OnGet()
    {
        return Page();
    }

    public IActionResult OnPost()
    {
        if (FormDto == null || !ModelState.IsValid)
        {
            return RedirectToPage();
        }
        logger.Log(LogLevel.Information,
            $"Language: {FormDto.Language} Text: {FormDto.Text}");
        return RedirectToPage();
    }

}