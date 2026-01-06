using Content.Shared.Implants;
using Content.Shared.Mindshield.Components;

namespace Content.Shared._Reserve.Implants;
public sealed partial class ChemicalImplantSystem : EntitySystem
{
    public override void Initialize()
    {
        base.Initialize();
        SubscribeLocalEvent<InjectChemicalImplantEvent>(OnInjectChemicalImplant);
        SubscribeLocalEvent< SubscribeLocalEvent<FakeMindShieldImplantComponent, ImplantImplantedEvent>
    }

    private void OnInjectChemicalImplant(InjectChemicalImplantEvent args)
    {

    }
}
