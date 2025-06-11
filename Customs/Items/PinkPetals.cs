using KitchenLib.Utils;
using ParentsEvent.Customs.Generics;
using UnityEngine;

namespace ParentsEvent.Customs.Items
{
    public class PinkPetals : GenericStackableItem
    {
        public override string UniqueNameID => "PinkPetals";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("PinkPetals").AssignMaterialsByNames();
        public override string ColourBlindTag => "P";
    }
}