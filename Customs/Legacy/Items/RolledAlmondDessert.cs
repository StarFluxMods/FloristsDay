using KitchenLib.Customs;
using KitchenLib.Utils;
using UnityEngine;

namespace ParentsEvent.Customs.Items
{
    public class RolledAlmondDessert : CustomItem
    {
        public override string UniqueNameID => "RolledAlmondDessert";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("RoastedNutsCone").AssignMaterialsByNames();
    }
}