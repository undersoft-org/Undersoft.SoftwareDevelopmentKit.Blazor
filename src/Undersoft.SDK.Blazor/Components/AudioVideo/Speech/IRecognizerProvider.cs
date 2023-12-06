namespace Undersoft.SDK.Blazor.Components;

public interface IRecognizerProvider
{
    Task InvokeAsync(RecognizerOption option);
}
