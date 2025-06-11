using System.Collections.Generic;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.References;
using KitchenLib.Utils;
using ParentsEvent.Customs.ItemGroups;
using ParentsEvent.Customs.Items;
using ParentsEvent.Utilities;
using UnityEngine;

namespace ParentsEvent.Customs.Dishes
{
    public class RolledAlmondDessertDish : CustomDish
    {
        public override string UniqueNameID => "RolledAlmondDessertDish";
        public override DishType Type => DishType.Dessert;
        public override DishCustomerChange CustomerMultiplier => DishCustomerChange.SmallDecrease;

        public override List<Dish.MenuItem> ResultingMenuItems => new List<Dish.MenuItem>
        {
            new Dish.MenuItem
            {
                Item = GDOReferences.RolledAlmondDessert,
                Phase = MenuPhase.Dessert,
                Weight = 1,
                DynamicMenuType = DynamicMenuType.Static
            }
        };

        public override HashSet<Item> MinimumIngredients => new HashSet<Item>
        {
            GDOReferences.Sugar,
            GDOReferences.NutsIngredient,
        };

        public override HashSet<Process> RequiredProcesses => new HashSet<Process>
        {
            GDOReferences.Chop,
            GDOReferences.Cook,
            GDOReferences.Knead,
        };

        public override bool RequiredNoDishItem => true;

        public override List<Unlock> HardcodedRequirements => new List<Unlock>
        {
            GDOReferences.FlowersDish
        };

        public override Dictionary<Locale, string> Recipe => new Dictionary<Locale, string>
        {
            {
                Locale.English,
                "Chop and cook nuts, then knead them with sugar to make a dessert."
            }
        };

        public override UnlockGroup UnlockGroup => UnlockGroup.Dish;

        public override List<(Locale, UnlockInfo)> InfoList => new List<(Locale, UnlockInfo)>
        {
            (
                Locale.English,
                new UnlockInfo
                {
                    Name = "Gourmet Nuts",
                    Description = "Adds Gourmet Nuts as a Dessert"
                }
            )
        };
    }
}