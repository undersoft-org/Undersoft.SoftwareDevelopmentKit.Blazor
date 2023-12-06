namespace Undersoft.SDK.Blazor.Components;

public interface IValidator
{
    void Validate(object? propertyValue, ValidationContext context, List<ValidationResult> results);
}
