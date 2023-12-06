﻿namespace Undersoft.SDK.Blazor.Components;

public class RecognizerService
{
    private IRecognizerProvider Provider { get; }

    public RecognizerService(IRecognizerProvider provider)
    {
        Provider = provider;
    }

    public Task InvokeAsync(RecognizerOption option) => Provider.InvokeAsync(option);
}
