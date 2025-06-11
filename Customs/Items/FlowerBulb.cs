using System.Collections.Generic;
using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.References;
using KitchenLib.Utils;
using ParentsEvent.Components;
using ParentsEvent.Customs.Generics;
using ParentsEvent.Utilities;
using Unity.Collections;
using UnityEngine;

namespace ParentsEvent.Customs.Items
{
    public class FlowerBulb : CustomItem
    {
        public override string UniqueNameID => "FlowerBulb";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("FlowerBulb").AssignMaterialsByNames();

        public override List<IItemProperty> Properties => new List<IItemProperty>
        {
            new CHasGrowthStages
            {
                CanGrowInto = new FixedList32<int>
                {
                    GDOReferences.BlueFlower.ID,
                    GDOReferences.OrangeFlower.ID,
                    GDOReferences.PinkFlower.ID,
                }
            },
            new CCanWilt
            {
                WiltItem = GDOReferences.WiltedFlowerBulb.ID,
                WiltDelay = 5
            }
        };
    }
}