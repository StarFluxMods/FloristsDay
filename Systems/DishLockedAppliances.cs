using System.Collections.Generic;
using System.Linq;
using Kitchen;
using Kitchen.ShopBuilder;
using KitchenData;
using KitchenMods;
using ParentsEvent.Utilities;
using Unity.Collections;
using Unity.Entities;
 
namespace ParentsEvent.Systems
{
    public class DishLockedAppliances : StartOfDaySystem, IModSystem
    {
        private EntityQuery _CurrentMenuItems;
        private EntityQuery _ShopBuilderOptions;

        protected override void Initialise()
        {
            base.Initialise();
            _CurrentMenuItems = base.GetEntityQuery(typeof(CMenuItem), typeof(CAvailableIngredient));
            _ShopBuilderOptions = base.GetEntityQuery(typeof(CShopBuilderOption));
        }

        private static Dictionary<int, List<Appliance>> Appliances = new Dictionary<int, List<Appliance>>
        {
            {
                GDOReferences.DishFloristsFlowers.ID, new List<Appliance>
                {
                    GDOReferences.SmallSprinklerProvider,
                    GDOReferences.FlowerRug,
                    GDOReferences.FlowerGrowthChart,
                    GDOReferences.PressedFlowerFrame,
                    GDOReferences.MossyLog,
                    GDOReferences.GardenGnome
                }
            }
        };

        private readonly Dictionary<int, Entity> BuilderOptions = new Dictionary<int, Entity>();

        protected override void OnUpdate()
        {
            BuilderOptions.Clear();
            foreach (Appliance appliance in Appliances.Keys.SelectMany(id => Appliances[id]))
            {
                appliance.IsPurchasable = false;
            }

            using (NativeArray<Entity> CurrentMenuItems = _CurrentMenuItems.ToEntityArray(Allocator.Temp))
            {
                using (NativeArray<Entity> ShopBuilderOptions = _ShopBuilderOptions.ToEntityArray(Allocator.Temp))
                {
                    foreach (Entity ShopBuilderOption in ShopBuilderOptions)
                    {
                        if (!Require(ShopBuilderOption, out CShopBuilderOption cShopBuilderOption)) continue;
                        if (BuilderOptions.ContainsKey(cShopBuilderOption.Appliance)) continue;
                        BuilderOptions.Add(cShopBuilderOption.Appliance, ShopBuilderOption);
                    }

                    foreach (Appliance appliance in Appliances.Keys.SelectMany(id => Appliances[id]))
                    {
                        if (!BuilderOptions.ContainsKey(appliance.ID)) continue;
                        EntityManager.DestroyEntity(BuilderOptions[appliance.ID]);
                        BuilderOptions.Remove(appliance.ID);
                    }
                }

                foreach (Entity CurrentMenuItem in CurrentMenuItems)
                {
                    if (!Require(CurrentMenuItem, out CMenuItem cMenuItem)) continue;
                    if (!Appliances.ContainsKey(cMenuItem.SourceDish)) continue;
                    foreach (Appliance appliance in Appliances[cMenuItem.SourceDish])
                    {
                        AddOption(appliance);
                    }
                }
            }
        }

        private void AddOption(Appliance app)
        {
            Entity entity = EntityManager.CreateEntity(typeof(CShopBuilderOption));
            EntityManager.SetComponentData(entity, new CShopBuilderOption(app));
        }
    }
}