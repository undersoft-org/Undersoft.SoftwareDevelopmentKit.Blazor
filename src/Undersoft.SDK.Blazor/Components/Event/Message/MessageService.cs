namespace Undersoft.SDK.Blazor.Components;

public class MessageService : PresenterService<MessageOption>
{
    private PresenterOptions Options { get; }

    public MessageService(IOptionsMonitor<PresenterOptions> option)
    {
        Options = option.CurrentValue;
    }

    public async Task Show(MessageOption option, Message? message = null)
    {
        if (!option.ForceDelay)
        {
            if (Options.MessageDelay != 0)
            {
                option.Delay = Options.MessageDelay;
            }
        }
        await Invoke(option, message);
    }
}
