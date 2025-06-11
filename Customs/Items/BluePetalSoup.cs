using KitchenData;
using KitchenLib.Utils;
using ParentsEvent.Customs.Generics;
using UnityEngine;

namespace ParentsEvent.Customs.Items
{
    public class BluePetalSoup : GenericStackableItem
    {
        public override string UniqueNameID => "BluePetalSoup";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("BluePetalSoup").AssignMaterialsByNames();
        public override string ColourBlindTag => "B";
        public override ItemValue ItemValue => ItemValue.SideLarge;
    }
}