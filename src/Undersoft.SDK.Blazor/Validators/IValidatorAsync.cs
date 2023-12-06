namespace Undersoft.SDK.Blazor.Components;

public interface IValidatorAsync : IValidator
{
    Task ValidateAsync(object? propertyValue, ValidationContext context, List<ValidationResult> results);
}
