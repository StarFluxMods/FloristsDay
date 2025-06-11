using KitchenLib.Preferences;
using UnityEngine;

namespace ParentsEvent.Views.Local
{
    public class PollenView : MonoBehaviour
    {
        public GameObject Pollen;

        private void Update()
        {
            if (Mod.manager.GetPreference<PreferenceBool>(Mod.PREFERENCE_ENABLE_POLLEN).Value != Pollen.activeInHierarchy)
            {
                Pollen.SetActive(Mod.manager.GetPreference<PreferenceBool>(Mod.PREFERENCE_ENABLE_POLLEN).Value);
            }
        }
    }
}