using System.Collections.Generic;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using ParentsEvent.Utilities;
using UnityEngine;

namespace ParentsEvent.Customs.Dishes
{
    public class DishBangersAndMashPeas : CustomDish
    {
        public override string UniqueNameID => "DishBangersAndMashPeas";
        public override UnlockGroup UnlockGroup => UnlockGroup.Dish;
        public override CardType CardType => CardType.Default;
        public override Unlock.RewardLevel ExpReward => Unlock.RewardLevel.Medium;
        public override DishCustomerChange CustomerMultiplier => DishCustomerChange.SmallDecrease;
        public override DishType Type => DishType.Extra;
        public override int Difficulty => 1;

        public override List<string> StartingNameSet => new()
        {
            "Easy Peasy",
            "Peas and Thank You",
            "Peas of Mind",
            "The Missing Peas",
            "Peas the Day",
        };

        public override HashSet<Item> MinimumIngredients => new()
        {
            GDOReferences.Pot,
            GDOReferences.RawPeas,
            GDOReferences.Water
        };

        public override HashSet<Process> RequiredProcesses => new HashSet<Process>
        {
            GDOReferences.Cook
        };

        public override List<Unlock> HardcodedRequirements => new List<Unlock>
        {
            GDOReferences.DishBangersAndMash
        };

        public override GameObject IconPrefab => Mod.Bundle.LoadAsset<GameObject>("BangersAndMashPeasIcon").AssignMaterialsByNames();
        
        public override HashSet<Dish.IngredientUnlock> IngredientsUnlocks => new HashSet<Dish.IngredientUnlock>
        {
            new Dish.IngredientUnlock
            {
                MenuItem = GDOReferences.PlatedSausage,
                Ingredient = GDOReferences.CookedPeas
            }
        };

        public override bool IsAvailableAsLobbyOption => Mod.ENABLE_ADDITIONAL_LOBBY_DISHES;
        public override List<(Locale, UnlockInfo)> InfoList => CenteralLang.Unlocks.DishBangersAndMashPeas;
        public override Dictionary<Locale, string> Recipe => CenteralLang.Recipes.DishBangersAndMashPeas;
    }
}