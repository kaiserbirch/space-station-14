using Robust.Shared.Audio;
using Robust.Shared.GameStates;
using Robust.Shared.Serialization;

namespace Content.Shared.LandMines;

[RegisterComponent, NetworkedComponent, AutoGenerateComponentState]
public sealed partial class LandMineComponent : Component
{
    /// <summary>
    /// Trigger sound effect when stepping onto landmine
    /// </summary>
    [DataField]
    public SoundSpecifier? Sound;

    /// <summary>
    /// Is the land mine armed and dangerous?
    /// </summary>
    [DataField, AutoNetworkedField]
    public bool Armed = false;
}

[Serializable, NetSerializable]
public enum LandMineVisuals
{
    Armed,
}
