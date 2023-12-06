﻿namespace Undersoft.SDK.Blazor.Components;

public interface ITableToolbarButton<TItem>
{
    bool IsEnableWhenSelectedOneRow { get; set; }

    Func<IEnumerable<TItem>, bool>? IsDisabledCallback { get; set; }

    bool IsShow { get; set; }
}
