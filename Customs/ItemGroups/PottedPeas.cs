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
    public class PottedPeas : CustomItemGroup
    {
        public override string UniqueNameID => "PottedPeas";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("PottedPeas").AssignMaterialsByNames();
        public override Item DisposesTo => GDOReferences.Pot;

        public override List<ItemGroup.ItemSet> Sets => new()
        {
            new ItemGroup.ItemSet
            {
                Items = new List<Item>
                {
                    GDOReferences.Pot,
                },
                Min = 1,
                Max = 1,
                IsMandatory = true
            },
            new ItemGroup.ItemSet
            {
                Items = new List<Item>
                {
                    GDOReferences.Water,
                    GDOReferences.RawPeas,
                },
                Min = 2,
                Max = 2
            }
        };

        public override List<Item.ItemProcess> Processes => new()
        {
            new Item.ItemProcess
            {
                Process = GDOReferences.Cook,
                Duration = 2,
                Result = GDOReferences.CookedPeasPot
            }
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
                        Item = GDOReferences.Water,
                        GameObject = gameDataObject.Prefab.GetChild("Pot.001/Water.001")
                    },
                    new ItemGroupView.ComponentGroup
                    {
                        Item = GDOReferences.RawPeas,
                        GameObject = gameDataObject.Prefab.GetChild("PottedPeas")
                    }
                };
            }
        }
    }
}