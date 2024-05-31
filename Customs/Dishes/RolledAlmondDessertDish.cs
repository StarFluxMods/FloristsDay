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
    public class RolledAlmondDessertDish : CustomDish
    {
        public override string UniqueNameID => "RolledAlmondDessertDish";
        public override DishType Type => DishType.Dessert;
        public override List<Dish.MenuItem> ResultingMenuItems => new List<Dish.MenuItem>
        {
            new Dish.MenuItem
            {
                Item = (Item)GDOUtils.GetCustomGameDataObject<RolledAlmondDessert>().GameDataObject,
                Phase = MenuPhase.Dessert,
                Weight = 1,
                DynamicMenuType = DynamicMenuType.Static
            }
        };

        public override HashSet<Item> MinimumIngredients => new HashSet<Item>
        {
            (Item)GDOUtils.GetExistingGDO(ItemReferences.NutsIngredient),
            (Item)GDOUtils.GetExistingGDO(ItemReferences.Sugar),
        };

        public override HashSet<Process> RequiredProcesses => new HashSet<Process>
        {
            (Process)GDOUtils.GetExistingGDO(ProcessReferences.Chop),
            (Process)GDOUtils.GetExistingGDO(ProcessReferences.Cook),
            (Process)GDOUtils.GetExistingGDO(ProcessReferences.Knead),
        };

        public override bool RequiredNoDishItem => true;

        public override List<Unlock> HardcodedRequirements => new List<Unlock>
        {
            (Dish)GDOUtils.GetCustomGameDataObject<FlowersDish>().GameDataObject
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