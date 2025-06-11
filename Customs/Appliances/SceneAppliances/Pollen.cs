using System.Collections.Generic;
using Kitchen;
using KitchenData;
using KitchenLib.Utils;
using ParentsEvent.Customs.Generics;
using ParentsEvent.Utilities;
using ParentsEvent.Views.Local;
using UnityEngine;

namespace ParentsEvent.Customs.Appliances.SceneAppliances
{
    public class Pollen : GenericSceneAppliance
    {
        public override string UniqueNameID => "Pollen";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("Pollen").AssignMaterialsByNames();
        public override List<(Locale, ApplianceInfo)> InfoList => CenteralLang.Appliances.Pollen;
        public override void OnRegister(Appliance gameDataObject)
        {
            base.OnRegister(gameDataObject);
            PollenView pollenView = gameDataObject.Prefab.AddComponent<PollenView>();
            pollenView.Pollen = gameDataObject.Prefab.GetChild("FX_Pollen_Wind_01");
        }
    }
}