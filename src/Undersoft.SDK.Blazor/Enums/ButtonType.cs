using System.ComponentModel;

namespace Undersoft.SDK.Blazor.Components;

public enum ButtonType
{
    [Description("button")]
    Button,

    [Description("submit")]
    Submit,

    [Description("reset")]
    Reset
}
