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
    public class FlowerRug : GenericDecorationAppliance
    {
        public override string UniqueNameID => "FlowerRug";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("FlowerRug").AssignMaterialsByNames();
        public override List<(Locale, ApplianceInfo)> InfoList => CenteralLang.Appliances.FlowerRug;
        public override OccupancyLayer Layer => OccupancyLayer.Floor;
    }
}