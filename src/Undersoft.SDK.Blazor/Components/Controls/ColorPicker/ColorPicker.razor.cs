namespace Undersoft.SDK.Blazor.Components;

public partial class ColorPicker
{
    protected string? ClassName => CssBuilder.Default("form-control")
        .AddClass(CssClass).AddClass(ValidCss)
        .Build();
}
