namespace Undersoft.SDK.Blazor.Components;

public class DispatchEntry<TEntry>
{
    public string? Name { get; set; }

    public TEntry? Entry { get; set; }
}
