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
    public class PottedPinkPetals : CustomItemGroup
    {
        public override string UniqueNameID => "PottedPinkPetals";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("PottedPinkPetals").AssignMaterialsByNames();
        public override Item DisposesTo => GDOReferences.Pot;

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
                    GDOReferences.PinkPetals
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
                Result = GDOReferences.CookedPinkPetals
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
                    Item = GDOReferences.PinkPetals,
                    GameObject = gameDataObject.Prefab.GetChild("PottedPinkPetals")
                });

                List<ItemGroupView.ColourBlindLabel> ComponentLabels = new List<ItemGroupView.ColourBlindLabel>
                {
                    new ItemGroupView.ColourBlindLabel
                    {
                        Item = GDOReferences.PinkPetals,
                        Text = "P"
                    },
                };

                FieldInfo _ComponentLabels = ReflectionUtils.GetField<ItemGroupView>("ComponentLabels");
                _ComponentLabels.SetValue(itemGroupView, ComponentLabels);
            }
        }
    }
}