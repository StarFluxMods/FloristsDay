using System.Collections.Generic;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using ParentsEvent.Utilities;
using UnityEngine;

namespace ParentsEvent.Customs.Dishes
{
    public class DishChocolateBark : CustomDish
    {
        public override string UniqueNameID => "DishChocolateBark";
        public override UnlockGroup UnlockGroup => UnlockGroup.Dish;
        public override CardType CardType => CardType.Default;
        public override Unlock.RewardLevel ExpReward => Unlock.RewardLevel.Medium;
        public override DishCustomerChange CustomerMultiplier => DishCustomerChange.SmallDecrease;
        public override DishType Type => DishType.Dessert;
        public override int Difficulty => 2;

        public override List<string> StartingNameSet => new()
        {
            "Choc Full of Bark",
            "Bark Side of the Spoon",
            "Cocoa-Motion",
            "The Great Choco-Barkery",
            "Rough Around the Edges",
        };

        public override HashSet<Item> MinimumIngredients => new()
        {
            GDOReferences.Chocolate,
            GDOReferences.NutsIngredient,
            GDOReferences.CookieTray,
        };

        public override HashSet<Process> RequiredProcesses => new HashSet<Process>
        {
            GDOReferences.Cook,
            GDOReferences.Chop,
            GDOReferences.SteepTea,
        };

        public override List<Unlock> HardcodedRequirements => new List<Unlock>
        {
            GDOReferences.DishFloristsFlowers
        };

        public override GameObject IconPrefab => Mod.Bundle.LoadAsset<GameObject>("ChocolateBarkIcon").AssignMaterialsByNames();

        public override List<Dish.MenuItem> ResultingMenuItems => new()
        {
            new Dish.MenuItem
            {
                Item = GDOReferences.ChocolateBarkPortion,
                Phase = MenuPhase.Dessert,
                Weight = 1,
                DynamicMenuType = DynamicMenuType.Static,
                DynamicMenuIngredient = null
            }
        };

        public override bool IsAvailableAsLobbyOption => Mod.ENABLE_ADDITIONAL_LOBBY_DISHES;
        public override List<(Locale, UnlockInfo)> InfoList => CenteralLang.Unlocks.DishChocolateBark;
        public override Dictionary<Locale, string> Recipe => CenteralLang.Recipes.DishChocolateBark;
    }
}