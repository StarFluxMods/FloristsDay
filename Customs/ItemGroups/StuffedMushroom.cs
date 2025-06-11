using System.Collections.Generic;
using System.Reflection;
using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using ParentsEvent.Utilities;
using UnityEngine;

namespace ParentsEvent.Customs.ItemGroups
{
    public class StuffedMushroom : CustomItemGroup
    {
        public override string UniqueNameID => "StuffedMushroom";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("StuffedMushroom").AssignMaterialsByNames();
        public override ItemValue ItemValue => ItemValue.SideSmall;

        public override List<ItemGroup.ItemSet> Sets => new()
        {
            new ItemGroup.ItemSet
            {
                Items = new List<Item>
                {
                    GDOReferences.Mushroom,
                    GDOReferences.CheeseGrated,
                },
                Min = 2,
                Max = 2,
            }
        };
    }
}