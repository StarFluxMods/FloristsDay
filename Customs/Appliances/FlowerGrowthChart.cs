using System.Collections.Generic;
using Kitchen;
using KitchenData;
using KitchenLib.Utils;
using ParentsEvent.Customs.Generics;
using ParentsEvent.Utilities;
using UnityEngine;

namespace ParentsEvent.Customs.Appliances
{
    public class FlowerGrowthChart : GenericDecorationAppliance
    {
        public override string UniqueNameID => "FlowerGrowthChart";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("FlowerGrowthChart").AssignMaterialsByNames();
        public override OccupancyLayer Layer => OccupancyLayer.Wall;
        public override List<IApplianceProperty> Properties => new List<IApplianceProperty>
        {
            new CMustHaveWall()
        };
        public override List<(Locale, ApplianceInfo)> InfoList => CenteralLang.Appliances.FlowerGrowthChart;
    }
}