using System.Collections.Generic;
using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using ParentsEvent.Customs.Items;
using UnityEngine;

namespace ParentsEvent.Customs.ItemGroups
{
    public class FlowerVase : CustomItemGroup<ItemGroupView>
    {
        public override string UniqueNameID => "FlowerVase";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("Vase Flowers").AssignMaterialsByNames();

        public override List<ItemGroup.ItemSet> Sets => new List<ItemGroup.ItemSet>
        {
            new ItemGroup.ItemSet
            {
                Items = new List<Item>
                {
                    (Item)GDOUtils.GetCustomGameDataObject<EmptyVase>().GameDataObject
                },
                Min = 1,
                Max = 1,
                IsMandatory = true
            },
            new ItemGroup.ItemSet
            {
                Items = new List<Item>
                {
                    (Item)GDOUtils.GetCustomGameDataObject<FlowerRed>().GameDataObject,
                    (Item)GDOUtils.GetCustomGameDataObject<FlowerRed>().GameDataObject,
                    (Item)GDOUtils.GetCustomGameDataObject<FlowerRed>().GameDataObject,
                    (Item)GDOUtils.GetCustomGameDataObject<FlowerGreen>().GameDataObject,
                    (Item)GDOUtils.GetCustomGameDataObject<FlowerGreen>().GameDataObject,
                    (Item)GDOUtils.GetCustomGameDataObject<FlowerGreen>().GameDataObject,
                    (Item)GDOUtils.GetCustomGameDataObject<FlowerBlue>().GameDataObject,
                    (Item)GDOUtils.GetCustomGameDataObject<FlowerBlue>().GameDataObject,
                    (Item)GDOUtils.GetCustomGameDataObject<FlowerBlue>().GameDataObject,
                },
                Min = 2,
                Max = 3,
            }
        };

        public override List<ItemGroupView.ColourBlindLabel> Labels => new List<ItemGroupView.ColourBlindLabel>
        {
            new ItemGroupView.ColourBlindLabel
            {
                Item = (Item)GDOUtils.GetCustomGameDataObject<FlowerBlue>().GameDataObject,
                Text = "B"
            },
            new ItemGroupView.ColourBlindLabel
            {
                Item = (Item)GDOUtils.GetCustomGameDataObject<FlowerGreen>().GameDataObject,
                Text = "O"
            },
            new ItemGroupView.ColourBlindLabel
            {
                Item = (Item)GDOUtils.GetCustomGameDataObject<FlowerRed>().GameDataObject,
                Text = "R"
            }
        };

        public override Item DirtiesTo => (Item)GDOUtils.GetCustomGameDataObject<EmptyVase>().GameDataObject;

        public override void OnRegister(ItemGroup gameDataObject)
        {
            base.OnRegister(gameDataObject);

            ItemGroupView view = gameDataObject.Prefab.GetComponent<ItemGroupView>();

            view.ComponentGroups = new List<ItemGroupView.ComponentGroup>();

            view.ComponentGroups.Add(new ItemGroupView.ComponentGroup
            {
                Item = (Item)GDOUtils.GetCustomGameDataObject<FlowerRed>().GameDataObject,
                Objects = new List<GameObject>
                {
                    gameDataObject.Prefab.GetChild("Group 1/Point3/"),
                    gameDataObject.Prefab.GetChild("Group 2/Point1/"),
                    gameDataObject.Prefab.GetChild("Group 3/Point3/"),
                }
            });

            view.ComponentGroups.Add(new ItemGroupView.ComponentGroup
            {
                Item = (Item)GDOUtils.GetCustomGameDataObject<FlowerBlue>().GameDataObject,
                Objects = new List<GameObject>
                {
                    gameDataObject.Prefab.GetChild("Group 1/Point1/"),
                    gameDataObject.Prefab.GetChild("Group 2/Point2/"),
                    gameDataObject.Prefab.GetChild("Group 3/Point1/"),
                }
            });

            view.ComponentGroups.Add(new ItemGroupView.ComponentGroup
            {
                Item = (Item)GDOUtils.GetCustomGameDataObject<FlowerGreen>().GameDataObject,
                Objects = new List<GameObject>
                {
                    gameDataObject.Prefab.GetChild("Group 1/Point2/"),
                    gameDataObject.Prefab.GetChild("Group 2/Point3/"),
                    gameDataObject.Prefab.GetChild("Group 3/Point2/"),
                }
            });

            view.ComponentGroups.Add(new ItemGroupView.ComponentGroup
            {
                Item = (Item)GDOUtils.GetCustomGameDataObject<EmptyVase>().GameDataObject,
                GameObject = gameDataObject.Prefab.GetChild("Empty Vase")
            });

            Transform t = gameDataObject.Prefab.transform.Find("Colour Blind").transform;
            t.position = new Vector3(t.position.x, t.position.y + 0.5f, t.position.z);
        }
    }
}