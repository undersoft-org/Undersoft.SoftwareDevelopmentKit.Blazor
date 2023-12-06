namespace Undersoft.SDK.Blazor.Components;

public class VideoSources
{
    public VideoSources(string type, string src)
    {
        Type = type;
        Src = src;
    }

    public string Type { get; set; } = "application/x-mpegURL";

    public string Src { get; set; }
}
