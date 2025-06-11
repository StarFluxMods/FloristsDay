using System.Collections.Generic;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using ParentsEvent.Utilities;
using UnityEngine;

namespace ParentsEvent.Customs.Dishes
{
    public class DishBangersAndMash : CustomDish
    {
        public override string UniqueNameID => "DishBangersAndMash";
        public override UnlockGroup UnlockGroup => UnlockGroup.Dish;
        public override CardType CardType => CardType.Default;
        public override Unlock.RewardLevel ExpReward => Unlock.RewardLevel.Medium;
        public override DishCustomerChange CustomerMultiplier => DishCustomerChange.SmallDecrease;
        public override DishType Type => DishType.Main;
        public override int Difficulty => 2;

        public override List<string> StartingNameSet => new()
        {
            "Bang Up Job",
            "Mash Made in Heaven",
            "Full of Bangers",
            "Absolutely Mash-nificent",
            "Mashive Portions",
        };

        public override HashSet<Item> MinimumIngredients => new()
        {
            GDOReferences.RawSausage,
            GDOReferences.Pot,
            GDOReferences.Potato,
            GDOReferences.Water,
        };

        public override HashSet<Process> RequiredProcesses => new HashSet<Process>
        {
            GDOReferences.Cook,
            GDOReferences.Chop,
        };

        public override List<Dish> AlsoAddRecipes => new List<Dish>
        {
            GDOReferences.MashedPotato
        };

        public override List<Unlock> HardcodedRequirements => new List<Unlock>
        {
            GDOReferences.DishFloristsFlowers
        };

        public override GameObject IconPrefab => Mod.Bundle.LoadAsset<GameObject>("BangersAndMashIcon").AssignMaterialsByNames();

        public override List<Dish.MenuItem> ResultingMenuItems => new()
        {
            new Dish.MenuItem
            {
                Item = GDOReferences.PlatedSausage,
                Phase = MenuPhase.Main,
                Weight = 1,
                DynamicMenuType = DynamicMenuType.Static,
                DynamicMenuIngredient = null
            }
        };

        public override bool IsAvailableAsLobbyOption => Mod.ENABLE_ADDITIONAL_LOBBY_DISHES;
        public override List<(Locale, UnlockInfo)> InfoList => CenteralLang.Unlocks.DishBangersAndMash;
        public override Dictionary<Locale, string> Recipe => CenteralLang.Recipes.DishBangersAndMash;
    }
}