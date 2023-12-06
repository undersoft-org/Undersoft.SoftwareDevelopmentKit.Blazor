namespace Undersoft.SDK.Blazor.Components;

public class PrintService : PresenterService<DialogOption>
{
    public Task PrintAsync(DialogOption option) => Invoke(option);
}
