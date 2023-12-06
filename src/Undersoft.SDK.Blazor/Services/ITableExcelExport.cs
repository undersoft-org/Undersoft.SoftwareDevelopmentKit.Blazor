namespace Undersoft.SDK.Blazor.Components;

public interface ITableExcelExport
{
    Task<bool> ExportAsync<TItem>(IEnumerable<TItem> items, IEnumerable<ITableColumn>? cols, string? fileName = null) where TItem : class;
}
