using System.Collections.Generic;
using System.Reflection;
using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using ParentsEvent.Components;
using ParentsEvent.Utilities;
using UnityEngine;

namespace ParentsEvent.Customs.ItemGroups
{
    public class FloristsVase : CustomItemGroup
    {
        public override string UniqueNameID => "FloristsVase";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("FloristsVase").AssignMaterialsByNames();
        public override Item DisposesTo => GDOReferences.Vase;
        public override Item DirtiesTo => GDOReferences.Vase;
        public override ItemValue ItemValue => ItemValue.Medium;

        public override List<IItemProperty> Properties => new List<IItemProperty>
        {
            new CPortionableVase()
        };

        public override List<ItemGroup.ItemSet> Sets => new List<ItemGroup.ItemSet>
        {
            new ItemGroup.ItemSet
            {
                Items = new List<Item>
                {
                    GDOReferences.Vase
                },
                Min = 1,
                Max = 1,
                IsMandatory = true
            },
            new ItemGroup.ItemSet
            {
                Items = new List<Item>
                {
                    GDOReferences.BlueFlower,
                    GDOReferences.BlueFlower,
                    GDOReferences.BlueFlower,
                    GDOReferences.OrangeFlower,
                    GDOReferences.OrangeFlower,
                    GDOReferences.OrangeFlower,
                    GDOReferences.PinkFlower,
                    GDOReferences.PinkFlower,
                    GDOReferences.PinkFlower,
                },
                Min = 2,
                Max = 3
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
                    Item = GDOReferences.BlueFlower,
                    Objects = new List<GameObject>
                    {
                        gameDataObject.Prefab.GetChild("BlueFlower (1)"),
                        gameDataObject.Prefab.GetChild("BlueFlower"),
                        gameDataObject.Prefab.GetChild("BlueFlower (2)"),
                    }
                });

                itemGroupView.ComponentGroups.Add(new ItemGroupView.ComponentGroup
                {
                    Item = GDOReferences.OrangeFlower,
                    Objects = new List<GameObject>
                    {
                        gameDataObject.Prefab.GetChild("OrangeFlower (1)"),
                        gameDataObject.Prefab.GetChild("OrangeFlower"),
                        gameDataObject.Prefab.GetChild("OrangeFlower (2)"),
                    }
                });

                itemGroupView.ComponentGroups.Add(new ItemGroupView.ComponentGroup
                {
                    Item = GDOReferences.PinkFlower,
                    Objects = new List<GameObject>
                    {
                        gameDataObject.Prefab.GetChild("PinkFlower (1)"),
                        gameDataObject.Prefab.GetChild("PinkFlower"),
                        gameDataObject.Prefab.GetChild("PinkFlower (2)"),
                    }
                });

                List<ItemGroupView.ColourBlindLabel> ComponentLabels = new List<ItemGroupView.ColourBlindLabel>
                {
                    new ItemGroupView.ColourBlindLabel
                    {
                        Item = GDOReferences.BlueFlower,
                        Text = "B"
                    },
                    new ItemGroupView.ColourBlindLabel
                    {
                        Item = GDOReferences.OrangeFlower,
                        Text = "O"
                    },
                    new ItemGroupView.ColourBlindLabel
                    {
                        Item = GDOReferences.PinkFlower,
                        Text = "P"
                    }
                };

                FieldInfo _ComponentLabels = ReflectionUtils.GetField<ItemGroupView>("ComponentLabels");
                _ComponentLabels.SetValue(itemGroupView, ComponentLabels);
            }

            Transform t = gameDataObject.Prefab.transform.Find("Colour Blind").transform;
            t.position = new Vector3(t.position.x, t.position.y + 0.5f, t.position.z - 0.5f);
        }
    }
}