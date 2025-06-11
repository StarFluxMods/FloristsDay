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
    public class PottedBluePetals : CustomItemGroup
    {
        public override string UniqueNameID => "PottedBluePetals";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("PottedBluePetals").AssignMaterialsByNames();
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
                    GDOReferences.BluePetals
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
                Result = GDOReferences.CookedBluePetals
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
                    Item = GDOReferences.BluePetals,
                    GameObject = gameDataObject.Prefab.GetChild("PottedBluePetals")
                });

                List<ItemGroupView.ColourBlindLabel> ComponentLabels = new List<ItemGroupView.ColourBlindLabel>
                {
                    new ItemGroupView.ColourBlindLabel
                    {
                        Item = GDOReferences.BluePetals,
                        Text = "B"
                    },
                };

                FieldInfo _ComponentLabels = ReflectionUtils.GetField<ItemGroupView>("ComponentLabels");
                _ComponentLabels.SetValue(itemGroupView, ComponentLabels);
            }
        }
    }
}