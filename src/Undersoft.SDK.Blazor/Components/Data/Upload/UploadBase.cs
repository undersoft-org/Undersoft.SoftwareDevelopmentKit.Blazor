﻿using Microsoft.AspNetCore.Components.Forms;

namespace Undersoft.SDK.Blazor.Components;

[JSModuleAutoLoader("upload", ModuleName = "Upload")]
public abstract class UploadBase<TValue> : ValidateBase<TValue>, IUpload
{
    protected string? ClassString => CssBuilder.Default("upload")
        .AddClassFromAttributes(AdditionalAttributes)
        .Build();

    protected UploadFile? CurrentFile { get; set; }

    protected List<UploadFile> UploadFiles { get; } = new List<UploadFile>();

    List<UploadFile> IUpload.UploadFiles { get => UploadFiles; }

    [Parameter]
    public string? Accept { get; set; }

    [Parameter]
    public string? Capture { get; set; }

    [Parameter]
    public Func<UploadFile, Task<bool>>? OnDelete { get; set; }

    [Parameter]
    public Func<UploadFile, Task>? OnChange { get; set; }

    public override void ToggleMessage(IEnumerable<ValidationResult> results, bool validProperty)
    {
        if (FieldIdentifier != null)
        {
            var messages = results.Where(item => item.MemberNames.Any(m => UploadFiles.Any(f => f.ValidateId?.Equals(m, StringComparison.OrdinalIgnoreCase) ?? false)));
            if (messages.Any())
            {
                IsValid = false;
                if (CurrentFile != null)
                {
                    var msg = messages.FirstOrDefault(m => m.MemberNames.Any(f => f.Equals(CurrentFile.ValidateId, StringComparison.OrdinalIgnoreCase)));
                    if (msg != null)
                    {
                        ErrorMessage = msg.ErrorMessage;
                    }
                }
            }
            else
            {
                ErrorMessage = null;
                IsValid = true;
            }
            OnValidate(IsValid);
        }
    }

    protected virtual async Task<bool> OnFileDelete(UploadFile item)
    {
        var ret = true;
        if (OnDelete != null)
        {
            ret = await OnDelete(item);
        }
        ErrorMessage = null;
        return ret;
    }

    protected virtual Task OnFileChange(InputFileChangeEventArgs args)
    {
        var type = NullableUnderlyingType ?? typeof(TValue);
        if (type.IsAssignableTo(typeof(IBrowserFile)))
        {
            CurrentValue = (TValue)args.File;
        }
        if (type.IsAssignableTo(typeof(List<IBrowserFile>)))
        {
            CurrentValue = (TValue)(object)UploadFiles.Select(f => f.File).ToList();
        }
        return Task.CompletedTask;
    }

    protected virtual IDictionary<string, object> GetUploadAdditionalAttributes()
    {
        var ret = new Dictionary<string, object>
        {
            { "hidden", "hidden" }
        };
        if (!string.IsNullOrEmpty(Accept))
        {
            ret.Add("accept", Accept);
        }
        if (!string.IsNullOrEmpty(Capture))
        {
            ret.Add("capture", Capture);
        }
        return ret;
    }

    public virtual void Reset()
    {
        UploadFiles.Clear();
        StateHasChanged();
    }
}
