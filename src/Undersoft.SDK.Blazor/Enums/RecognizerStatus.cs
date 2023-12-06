using System.Text.Json.Serialization;

namespace Undersoft.SDK.Blazor.Components;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum RecognizerStatus
{
    Start,

    Finished,

    Close,

    Error
}
