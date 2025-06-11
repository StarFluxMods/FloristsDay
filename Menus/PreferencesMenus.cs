using System.Collections.Generic;
using Kitchen;
using Kitchen.Modules;
using KitchenLib;
using KitchenLib.Preferences;
using UnityEngine;

namespace ParentsEvent.Menus
{
    public class PreferencesMenus : KLMenu
    {
        public PreferencesMenus(Transform container, ModuleList module_list) : base(container, module_list)
        {
        }
        
        private Option<bool> PREFERENCE_ENABLE_POLLEN = new(new List<bool>{true, false}, Mod.manager.GetPreference<PreferenceBool>(Mod.PREFERENCE_ENABLE_POLLEN).Value, new List<string>{"Enabled", "Disabled"});
        private Option<bool> PREFERENCE_ENABLE_SPRINKLER_MIST = new(new List<bool>{true, false}, Mod.manager.GetPreference<PreferenceBool>(Mod.PREFERENCE_ENABLE_SPRINKLER_MIST ).Value, new List<string>{"Enabled", "Disabled"});
        private Option<bool> PREFERENCE_ENABLE_LEGACY = new(new List<bool>{true, false}, Mod.manager.GetPreference<PreferenceBool>(Mod.PREFERENCE_ENABLE_LEGACY).Value, new List<string>{"Enabled", "Disabled"});
        
        public override void Setup(int player_id)
        {
            AddLabel(Mod.MOD_NAME);
            New<SpacerElement>(true);

            AddLabel("Show Pollen Effect");
            AddSelect(PREFERENCE_ENABLE_POLLEN);
            PREFERENCE_ENABLE_POLLEN.OnChanged += delegate (object _, bool result)
            {
                Mod.manager.GetPreference<PreferenceBool>(Mod.PREFERENCE_ENABLE_POLLEN).Set(result);
                Mod.manager.Save();
            };
            New<SpacerElement>(true);

            AddLabel("Show Sprinkler Mist");
            AddSelect(PREFERENCE_ENABLE_SPRINKLER_MIST);
            PREFERENCE_ENABLE_SPRINKLER_MIST.OnChanged += delegate (object _, bool result)
            {
                Mod.manager.GetPreference<PreferenceBool>(Mod.PREFERENCE_ENABLE_SPRINKLER_MIST).Set(result);
                Mod.manager.Save();
            };
            New<SpacerElement>(true);

            AddLabel("Enable Legacy Content (Requires Restart)");
            AddSelect(PREFERENCE_ENABLE_LEGACY);
            PREFERENCE_ENABLE_LEGACY.OnChanged += delegate (object _, bool result)
            {
                Mod.manager.GetPreference<PreferenceBool>(Mod.PREFERENCE_ENABLE_LEGACY).Set(result);
                Mod.manager.Save();
            };
            
            New<SpacerElement>(true);
            New<SpacerElement>(true);
            
            AddButton(base.Localisation["MENU_BACK_SETTINGS"], delegate (int i)
            {
                RequestPreviousMenu();
            }, 0, 1f, 0.2f);
        }
    }
}