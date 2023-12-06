namespace Undersoft.SDK.Blazor.Components;

public partial class BootstrapInputGroupIcon
{
    private string? ClassString => CssBuilder.Default("input-group-text")
        .AddClassFromAttributes(AdditionalAttributes)
        .Build();

    [Parameter]
#if NET6_0_OR_GREATER
    [EditorRequired]
#endif
    public string? Icon { get; set; }
}
