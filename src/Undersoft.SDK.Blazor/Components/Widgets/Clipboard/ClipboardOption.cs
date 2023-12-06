namespace Undersoft.SDK.Blazor.Components;

public class ClipboardOption
{
    public string? Text { get; set; }

    public Func<Task>? Callback { get; set; }
}
