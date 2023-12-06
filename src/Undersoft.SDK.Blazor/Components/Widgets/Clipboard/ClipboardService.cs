namespace Undersoft.SDK.Blazor.Components;

public class ClipboardService : PresenterService<ClipboardOption>
{
    public Task Copy(string? text, Func<Task>? callback = null) => Invoke(new ClipboardOption() { Text = text, Callback = callback });
}
