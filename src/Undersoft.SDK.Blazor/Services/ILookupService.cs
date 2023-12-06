namespace Undersoft.SDK.Blazor.Components;

public interface ILookupService
{
    IEnumerable<SelectedItem>? GetItemsByKey(string? key);
}
