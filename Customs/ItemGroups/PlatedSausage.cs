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
    public class PlatedSausage : CustomItemGroup
    {
        public override string UniqueNameID => "PlatedSausage";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("PlatedSausage").AssignMaterialsByNames();
        public override Item DirtiesTo => GDOReferences.PlateDirty;
        public override Item DisposesTo => GDOReferences.Plate;
        public override ItemValue ItemValue => ItemValue.MediumLarge;
        public override bool CanContainSide => true;

        public override List<ItemGroup.ItemSet> Sets => new()
        {
            new ItemGroup.ItemSet
            {
                Items = new List<Item>
                {
                    GDOReferences.Plate,
                },
                Min = 1,
                Max = 1,
                IsMandatory = true
            },
            new ItemGroup.ItemSet
            {
                Items = new List<Item>
                {
                    GDOReferences.CookedSausage,
                    GDOReferences.BoiledPotatoServing,
                },
                Min = 2,
                Max = 2,
            },
            new ItemGroup.ItemSet
            {
                Items = new List<Item>
                {
                    GDOReferences.CookedPeas,
                },
                Min = 1,
                Max = 1,
                RequiresUnlock = true
            },
            new ItemGroup.ItemSet
            {
                Items = new List<Item>
                {
                    GDOReferences.TurkeyGravy,
                },
                Min = 1,
                Max = 1,
                RequiresUnlock = true
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
                        Item = GDOReferences.CookedSausage,
                        Objects = new List<GameObject>
                        {
                            gameDataObject.Prefab.GetChild("PlatedSausage/SausageBody.002"),
                            gameDataObject.Prefab.GetChild("PlatedSausage/SausageGrillMarks.001"),
                        },
                        DrawAll = true
                    },
                    new ItemGroupView.ComponentGroup
                    {
                        Item = GDOReferences.CookedPeas,
                        Objects = new List<GameObject>
                        {
                            gameDataObject.Prefab.GetChild("PlatedSausage/PeasBroth.001"),
                            gameDataObject.Prefab.GetChild("PlatedSausage/Peas.008"),
                        },
                        DrawAll = true
                    },
                    new ItemGroupView.ComponentGroup
                    {
                        Item = GDOReferences.TurkeyGravy,
                        GameObject = gameDataObject.Prefab.GetChild("PlatedSausage/Gravy")
                    },
                    new ItemGroupView.ComponentGroup
                    {
                        Item = GDOReferences.BoiledPotatoServing,
                        GameObject = gameDataObject.Prefab.GetChild("PlatedSausage/Mash")
                    }
                };

                List<ItemGroupView.ColourBlindLabel> ComponentLabels = new List<ItemGroupView.ColourBlindLabel>
                {
                    new ItemGroupView.ColourBlindLabel
                    {
                        Item = GDOReferences.CookedPeas,
                        Text = "P"
                    },
                    new ItemGroupView.ColourBlindLabel
                    {
                        Item = GDOReferences.TurkeyGravy,
                        Text = "G"
                    }
                };

                FieldInfo _ComponentLabels = ReflectionUtils.GetField<ItemGroupView>("ComponentLabels");
                _ComponentLabels.SetValue(itemGroupView, ComponentLabels);
            }
        }
    }
}