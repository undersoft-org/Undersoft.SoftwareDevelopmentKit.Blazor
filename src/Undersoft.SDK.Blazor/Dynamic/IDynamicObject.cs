namespace Undersoft.SDK.Blazor.Components;

public interface IDynamicObject
{
    object? GetValue(string propertyName);

    void SetValue(string propertyName, object? value);

    Guid DynamicObjectPrimaryKey { get; set; }
}
