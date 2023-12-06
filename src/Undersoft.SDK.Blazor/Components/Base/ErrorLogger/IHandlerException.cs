namespace Undersoft.SDK.Blazor.Components;

public interface IHandlerException
{
    Task HandlerException(Exception ex, RenderFragment<Exception> errorContent);
}
