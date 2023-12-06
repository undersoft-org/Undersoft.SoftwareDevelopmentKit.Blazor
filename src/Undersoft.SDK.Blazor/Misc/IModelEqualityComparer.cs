﻿namespace Undersoft.SDK.Blazor.Components;

public interface IModelEqualityComparer<TItem>
{
    Func<TItem, TItem, bool>? ModelEqualityComparer { get; set; }

    Type CustomKeyAttribute { get; set; }

    bool Equals(TItem? x, TItem? y);
}
