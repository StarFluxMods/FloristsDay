using System.Collections.Generic;
using KitchenData;
using KitchenLib.Utils;
using ParentsEvent.Components;
using ParentsEvent.Customs.Generics;
using ParentsEvent.Utilities;
using UnityEngine;

namespace ParentsEvent.Customs.Items
{
    public class OrangeFlower : GenericFlower
    {
        public override string UniqueNameID => "OrangeFlower";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("OrangeFlower").AssignMaterialsByNames();
        public override string ColourBlindTag => "O";
        public override List<Item.ItemProcess> Processes => new List<Item.ItemProcess>
        {
            new Item.ItemProcess
            {
                Process = GDOReferences.Chop,
                Duration = 0.5f,
                Result = GDOReferences.OrangePetals
            }
        };
        public override List<IItemProperty> Properties => new List<IItemProperty>
        {
            new CCanWilt
            {
                WiltItem = GDOReferences.WiltedFlower.ID,
                WiltDelay = 5
            }
        };
    }
}