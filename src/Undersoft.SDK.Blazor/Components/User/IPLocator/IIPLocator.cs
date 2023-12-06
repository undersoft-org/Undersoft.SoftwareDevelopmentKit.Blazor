namespace Undersoft.SDK.Blazor.Components;

public interface IIPLocator
{
    Task<string?> Locate(IPLocatorOption option);

    public string? Url { get; set; }
}
