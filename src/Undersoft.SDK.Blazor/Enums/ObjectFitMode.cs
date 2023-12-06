using System.ComponentModel;

namespace Undersoft.SDK.Blazor.Components;

public enum ObjectFitMode
{
    [Description("fill")]
    Fill,

    [Description("contain")]
    Contain,

    [Description("cover")]
    Cover,

    [Description("none")]
    None,

    [Description("scale-down")]
    ScaleDown
}
