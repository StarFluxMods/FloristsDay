using System.Collections.Generic;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using ParentsEvent.Utilities;
using UnityEngine;

namespace ParentsEvent.Customs.Dishes
{
    public class DishWrappedGift : CustomDish
    {
        public override string UniqueNameID => "DishWrappedGift";
        public override UnlockGroup UnlockGroup => UnlockGroup.Dish;
        public override CardType CardType => CardType.Default;
        public override DishCustomerChange CustomerMultiplier => DishCustomerChange.SmallDecrease;
        public override DishType Type => DishType.Dessert;
        public override int Difficulty => 1;

        public override List<string> StartingNameSet => new()
        {
            "Wrap Battle",
            "Tied Up With String",
            "Surprise Inside!",
            "Bow Appétit",
            "Gifted & Delicious",
        };

        public override HashSet<Process> RequiredProcesses => new HashSet<Process>
        {
            GDOReferences.Knead,
        };
        
        public override List<Unlock> HardcodedBlockers => new List<Unlock>
        {
            GDOReferences.AllYouCanEat
        };

        public override List<Unlock> HardcodedRequirements => new List<Unlock>
        {
            GDOReferences.CardChildren
        };

        public override GameObject IconPrefab => Mod.Bundle.LoadAsset<GameObject>("WrappedGiftIcon").AssignMaterialsByNames();

        public override List<Dish.MenuItem> ResultingMenuItems => new()
        {
            new Dish.MenuItem
            {
                Item = GDOReferences.WrappedRock,
                Phase = MenuPhase.Dessert,
                Weight = 1,
                DynamicMenuType = DynamicMenuType.Static,
                DynamicMenuIngredient = null
            },
            new Dish.MenuItem
            {
                Item = GDOReferences.WrappedFramedPhoto,
                Phase = MenuPhase.Dessert,
                Weight = 1,
                DynamicMenuType = DynamicMenuType.Static,
                DynamicMenuIngredient = null
            },
            new Dish.MenuItem
            {
                Item = GDOReferences.WrappedToyTruck,
                Phase = MenuPhase.Dessert,
                Weight = 1,
                DynamicMenuType = DynamicMenuType.Static,
                DynamicMenuIngredient = null
            }
        };

        public override bool IsAvailableAsLobbyOption => Mod.ENABLE_ADDITIONAL_LOBBY_DISHES;
        public override List<(Locale, UnlockInfo)> InfoList => CenteralLang.Unlocks.DishWrappedGift;
        public override Dictionary<Locale, string> Recipe => CenteralLang.Recipes.DishWrappedGift;
    }
}