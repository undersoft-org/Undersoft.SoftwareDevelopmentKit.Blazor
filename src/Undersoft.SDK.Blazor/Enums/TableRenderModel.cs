using System.ComponentModel;

namespace Undersoft.SDK.Blazor.Components;

public enum TableRenderMode
{
    [Description("Auto")]
    Auto,

    [Description("Table")]
    Table,

    [Description("CardView")]
    CardView
}
