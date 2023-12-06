using Undersoft.SDK.Blazor.Localization.Json;
using System.Globalization;

namespace Undersoft.SDK.Blazor.Components;

public class PresenterOptions
{
    public int ToastDelay { get; set; }

    public int MessageDelay { get; set; }

    public int SwalDelay { get; set; }

    public string FallbackCulture { get; set; } = "en";

    public Placement? ToastPlacement { get; set; }

    public List<string>? SupportedCultures { get; set; }

    public bool EnableErrorLogger { get; set; } = true;

    public bool EnableFallbackCulture { get; set; } = true;

    public bool? IgnoreLocalizerMissing { get; set; }

    public string? DefaultCultureInfo { get; set; }

    public TableSettings TableSettings { get; set; } = new();

    public bool? DisableAutoSubmitFormByEnter { get; set; }

    public List<KeyValuePair<string, string>> Themes { get; } = new()
    {
        new("Bootstrap", "bootstrap.blazor.bundle.min.css"),
        new("Motronic", "motronic.min.css")
    };

    public IList<CultureInfo> GetSupportedCultures() => SupportedCultures?.Select(name => new CultureInfo(name)).ToList()
        ?? new List<CultureInfo> { new("en"), new("zh") };
}
