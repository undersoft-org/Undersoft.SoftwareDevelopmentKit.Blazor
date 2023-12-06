namespace Undersoft.SDK.Blazor.Components;

public interface ICheckableNode<TItem> : IExpandableNode<TItem>
{
    CheckboxState CheckedState { get; set; }
}
