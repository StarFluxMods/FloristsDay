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
    public class BeeHive : GenericDecorationAppliance
    {
        public override string UniqueNameID => "BeeHive";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("BeeHive").AssignMaterialsByNames();
        public override List<(Locale, ApplianceInfo)> InfoList => CenteralLang.Appliances.GardenGnome;
    }
}