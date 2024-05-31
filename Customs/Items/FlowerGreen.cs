using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using ParentsEvent.Customs.Appliances;
using Unity.Entities;
using UnityEngine;

namespace ParentsEvent.Customs.Items
{
    public class FlowerGreen : CustomItem
    {
        public override string UniqueNameID => "FlowerGreen";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("Flower Green").AssignMaterialsByNames();
        public override string ColourBlindTag => "O";
    }
}