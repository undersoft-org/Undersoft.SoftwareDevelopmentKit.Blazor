namespace Undersoft.SDK.Blazor.Components;

public interface ISynthesizerProvider
{
    Task InvokeAsync(SynthesizerOption option);
}
