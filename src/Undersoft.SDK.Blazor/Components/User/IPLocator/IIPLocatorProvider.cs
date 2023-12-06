namespace Undersoft.SDK.Blazor.Components;

public interface IIPLocatorProvider
{
    Task<string?> Locate(string ip);
}
