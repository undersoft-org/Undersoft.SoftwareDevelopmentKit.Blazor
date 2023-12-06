namespace Undersoft.SDK.Blazor.Components;

public interface IDispatchService<TEntry>
{
    void Dispatch(DispatchEntry<TEntry> entry);

    void Subscribe(Func<DispatchEntry<TEntry>, Task> callback);

    void UnSubscribe(Func<DispatchEntry<TEntry>, Task> callback);
}
