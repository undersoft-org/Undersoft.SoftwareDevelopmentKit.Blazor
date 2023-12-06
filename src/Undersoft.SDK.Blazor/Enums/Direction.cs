using System.ComponentModel;

namespace Undersoft.SDK.Blazor.Components;

public enum Direction
{
    [Description("dropdown")]
    Dropdown,

    [Description("dropup")]
    Dropup,

    [Description("dropstart")]
    Dropleft,

    [Description("dropend")]
    Dropright
}
