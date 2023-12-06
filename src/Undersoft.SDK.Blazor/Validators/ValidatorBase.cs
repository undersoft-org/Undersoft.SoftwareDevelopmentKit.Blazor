﻿namespace Undersoft.SDK.Blazor.Components;

public abstract class ValidatorBase : IValidator
{
    public abstract void Validate(object? propertyValue, ValidationContext context, List<ValidationResult> results);
}
