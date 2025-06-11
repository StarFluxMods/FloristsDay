using System.Collections.Generic;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using ParentsEvent.Utilities;
using UnityEngine;

namespace ParentsEvent.Customs.Dishes
{
    public class DishFloristsFlowers : CustomDish
    {
        public override string UniqueNameID => "DishFloristsFlowers";
        public override UnlockGroup UnlockGroup => UnlockGroup.Dish;
        public override CardType CardType => CardType.Default;
        public override DishCustomerChange CustomerMultiplier => DishCustomerChange.None;
        public override DishType Type => DishType.Main;
        public override int Difficulty => 3;

        public override List<string> StartingNameSet => new()
        {
            "Petal to the Metal",
            "Bloom Service",
            "A Vase of Taste",
            "The Bloom Room",
            "Leaf It to Us",
        };

        public override HashSet<Item> MinimumIngredients => new()
        {
            GDOReferences.Water,
            GDOReferences.WateringCan,
            GDOReferences.Vase,
        };

        public override GameObject IconPrefab => Mod.Bundle.LoadAsset<GameObject>("FloristsFlowersIcon").AssignMaterialsByNames();

        public override bool IsMainThatDoesNotNeedPlates => true;

        public override List<Dish.MenuItem> ResultingMenuItems => new()
        {
            new Dish.MenuItem
            {
                Item = GDOReferences.FloristsVase,
                Phase = MenuPhase.Main,
                Weight = 1,
                DynamicMenuType = DynamicMenuType.Static,
                DynamicMenuIngredient = null
            }
        };

        public override bool IsAvailableAsLobbyOption => Mod.ENABLE_ADDITIONAL_LOBBY_DISHES;
        public override List<(Locale, UnlockInfo)> InfoList => CenteralLang.Unlocks.DishFloristsFlowers;
        public override Dictionary<Locale, string> Recipe => CenteralLang.Recipes.DishFloristsFlowers;
    }
}