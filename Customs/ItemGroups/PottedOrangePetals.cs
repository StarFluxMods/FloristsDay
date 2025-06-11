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
    public class PottedOrangePetals : CustomItemGroup
    {
        public override string UniqueNameID => "PottedOrangePetals";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("PottedOrangePetals").AssignMaterialsByNames();
        public override bool IsIndisposable => true;

        public override List<ItemGroup.ItemSet> Sets => new()
        {
            new ItemGroup.ItemSet
            {
                Items = new List<Item>
                {
                    GDOReferences.Water,
                    GDOReferences.Pot,
                },
                Min = 2,
                Max = 2,
                IsMandatory = true
            },
            new ItemGroup.ItemSet
            {
                Items = new List<Item>
                {
                    GDOReferences.OrangePetals
                },
                Min = 1,
                Max = 1
            }
        };

        public override List<Item.ItemProcess> Processes => new()
        {
            new Item.ItemProcess
            {
                Process = GDOReferences.Cook,
                Duration = 1,
                Result = GDOReferences.CookedOrangePetals
            }
        };

        public override void OnRegister(ItemGroup gameDataObject)
        {
            base.OnRegister(gameDataObject);

            if (gameDataObject.Prefab.TryGetComponent(out ItemGroupView itemGroupView))
            {
                itemGroupView.ComponentGroups = new List<ItemGroupView.ComponentGroup>();
                itemGroupView.ComponentGroups.Add(new ItemGroupView.ComponentGroup
                {
                    Item = GDOReferences.OrangePetals,
                    GameObject = gameDataObject.Prefab.GetChild("PottedOrangePetals")
                });

                List<ItemGroupView.ColourBlindLabel> ComponentLabels = new List<ItemGroupView.ColourBlindLabel>
                {
                    new ItemGroupView.ColourBlindLabel
                    {
                        Item = GDOReferences.OrangePetals,
                        Text = "O"
                    },
                };

                FieldInfo _ComponentLabels = ReflectionUtils.GetField<ItemGroupView>("ComponentLabels");
                _ComponentLabels.SetValue(itemGroupView, ComponentLabels);
            }
        }
    }
}