using EtyTool.Models;

namespace EtyTool.Services;

public class SharedDataService
{
    public bool IsSet { get; private set; } = false;
    private List<EtymologyDto>? _edto;

    public List<EtymologyDto>? EDtos
    {
        get
        {
            this.IsSet = false;
            return this._edto;
        }
        set
        {
            IsSet = true;
            this._edto = value;
        }
    }
}