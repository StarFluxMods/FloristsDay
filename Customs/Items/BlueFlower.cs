using System.Collections.Generic;
using KitchenData;
using KitchenLib.References;
using KitchenLib.Utils;
using ParentsEvent.Components;
using ParentsEvent.Customs.Generics;
using ParentsEvent.Utilities;
using UnityEngine;

namespace ParentsEvent.Customs.Items
{
    public class BlueFlower : GenericFlower
    {
        public override string UniqueNameID => "BlueFlower";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("BlueFlower").AssignMaterialsByNames();
        public override string ColourBlindTag => "B";
        public override List<Item.ItemProcess> Processes => new List<Item.ItemProcess>
        {
            new Item.ItemProcess
            {
                Process = GDOReferences.Chop,
                Duration = 0.5f,
                Result = GDOReferences.BluePetals
            }
        };
        public override List<IItemProperty> Properties => new List<IItemProperty>
        {
            new CCanWilt
            {
                WiltItem = GDOReferences.WiltedFlower.ID,
                WiltDelay = 15
            }
        };
    }
}