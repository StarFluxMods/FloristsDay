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
    public class UnrolledAlmondDessert : CustomItemGroup<ItemGroupView>
    {
        public override string UniqueNameID => "UnrolledAlmondDessert";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("RoastedNutsUnrolled").AssignMaterialsByNames();

        public override List<ItemGroup.ItemSet> Sets => new List<ItemGroup.ItemSet>
        {
            new ItemGroup.ItemSet
            {
                Items = new List<Item>
                {
                    (Item)GDOUtils.GetExistingGDO(ItemReferences.Sugar),
                    (Item)GDOUtils.GetCustomGameDataObject<RoastedNuts>().GameDataObject
                },
                Min = 2,
                Max = 2
            }
        };

        public override List<Item.ItemProcess> Processes => new List<Item.ItemProcess>
        {
            new Item.ItemProcess
            {
                Process = (Process)GDOUtils.GetExistingGDO(ProcessReferences.Knead),
                Duration = 2,
                Result = (Item)GDOUtils.GetCustomGameDataObject<RolledAlmondDessert>().GameDataObject
            }
        };
    }
}