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
    public class ChocolateBarkRaw : CustomItemGroup
    {
        public override string UniqueNameID => "ChocolateBarkRaw";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("ChocolateBarkRaw").AssignMaterialsByNames();
        public override bool IsIndisposable => true;

        public override List<ItemGroup.ItemSet> Sets => new()
        {
            new ItemGroup.ItemSet
            {
                Items = new List<Item>
                {
                    GDOReferences.CookieTray,
                },
                Min = 1,
                Max = 1,
                IsMandatory = true
            },
            new ItemGroup.ItemSet
            {
                Items = new List<Item>
                {
                    GDOReferences.ChocolateMelted,
                    GDOReferences.NutsChopped
                },
                Min = 2,
                Max = 2
            }
        };

        public override List<Item.ItemProcess> Processes => new()
        {
            new Item.ItemProcess
            {
                Process = GDOReferences.SteepTea,
                Duration = 3,
                Result = GDOReferences.ChocolateBarkChilled,
            }
        };
        
        public override Item.ItemProcess AutomaticItemProcess => new Item.ItemProcess
        {
            Process = GDOReferences.SteepTea,
            Duration = 3,
            Result = GDOReferences.ChocolateBarkChilled,
        };

        public override void OnRegister(ItemGroup gameDataObject)
        {
            base.OnRegister(gameDataObject);

            if (gameDataObject.Prefab.TryGetComponent(out ItemGroupView itemGroupView))
            {
                itemGroupView.ComponentGroups = new List<ItemGroupView.ComponentGroup>
                {
                    new ItemGroupView.ComponentGroup
                    {
                        Item = GDOReferences.ChocolateMelted,
                        GameObject = gameDataObject.Prefab.GetChild("Chocolate")
                    },
                    new ItemGroupView.ComponentGroup
                    {
                        Item = GDOReferences.NutsChopped,
                        GameObject = gameDataObject.Prefab.GetChild("Roasted Nuts.012")
                    }
                };
            }
        }
    }
}