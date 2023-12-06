using System.Diagnostics.CodeAnalysis;

namespace Undersoft.SDK.Blazor.Components;

public abstract class IdComponent : PresenterComponent
{
    [Parameter]
    [NotNull]
    public virtual string? Id { get; set; }

    [Inject]
    [NotNull]
    protected IComponentIdGenerator? ComponentIdGenerator { get; set; }

    protected virtual string? RetrieveId() => Id;

    protected override void OnInitialized()
    {
        base.OnInitialized();

        Id ??= ComponentIdGenerator.Generate(this);
    }
}
