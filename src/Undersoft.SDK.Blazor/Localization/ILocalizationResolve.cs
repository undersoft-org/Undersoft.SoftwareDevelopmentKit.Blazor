using Microsoft.Extensions.Localization;

namespace Undersoft.SDK.Blazor.Localization;

public interface ILocalizationResolve
{
    IEnumerable<LocalizedString> GetAllStringsByCulture(bool includeParentCultures);
}
