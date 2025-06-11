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
    public class PressedFlowerFrame : GenericDecorationAppliance
    {
        public override string UniqueNameID => "PressedFlowerFrame";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("PressedFlowerFrame").AssignMaterialsByNames();
        public override OccupancyLayer Layer => OccupancyLayer.Wall;
        public override List<IApplianceProperty> Properties => new List<IApplianceProperty>
        {
            new CMustHaveWall()
        };
        public override List<(Locale, ApplianceInfo)> InfoList => CenteralLang.Appliances.PressedFlowerFrame;
    }
}