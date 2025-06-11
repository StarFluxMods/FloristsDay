using KitchenLib.Utils;
using ParentsEvent.Customs.Generics;
using UnityEngine;

namespace ParentsEvent.Customs.Items
{
    public class BluePetals : GenericStackableItem
    {
        public override string UniqueNameID => "BluePetals";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("BluePetals").AssignMaterialsByNames();
        public override string ColourBlindTag => "B";
    }
}