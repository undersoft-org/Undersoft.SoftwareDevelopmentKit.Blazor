namespace Undersoft.SDK.Blazor.Components;

public class DynamicObject : IDynamicObject
{
    [AutoGenerateColumn(Ignore = true)]
    public Guid DynamicObjectPrimaryKey { get; set; }

    public virtual object? GetValue(string propertyName) => Utility.GetPropertyValue(this, propertyName);

    public virtual void SetValue(string propertyName, object? value) => Utility.SetPropertyValue<object, object?>(this, propertyName, value);
}
