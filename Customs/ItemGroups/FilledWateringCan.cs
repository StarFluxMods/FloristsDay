using System.Collections.Generic;
using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.References;
using KitchenLib.Utils;
using ParentsEvent.Customs.Items;
using UnityEngine;

namespace ParentsEvent.Customs.ItemGroups
{
    public class FilledWateringCan : CustomItemGroup<ItemGroupView>
    {
        public override string UniqueNameID => "FilledWateringCan";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("FilledWateringCan").AssignMaterialsByNames();

        public override List<ItemGroup.ItemSet> Sets => new List<ItemGroup.ItemSet>
        {
            new ItemGroup.ItemSet
            {
                Items = new List<Item>
                {
                    (Item)GDOUtils.GetCustomGameDataObject<EmptyWateringCan>().GameDataObject
                },
                Min = 1,
                Max = 1
            },
            new ItemGroup.ItemSet
            {
                Items = new List<Item>
                {
                    (Item)GDOUtils.GetExistingGDO(ItemReferences.Water)
                },
                Min = 1,
                Max = 1
            }
        };

        public override bool AllowSplitMerging => true;
        public override bool PreventExplicitSplit => true;
        public override bool SplitByComponents => true;
        public override Item SplitByComponentsHolder => (Item)GDOUtils.GetCustomGameDataObject<EmptyWateringCan>().GameDataObject;
        public override int SplitCount => 3;
        public override float SplitSpeed => 1;
    }
}