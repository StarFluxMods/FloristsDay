using System.Collections.Generic;
using KitchenData;
using KitchenLib.Utils;
using ParentsEvent.Components;
using ParentsEvent.Customs.Generics;
using ParentsEvent.Utilities;
using UnityEngine;

namespace ParentsEvent.Customs.Items
{
    public class PinkFlower : GenericFlower
    {
        public override string UniqueNameID => "PinkFlower";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("PinkFlower").AssignMaterialsByNames();
        public override string ColourBlindTag => "P";
        public override List<Item.ItemProcess> Processes => new List<Item.ItemProcess>
        {
            new Item.ItemProcess
            {
                Process = GDOReferences.Chop,
                Duration = 0.5f,
                Result = GDOReferences.PinkPetals
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