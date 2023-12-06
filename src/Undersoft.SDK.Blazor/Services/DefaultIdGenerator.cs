namespace Undersoft.SDK.Blazor.Components;

internal class DefaultIdGenerator : IComponentIdGenerator
{
    public string Generate(object component) => $"bb_{component.GetHashCode()}";
}
