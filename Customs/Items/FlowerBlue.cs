using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using ParentsEvent.Customs.Appliances;
using UnityEngine;

namespace ParentsEvent.Customs.Items
{
    public class FlowerBlue : CustomItem
    {
        public override string UniqueNameID => "FlowerBlue";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("Flower Blue").AssignMaterialsByNames();
        public override string ColourBlindTag => "B";
    }
}