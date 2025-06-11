using System.Collections.Generic;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using ParentsEvent.Utilities;
using UnityEngine;

namespace ParentsEvent.Customs.Dishes
{
    public class DishPetalSoup : CustomDish
    {
        public override string UniqueNameID => "DishPetalSoup";
        public override UnlockGroup UnlockGroup => UnlockGroup.Dish;
        public override CardType CardType => CardType.Default;
        public override DishCustomerChange CustomerMultiplier => DishCustomerChange.SmallDecrease;
        public override DishType Type => DishType.Starter;
        public override int Difficulty => 2;

        public override List<string> StartingNameSet => new()
        {
            "Stop and Smell the Broth",
            "Stew-pendous Blooms",
            "Leaf It to Stew",
            "Stock Full of Flowers",
            "The Stew That Grew",
        };

        public override HashSet<Item> MinimumIngredients => new()
        {
            GDOReferences.Water,
            GDOReferences.WateringCan,
            GDOReferences.Pot,
        };

        public override HashSet<Process> RequiredProcesses => new HashSet<Process>
        {
            GDOReferences.Cook,
            GDOReferences.Chop,
        };

        public override List<Unlock> HardcodedRequirements => new List<Unlock>
        {
            GDOReferences.DishFloristsFlowers
        };

        public override GameObject IconPrefab => Mod.Bundle.LoadAsset<GameObject>("PetalSoupIcon").AssignMaterialsByNames();

        public override List<Dish.MenuItem> ResultingMenuItems => new()
        {
            new Dish.MenuItem
            {
                Item = GDOReferences.PinkPetalSoup,
                Phase = MenuPhase.Starter,
                Weight = 1,
                DynamicMenuType = DynamicMenuType.Static,
                DynamicMenuIngredient = null
            },
            new Dish.MenuItem
            {
                Item = GDOReferences.BluePetalSoup,
                Phase = MenuPhase.Starter,
                Weight = 1,
                DynamicMenuType = DynamicMenuType.Static,
                DynamicMenuIngredient = null
            },
            new Dish.MenuItem
            {
                Item = GDOReferences.OrangePetalSoup,
                Phase = MenuPhase.Starter,
                Weight = 1,
                DynamicMenuType = DynamicMenuType.Static,
                DynamicMenuIngredient = null
            }
        };

        public override bool IsAvailableAsLobbyOption => Mod.ENABLE_ADDITIONAL_LOBBY_DISHES;
        public override List<(Locale, UnlockInfo)> InfoList => CenteralLang.Unlocks.DishPetalSoup;
        public override Dictionary<Locale, string> Recipe => CenteralLang.Recipes.DishPetalSoup;
    }
}