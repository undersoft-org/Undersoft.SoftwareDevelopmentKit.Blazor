﻿// Copyright (c) Argo Zhang (argo@163.com). All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.
// Website: https://www.blazor.zone or https://argozhang.github.io/

namespace Undersoft.SDK.Blazor.Components;

public partial class Table<TItem>
{
    /// <summary>
    /// 获得/设置 是否分页 默认为 false
    /// </summary>
    [Parameter]
    public bool IsPagination { get; set; }

    /// <summary>
    /// 获得/设置 是否在顶端显示分页 默认为 false
    /// </summary>
    [Parameter]
    public bool ShowTopPagination { get; set; }

    /// <summary>
    /// 获得/设置 是否显示行号列 默认为 false
    /// </summary>
    [Parameter]
    public bool ShowLineNo { get; set; }

    /// <summary>
    /// 获得/设置 行号列标题文字 默认为 行号
    /// </summary>
    [Parameter]
    [NotNull]
    public string? LineNoText { get; set; }

    /// <summary>
    /// 获得/设置 每页显示数据数量的外部数据源
    /// </summary>
    [Parameter]
    [NotNull]
    public IEnumerable<int>? PageItemsSource { get; set; }

    /// <summary>
    /// 异步查询回调方法，设置 <see cref="Items"/> 后无法触发此回调方法
    /// </summary>
    [Parameter]
    public Func<QueryPageOptions, Task<QueryData<TItem>>>? OnQueryAsync { get; set; }

    /// <summary>
    /// 获得/设置 数据总条目
    /// </summary>
    protected int TotalCount { get; set; }

    /// <summary>
    /// 获得/设置 分页页码总数 内置规则 PageCount > 1 时显示分页组件
    /// </summary>
    protected int PageCount { get; set; }

    /// <summary>
    /// 获得/设置 当前页码 默认 1
    /// </summary>
    protected int PageIndex { get; set; } = 1;

    /// <summary>
    /// 获得/设置 默认每页数据数量 默认 0 使用 <see cref="PageItemsSource"/> 第一个值
    /// </summary>
    [Parameter]
    public int PageItems { get; set; }

    /// <summary>
    /// 获得/设置 是否显示 Goto 跳转导航
    /// </summary>
    [Parameter]
    public bool ShowGotoNavigator { get; set; } = true;

    /// <summary>
    /// 获得/设置 是否显示 Goto 跳转导航文本信息 默认 null
    /// </summary>
    [Parameter]
    public string? GotoNavigatorLabelText { get; set; }

    /// <summary>
    /// 获得/设置 Goto 导航模板
    /// </summary>
    [Parameter]
    public RenderFragment? GotoTemplate { get; set; }

    /// <summary>
    /// 获得/设置 是否显示 Goto 跳转导航
    /// </summary>
    [Parameter]
    public bool ShowPageInfo { get; set; } = true;

    /// <summary>
    /// 获得/设置 分页信息文字 默认 null
    /// </summary>
    [Parameter]
    public string? PageInfoText { get; set; }

    /// <summary>
    /// 获得/设置 分页信息模板
    /// </summary>
    [Parameter]
    public RenderFragment? PageInfoTemplate { get; set; }

    /// <summary>
    /// 获得/设置 当前行
    /// </summary>
    protected int StartIndex { get; set; }

    /// <summary>
    /// 内部 分页信息模板
    /// </summary>
    [NotNull]
    protected RenderFragment? InternalPageInfoTemplate => builder =>
    {
        if (PageInfoTemplate != null)
        {
            builder.AddContent(0, PageInfoTemplate);
        }
        else if (!string.IsNullOrEmpty(PageInfoText))
        {
            builder.OpenElement(1, "div");
            builder.AddAttribute(2, "class", "page-info");
            builder.AddContent(3, PageInfoText);
            builder.CloseElement();
        }
        else
        {
            builder.AddContent(4, RenderPageInfo);
        }
    };

    /// <summary>
    /// 点击页码调用此方法
    /// </summary>
    /// <param name="pageIndex"></param>
    protected async Task OnPageLinkClick(int pageIndex)
    {
        if (pageIndex != PageIndex)
        {
            PageIndex = pageIndex;

            // 清空选中行
            SelectedRows.Clear();

            // 无刷新查询数据
            await QueryAsync(false);

            // 通知 SelectedRow 双向绑定集合改变
            await OnSelectedRowsChanged();
        }
    }

    /// <summary>
    /// 每页记录条数变化是调用此方法
    /// </summary>
    protected async Task OnPageItemsValueChanged(int pageItems)
    {
        if (PageItems != pageItems)
        {
            PageIndex = 1;
            PageItems = pageItems;
            await QueryAsync();
        }
    }

    private List<SelectedItem>? _pageItemsSource;

    /// <summary>
    /// 获得 分页数据源
    /// </summary>
    /// <returns></returns>
    protected List<SelectedItem> GetPageItemsSource()
    {
        _pageItemsSource ??= PageItemsSource.Select(i => new SelectedItem($"{i}", Localizer["PageItemsText", i].Value)).ToList();
        return _pageItemsSource;
    }
}
