using System.ComponentModel;

namespace Undersoft.SDK.Blazor.Components;

public enum ToastCategory
{
    [Description("success")]
    Success,

    [Description("info")]
    Information,

    [Description("danger")]
    Error,

    [Description("warning")]
    Warning
}
