using KitchenData;
using KitchenLib.Utils;
using ParentsEvent.Customs.Generics;
using UnityEngine;

namespace ParentsEvent.Customs.Items
{
    public class PinkPetalSoup : GenericStackableItem
    {
        public override string UniqueNameID => "PinkPetalSoup";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("PinkPetalSoup").AssignMaterialsByNames();
        public override string ColourBlindTag => "P";
        public override ItemValue ItemValue => ItemValue.SideLarge;
    }
}