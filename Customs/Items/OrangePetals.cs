using KitchenLib.Utils;
using ParentsEvent.Customs.Generics;
using UnityEngine;

namespace ParentsEvent.Customs.Items
{
    public class OrangePetals : GenericStackableItem
    {
        public override string UniqueNameID => "OrangePetals";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("OrangePetals").AssignMaterialsByNames();
        public override string ColourBlindTag => "O";
    }
}