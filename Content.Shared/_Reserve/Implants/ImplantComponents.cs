using Content.Shared.Actions;
using Content.Shared.Containers.ItemSlots;
using Robust.Shared.GameStates;

namespace Content.Shared._Reserve.Implants;

[RegisterComponent, NetworkedComponent/*, AutoGenerateComponentState*/]
public sealed partial class ChemicalImplantComponent : Component
{
    [DataField(required: true)]
    public ItemSlot VialSlot;
}

public sealed partial class InjectChemicalImplantEvent : InstantActionEvent;
