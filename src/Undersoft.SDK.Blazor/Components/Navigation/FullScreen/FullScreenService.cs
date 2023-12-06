namespace Undersoft.SDK.Blazor.Components;

public class FullScreenService : PresenterService<FullScreenOption>
{
    public Task Toggle(FullScreenOption? option = null) => Invoke(option ?? new());
}
