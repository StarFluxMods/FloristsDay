using System.Collections.Generic;
using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.References;
using KitchenLib.Utils;
using ParentsEvent.Customs.Items;
using ParentsEvent.Utilities;
using UnityEngine;

namespace ParentsEvent.Customs.ItemGroups
{
    public class WetDirt : CustomItemGroup
    {
        public override string UniqueNameID => "WetDirt";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("WetDirt");

        public override List<ItemGroup.ItemSet> Sets => new List<ItemGroup.ItemSet>
        {
            new ItemGroup.ItemSet
            {
                Items = new List<Item>
                {
                    GDOReferences.Water,
                    GDOReferences.DryDirt
                },
                Min = 2,
                Max = 2
            }
        };
    }
}