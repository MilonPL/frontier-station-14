using Robust.Shared.Audio; // Frontier
using Robust.Shared.GameStates;
using Robust.Shared.Serialization;

namespace Content.Shared.Salvage.Expeditions;

[NetworkedComponent]
public abstract partial class SharedSalvageExpeditionComponent : Component
{
    [ViewVariables(VVAccess.ReadWrite), DataField("stage")]
    public ExpeditionStage Stage = ExpeditionStage.Added;

    // Frontier: Moved from Server
    [DataField]
    public SoundSpecifier Sound = new SoundCollectionSpecifier("ExpeditionEnd");
}

[Serializable, NetSerializable]
public sealed class SalvageExpeditionComponentState : ComponentState
{
    public ExpeditionStage Stage;
}
