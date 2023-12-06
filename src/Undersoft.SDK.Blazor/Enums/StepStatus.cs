using System.ComponentModel;

namespace Undersoft.SDK.Blazor.Components;

public enum StepStatus
{
    [Description("wait")]
    Wait,

    [Description("process")]
    Process,

    [Description("finish")]
    Finish,

    [Description("success")]
    Success,

    [Description("error")]
    Error,
}
