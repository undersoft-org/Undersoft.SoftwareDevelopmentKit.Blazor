using Microsoft.Extensions.Localization;

namespace Undersoft.SDK.Blazor.Localization;

internal class NullLocalizationResolve : ILocalizationResolve
{
    public IEnumerable<LocalizedString> GetAllStringsByCulture(bool includeParentCultures) => Enumerable.Empty<LocalizedString>();
}
