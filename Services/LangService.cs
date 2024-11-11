using EtyTool.Context;
using EtyTool.Entities;

namespace EtyTool.Services;

public class LangService
{
    public IEnumerable<Lang> Langs { get; private set; }

    public LangService(IServiceProvider serviceProvider)
    {
        using var scope = serviceProvider.CreateScope();
        var ctx = scope.ServiceProvider.GetRequiredService<EtyToolContext>();
        Langs ??= ctx.Langs.ToList();
    }
}