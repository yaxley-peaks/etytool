using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EtyTool.Pages;

public class IndexModel(ILogger<IndexModel> logger) : PageModel
{
    private readonly ILogger<IndexModel> _logger = logger;

    public PageResult OnGet()
    {
        return Page();
    }


}