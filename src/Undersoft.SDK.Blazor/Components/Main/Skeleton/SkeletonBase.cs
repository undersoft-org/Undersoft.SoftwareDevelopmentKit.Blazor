﻿namespace Undersoft.SDK.Blazor.Components;

public abstract class SkeletonBase : PresenterComponent
{
    [Parameter]
    public bool Round { get; set; } = true;

    [Parameter]
    public bool Active { get; set; } = true;

    protected string? ClassString => CssBuilder.Default("skeleton-content")
        .AddClass("active", Active)
        .AddClass("round", Round)
        .Build();
}
