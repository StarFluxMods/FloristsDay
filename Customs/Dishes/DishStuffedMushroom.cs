using System.Collections.Generic;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using ParentsEvent.Utilities;
using UnityEngine;

namespace ParentsEvent.Customs.Dishes
{
    public class DishStuffedMushroom : CustomDish
    {
        public override string UniqueNameID => "DishStuffedMushroom";
        public override UnlockGroup UnlockGroup => UnlockGroup.Dish;
        public override CardType CardType => CardType.Default;
        public override DishCustomerChange CustomerMultiplier => DishCustomerChange.SmallDecrease;
        public override DishType Type => DishType.Starter;
        public override int Difficulty => 1;

        public override List<string> StartingNameSet => new()
        {
            "Fun-Guy Feast",
            "Spore the Merrier",
            "Shroom for One More",
            "Myceli-Yum",
            "You Shroom, You Lose",
        };

        public override HashSet<Item> MinimumIngredients => new()
        {
            GDOReferences.Mushroom,
            GDOReferences.Cheese
        };

        public override HashSet<Process> RequiredProcesses => new HashSet<Process>
        {
            GDOReferences.Chop,
        };

        public override List<Unlock> HardcodedRequirements => new List<Unlock>
        {
            GDOReferences.DishFloristsFlowers
        };

        public override GameObject IconPrefab => Mod.Bundle.LoadAsset<GameObject>("StuffedMushroomIcon").AssignMaterialsByNames();

        public override List<Dish.MenuItem> ResultingMenuItems => new()
        {
            new Dish.MenuItem
            {
                Item = GDOReferences.StuffedMushroom,
                Phase = MenuPhase.Starter,
                Weight = 1,
                DynamicMenuType = DynamicMenuType.Static,
                DynamicMenuIngredient = null
            }
        };

        public override bool IsAvailableAsLobbyOption => Mod.ENABLE_ADDITIONAL_LOBBY_DISHES;
        public override List<(Locale, UnlockInfo)> InfoList => CenteralLang.Unlocks.DishStuffedMushroom;
        public override Dictionary<Locale, string> Recipe => CenteralLang.Recipes.DishStuffedMushroom;
    }
}