using System.Collections.Generic;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using ParentsEvent.Utilities;
using UnityEngine;

namespace ParentsEvent.Customs.Dishes
{
    public class DishBangersAndMashGravy : CustomDish
    {
        public override string UniqueNameID => "DishBangersAndMashGravy";
        public override UnlockGroup UnlockGroup => UnlockGroup.Dish;
        public override CardType CardType => CardType.Default;
        public override Unlock.RewardLevel ExpReward => Unlock.RewardLevel.Medium;
        public override DishCustomerChange CustomerMultiplier => DishCustomerChange.SmallDecrease;
        public override DishType Type => DishType.Extra;
        public override int Difficulty => 1;

        public override List<string> StartingNameSet => new()
        {
            "Gravy Train",
            "Catch My Drip",
            "Just Gravy Baby",
            "Stock and Awe",
            "So Saucy",
        };

        public override HashSet<Item> MinimumIngredients => new()
        {
            GDOReferences.Pot,
            GDOReferences.Onion,
            GDOReferences.Water,
            GDOReferences.TurkeyBones,
        };

        public override HashSet<Process> RequiredProcesses => new HashSet<Process>
        {
            GDOReferences.Cook
        };

        public override List<Dish> AlsoAddRecipes => new List<Dish>
        {
            GDOReferences.DishTurkeyGravy
        };

        public override List<Unlock> HardcodedRequirements => new List<Unlock>
        {
            GDOReferences.DishBangersAndMash
        };

        public override GameObject IconPrefab => Mod.Bundle.LoadAsset<GameObject>("BangersAndMashGravyIcon").AssignMaterialsByNames();
        
        public override HashSet<Dish.IngredientUnlock> IngredientsUnlocks => new HashSet<Dish.IngredientUnlock>
        {
            new Dish.IngredientUnlock
            {
                MenuItem = GDOReferences.PlatedSausage,
                Ingredient = GDOReferences.TurkeyGravy
            }
        };

        public override bool IsAvailableAsLobbyOption => Mod.ENABLE_ADDITIONAL_LOBBY_DISHES;
        public override List<(Locale, UnlockInfo)> InfoList => CenteralLang.Unlocks.DishBangersAndMashGravy;
        public override Dictionary<Locale, string> Recipe => CenteralLang.Recipes.DishBangersAndMashGravy;
    }
}