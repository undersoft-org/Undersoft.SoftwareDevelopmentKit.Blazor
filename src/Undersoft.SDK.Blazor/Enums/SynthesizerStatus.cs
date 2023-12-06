using System.Text.Json.Serialization;

namespace Undersoft.SDK.Blazor.Components;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum SynthesizerStatus
{
    Synthesizer,

    Finished,

    Cancel,

    Error
}
