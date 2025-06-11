using Kitchen;
using KitchenLib.Preferences;
using KitchenLib.UI;
using KitchenMods;
using ParentsEvent.Components;
using Unity.Entities;

namespace ParentsEvent.Systems
{
    public class MysteryMeatWarning : FranchiseFirstFrameSystem, IModSystem
    {
        private EntityQuery _WarningPopup;
        protected override void Initialise()
        {
            base.Initialise();
            _WarningPopup = GetEntityQuery(typeof(SWarningPopup));
        }
        
        protected override void OnUpdate()
        {
            if (!_WarningPopup.IsEmpty) return;
            if (Mod.manager.GetPreference<PreferenceBool>(Mod.PREFERENCE_HAS_SHOWN_MYSTERY_MEAT_WARNING).Value) return;
            if (!Mod.IsMysteryMeatInstalled) return;
            
            GenericPopupManager.CreatePopup(
                Mod.MOD_NAME,
                $"We have detected that you have the Mystery Meat (3350486642) mod installed!\n\nHaving this mod installed will intentionally prevent the 'Children' card from being available, and functional.\n\nBy continuing, you understand this message will not be shown again.",
                GenericChoiceType.AcceptOrConsentCancel,
                () =>
                {
                    Mod.manager.GetPreference<PreferenceBool>(Mod.PREFERENCE_HAS_SHOWN_MYSTERY_MEAT_WARNING).Set(true);
                    Mod.manager.Save();
                },
                null,
                TMPro.TextAlignmentOptions.Center
            );
        }
    }
}