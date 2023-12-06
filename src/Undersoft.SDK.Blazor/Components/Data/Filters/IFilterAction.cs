﻿namespace Undersoft.SDK.Blazor.Components;

public interface IFilterAction
{
    IEnumerable<FilterKeyValueAction> GetFilterConditions();

    void Reset();

    Task SetFilterConditionsAsync(IEnumerable<FilterKeyValueAction> conditions);
}
