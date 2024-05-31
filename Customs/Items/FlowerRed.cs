using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using ParentsEvent.Customs.Appliances;
using UnityEngine;

namespace ParentsEvent.Customs.Items
{
    public class FlowerRed : CustomItem
    {
        public override string UniqueNameID => "FlowerRed";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("Flower Red").AssignMaterialsByNames();
        public override string ColourBlindTag => "R";
    }
}