namespace Undersoft.SDK.Blazor.Components;

public interface IEntityFrameworkCoreDataService
{
    Task CancelAsync();

    Task EditAsync(object model);
}
