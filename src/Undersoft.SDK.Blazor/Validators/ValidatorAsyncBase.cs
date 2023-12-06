﻿namespace Undersoft.SDK.Blazor.Components;

public abstract class ValidatorAsyncBase : IValidatorAsync
{
    [ExcludeFromCodeCoverage]
    void IValidator.Validate(object? propertyValue, ValidationContext context, List<ValidationResult> results)
    {

    }

    public abstract Task ValidateAsync(object? propertyValue, ValidationContext context, List<ValidationResult> results);
}
