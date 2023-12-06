namespace Undersoft.SDK.Blazor.Components;

[ExcludeFromCodeCoverage]
internal static class JSRuntimeExtensions
{
    public static async ValueTask InvokeVoidAsync(this IJSRuntime jsRuntime, object? el = null, string? func = null, params object[] args)
    {
        var paras = new List<object>();
        if (el != null)
        {
            paras.Add(el);
        }

        if (args != null)
        {
            paras.AddRange(args);
        }

        try
        {
            await jsRuntime.InvokeVoidAsync($"$.{func}", paras.ToArray()).ConfigureAwait(false);
        }
#if NET6_0_OR_GREATER
        catch (JSDisconnectedException) { }
#endif
        catch (JSException) { }
        catch (AggregateException) { }
        catch (InvalidOperationException) { }
        catch (TaskCanceledException) { }
    }
}
