using System.ComponentModel;

namespace Undersoft.SDK.Blazor.Components;

public enum InitialEditType
{
    [Description("markdown")]
    Markdown,

    [Description("wysiwyg")]
    Wysiwyg
}
