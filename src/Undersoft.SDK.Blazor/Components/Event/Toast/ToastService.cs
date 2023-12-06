namespace Undersoft.SDK.Blazor.Components;

public class ToastService : PresenterService<ToastOption>
{
    private PresenterOptions Options { get; }

    public ToastService(IOptionsMonitor<PresenterOptions> options)
    {
        Options = options.CurrentValue;
    }

    public async Task Show(ToastOption option, ToastContainer? ToastContainer = null)
    {
        if (!option.ForceDelay && Options.ToastDelay != 0)
        {
            option.Delay = Options.ToastDelay;
        }
        await Invoke(option, ToastContainer);
    }
}
