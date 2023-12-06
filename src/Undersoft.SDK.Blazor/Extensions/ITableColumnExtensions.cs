﻿namespace Undersoft.SDK.Blazor.Components;

public static class IEditItemExtensions
{
    public static void InheritValue(this ITableColumn dest, AutoGenerateClassAttribute source)
    {
        if (source.Align != Alignment.None) dest.Align = source.Align;
        if (source.TextWrap) dest.TextWrap = source.TextWrap;
        if (!source.Editable) dest.Editable = source.Editable;
        if (source.Filterable) dest.Filterable = source.Filterable;
        if (source.Readonly) dest.Readonly = source.Readonly;
        if (source.Searchable) dest.Searchable = source.Searchable;
        if (source.ShowTips) dest.ShowTips = source.ShowTips;
        if (source.ShowCopyColumn) dest.ShowCopyColumn = source.ShowCopyColumn;
        if (source.Sortable) dest.Sortable = source.Sortable;
        if (source.TextEllipsis) dest.TextEllipsis = source.TextEllipsis;
    }

    public static void CopyValue(this ITableColumn dest, IEditorItem source)
    {
        if (source.ComponentType != null) dest.ComponentType = source.ComponentType;
        if (source.ComponentParameters != null) dest.ComponentParameters = source.ComponentParameters;
        if (!source.Editable) dest.Editable = source.Editable;
        if (source.EditTemplate != null) dest.EditTemplate = source.EditTemplate;
        if (source.Items != null) dest.Items = source.Items;
        if (source.Lookup != null) dest.Lookup = source.Lookup;
        if (source.ShowSearchWhenSelect) dest.ShowSearchWhenSelect = source.ShowSearchWhenSelect;
        if (source.IsPopover) dest.IsPopover = source.IsPopover;
        if (source.LookupStringComparison != StringComparison.OrdinalIgnoreCase) dest.LookupStringComparison = source.LookupStringComparison;
        if (source.LookupServiceKey != null) dest.LookupServiceKey = source.LookupServiceKey;
        if (source.IsReadonlyWhenAdd) dest.IsReadonlyWhenAdd = source.IsReadonlyWhenAdd;
        if (source.IsReadonlyWhenEdit) dest.IsReadonlyWhenEdit = source.IsReadonlyWhenEdit;
        if (source.Readonly) dest.Readonly = source.Readonly;
        if (source.Rows > 0) dest.Rows = source.Rows;
        if (source.SkipValidate) dest.SkipValidate = source.SkipValidate;
        if (!string.IsNullOrEmpty(source.Text)) dest.Text = source.Text;
        if (source.ValidateRules != null) dest.ValidateRules = source.ValidateRules;
        if (source.ShowLabelTooltip != null) dest.ShowLabelTooltip = source.ShowLabelTooltip;
        if (!string.IsNullOrEmpty(source.GroupName)) dest.GroupName = source.GroupName;
        if (source.GroupOrder != 0) dest.GroupOrder = source.GroupOrder;

        if (source is ITableColumn col)
        {
            if (col.Align != Alignment.None) dest.Align = col.Align;
            if (col.TextWrap) dest.TextWrap = col.TextWrap;
            if (!string.IsNullOrEmpty(col.CssClass)) dest.CssClass = col.CssClass;
            if (col.DefaultSort) dest.DefaultSort = col.DefaultSort;
            if (col.DefaultSortOrder != SortOrder.Unset) dest.DefaultSortOrder = col.DefaultSortOrder;
            if (col.Filter != null) dest.Filter = col.Filter;
            if (col.Filterable) dest.Filterable = col.Filterable;
            if (col.FilterTemplate != null) dest.FilterTemplate = col.FilterTemplate;
            if (col.Fixed) dest.Fixed = col.Fixed;
            if (col.FormatString != null) dest.FormatString = col.FormatString;
            if (col.Formatter != null) dest.Formatter = col.Formatter;
            if (col.HeaderTemplate != null) dest.HeaderTemplate = col.HeaderTemplate;
            if (col.OnCellRender != null) dest.OnCellRender = col.OnCellRender;
            if (col.Searchable) dest.Searchable = col.Searchable;
            if (col.SearchTemplate != null) dest.SearchTemplate = col.SearchTemplate;
            if (col.ShownWithBreakPoint != BreakPoint.None) dest.ShownWithBreakPoint = col.ShownWithBreakPoint;
            if (col.ShowTips) dest.ShowTips = col.ShowTips;
            if (col.Sortable) dest.Sortable = col.Sortable;
            if (col.Template != null) dest.Template = col.Template;
            if (col.TextEllipsis) dest.TextEllipsis = col.TextEllipsis;
            if (!col.Visible) dest.Visible = col.Visible;
            if (col.Width != null) dest.Width = col.Width;
            if (col.ShowCopyColumn) dest.ShowCopyColumn = col.ShowCopyColumn;
            if (col.HeaderTextWrap) dest.HeaderTextWrap = col.HeaderTextWrap;
            if (!string.IsNullOrEmpty(col.HeaderTextTooltip)) dest.HeaderTextTooltip = col.HeaderTextTooltip;
            if (col.ShowHeaderTooltip) dest.ShowHeaderTooltip = col.ShowHeaderTooltip;
            if (col.HeaderTextEllipsis) dest.HeaderTextEllipsis = col.HeaderTextEllipsis;
        }
    }

    public static List<IFilterAction> ToSearchs(this IEnumerable<ITableColumn> columns, string? searchText)
    {
        var searchs = new List<IFilterAction>();
        if (!string.IsNullOrEmpty(searchText))
        {
            foreach (var col in columns)
            {
                var type = Nullable.GetUnderlyingType(col.PropertyType) ?? col.PropertyType;
                if (type == typeof(bool) && bool.TryParse(searchText, out var @bool))
                {
                    searchs.Add(new SearchFilterAction(col.GetFieldName(), @bool, FilterAction.Equal));
                }
                else if (type.IsEnum && Enum.TryParse(type, searchText, true, out object? @enum))
                {
                    searchs.Add(new SearchFilterAction(col.GetFieldName(), @enum, FilterAction.Equal));
                }
                else if (type == typeof(string))
                {
                    searchs.Add(new SearchFilterAction(col.GetFieldName(), searchText));
                }
                else if (type == typeof(int) && int.TryParse(searchText, out var @int))
                {
                    searchs.Add(new SearchFilterAction(col.GetFieldName(), @int, FilterAction.Equal));
                }
                else if (type == typeof(long) && long.TryParse(searchText, out var @long))
                {
                    searchs.Add(new SearchFilterAction(col.GetFieldName(), @long, FilterAction.Equal));
                }
                else if (type == typeof(short) && short.TryParse(searchText, out var @short))
                {
                    searchs.Add(new SearchFilterAction(col.GetFieldName(), @short, FilterAction.Equal));
                }
                else if (type == typeof(double) && double.TryParse(searchText, out var @double))
                {
                    searchs.Add(new SearchFilterAction(col.GetFieldName(), @double, FilterAction.Equal));
                }
                else if (type == typeof(float) && float.TryParse(searchText, out var @float))
                {
                    searchs.Add(new SearchFilterAction(col.GetFieldName(), @float, FilterAction.Equal));
                }
                else if (type == typeof(decimal) && decimal.TryParse(searchText, out var @decimal))
                {
                    searchs.Add(new SearchFilterAction(col.GetFieldName(), @decimal, FilterAction.Equal));
                }
            }
        }
        return searchs;
    }
}
