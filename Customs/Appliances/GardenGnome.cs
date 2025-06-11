using System.Collections.Generic;
using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using ParentsEvent.Customs.Generics;
using ParentsEvent.Customs.Items;
using ParentsEvent.Utilities;
using UnityEngine;

namespace ParentsEvent.Customs.Appliances
{
    public class GardenGnome : GenericDecorationAppliance
    {
        public override string UniqueNameID => "GardenGnome";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("GardenGnome").AssignMaterialsByNames();
        public override List<(Locale, ApplianceInfo)> InfoList => CenteralLang.Appliances.GardenGnome;
    }
}