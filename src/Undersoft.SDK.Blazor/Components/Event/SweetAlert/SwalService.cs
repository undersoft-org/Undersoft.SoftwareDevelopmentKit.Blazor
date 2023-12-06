namespace Undersoft.SDK.Blazor.Components;

public class SwalService : PresenterService<SwalOption>
{
    private PresenterOptions _option;

    public SwalService(IOptionsMonitor<PresenterOptions> option)
    {
        _option = option.CurrentValue;
    }

    public async Task Show(SwalOption option, SweetAlert? swal = null)
    {
        if (!option.ForceDelay && _option.SwalDelay != 0)
        {
            option.Delay = _option.SwalDelay;
        }

        await Invoke(option, swal);
    }
}
