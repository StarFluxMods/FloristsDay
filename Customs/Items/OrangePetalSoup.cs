using KitchenData;
using KitchenLib.Utils;
using ParentsEvent.Customs.Generics;
using UnityEngine;

namespace ParentsEvent.Customs.Items
{
    public class OrangePetalSoup : GenericStackableItem
    {
        public override string UniqueNameID => "OrangePetalSoup";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("OrangePetalSoup").AssignMaterialsByNames();
        public override string ColourBlindTag => "O";
        public override ItemValue ItemValue => ItemValue.SideLarge;
    }
}