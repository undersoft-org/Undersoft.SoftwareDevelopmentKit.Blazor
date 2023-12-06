namespace Undersoft.SDK.Blazor.Components;

public interface IFilter
{
    [NotNull]
    IFilterAction? FilterAction { get; set; }
}
