namespace Undersoft.SDK.Blazor.Components;

public class VideoPlayerOption
{
    public int Width { get; set; } = 300;

    public int Height { get; set; } = 200;

    public bool Controls { get; set; } = true;

    public bool Autoplay { get; set; } = true;

    public string Preload { get; set; } = "auto";

    public List<VideoSources> Sources { get; set; } = new List<VideoSources>();

    public string? Poster { get; set; }

    public string? Language { get; set; } = "zh-CN";
}
