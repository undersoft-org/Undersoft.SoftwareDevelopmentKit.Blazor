namespace Undersoft.SDK.Blazor.Components;

public class DateTimeRangeSidebarItem
{
    [NotNull]
    public string? Text { get; set; }

    public DateTime StartDateTime { get; set; }

    public DateTime EndDateTime { get; set; }
}
