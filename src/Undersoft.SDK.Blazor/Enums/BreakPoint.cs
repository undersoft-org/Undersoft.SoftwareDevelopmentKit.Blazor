using System.Text.Json.Serialization;

namespace Undersoft.SDK.Blazor.Components;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum BreakPoint
{
    None,

    ExtraSmall,

    Small,

    Medium,

    Large,

    ExtraLarge,

    ExtraExtraLarge
}
