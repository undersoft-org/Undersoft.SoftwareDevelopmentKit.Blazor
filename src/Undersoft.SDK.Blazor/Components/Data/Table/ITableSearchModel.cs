namespace Undersoft.SDK.Blazor.Components;

public interface ITableSearchModel
{
    IEnumerable<IFilterAction> GetSearchs();

    void Reset();
}
