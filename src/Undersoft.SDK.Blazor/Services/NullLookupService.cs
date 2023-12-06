namespace Undersoft.SDK.Blazor.Services;

internal class NullLookupService : ILookupService
{
    public IEnumerable<SelectedItem>? GetItemsByKey(string? key) => null;
}
