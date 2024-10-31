using Robust.Shared.Audio;

namespace Content.Shared.Salvage;

/// <summary>
///     Raised before playing salvage expedition audio to allow modification of audio parameters
/// </summary>
public struct PlaySalvageAudioEvent(AudioParams audioParams)
{
    public AudioParams AudioParams = audioParams;
}
