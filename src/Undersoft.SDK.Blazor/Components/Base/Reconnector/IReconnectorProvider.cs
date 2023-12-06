namespace Undersoft.SDK.Blazor.Components;

internal interface IReconnectorProvider
{
    void Register(Action<RenderFragment?, RenderFragment?, RenderFragment?> action);

    void NotifyContentChanged(IReconnector content);
}
