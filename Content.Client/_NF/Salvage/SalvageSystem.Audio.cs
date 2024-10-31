using Content.Shared._NF.CCVar;
using Content.Shared.Salvage;
using Robust.Shared.Configuration;

namespace Content.Client.Salvage;

/// <summary>
///     Handles the client side volume control for expedition music
/// </summary>
public sealed partial class SalvageSystem
{
    [Dependency] private readonly IConfigurationManager _cfg = default!;

    private void InitializeAudio()
    {
        SubscribeLocalEvent<SalvageExpeditionComponent, PlaySalvageAudioEvent>(OnPlaySalvageAudio);
    }

    private void OnPlaySalvageAudio(EntityUid uid, SalvageExpeditionComponent component, PlaySalvageAudioEvent args)
    {
        var volume = _cfg.GetCVar(NFCCVars.SalvageExpeditionVolume);
        args.AudioParams = args.AudioParams.WithVolume(volume);
    }
}
