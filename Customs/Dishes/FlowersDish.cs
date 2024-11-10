using System.Collections.Generic;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.References;
using KitchenLib.Utils;
using ParentsEvent.Customs.ItemGroups;
using ParentsEvent.Customs.Items;
using UnityEngine;

namespace ParentsEvent.Customs.Dishes
{
    public class FlowersDish : CustomDish
    {
        public override string UniqueNameID => "FlowersDish";
        public override DishType Type => DishType.Main;

        public override List<Dish.MenuItem> ResultingMenuItems => new List<Dish.MenuItem>
        {
            new Dish.MenuItem
            {
                Item = (Item)GDOUtils.GetCustomGameDataObject<FlowerVase>().GameDataObject,
                Phase = MenuPhase.Main,
                Weight = 1,
                DynamicMenuType = DynamicMenuType.Static
            }
        };

        public override HashSet<Item> MinimumIngredients => new HashSet<Item>
        {
            (Item)GDOUtils.GetCustomGameDataObject<EmptyVase>().GameDataObject,
            (Item)GDOUtils.GetCustomGameDataObject<EmptyWateringCan>().GameDataObject,
            (Item)GDOUtils.GetExistingGDO(ItemReferences.Water)
        };

        public override GameObject IconPrefab => Mod.Bundle.LoadAsset<GameObject>("Flowers Icon").AssignMaterialsByNames();

        public override bool RequiredNoDishItem => true;
        public override int Difficulty => 3;

        public override UnlockGroup UnlockGroup => UnlockGroup.Dish;

        public override Dictionary<Locale, string> Recipe => new Dictionary<Locale, string>
        {
            {
                Locale.English,
                "Add water to a Watering Can, water patches of dirt to grow flowers, then place them in a vase."
            }
        };

        public override List<string> StartingNameSet => new List<string>
        {
            "Petal Pushers",
            "Daisy Chain Delight",
            "Thistle Be Fun",
            "Blooming Marvelous",
            "Flora and Feast",
            "Petal to the Metal",
            "Buttercup Bites",
            "Garden of Eatin'",
            "Sunflower Snacks",
            "Dandelion Dine",
            "Rosy Outlook",
        };

        public override List<(Locale, UnlockInfo)> InfoList => new List<(Locale, UnlockInfo)>
        {
            (
                Locale.English,
                new UnlockInfo
                {
                    Name = "Flowers",
                    Description = "Adds Flowers as a Main"
                }
            )
        };
    }
}