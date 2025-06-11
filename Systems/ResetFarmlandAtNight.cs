using Kitchen;
using KitchenMods;
using ParentsEvent.Components;
using ParentsEvent.Enums;
using Unity.Collections;
using Unity.Entities;

namespace ParentsEvent.Systems
{
    public class ResetFarmlandAtNight : StartOfNightSystem, IModSystem
    {
        private EntityQuery _farmland;
        protected override void Initialise()
        {
            base.Initialise();
            _farmland = EntityManager.CreateEntityQuery(typeof(CFarmland));
        }

        protected override void OnUpdate()
        {
            using (NativeArray<Entity> farmland = _farmland.ToEntityArray(Allocator.Temp))
            {
                foreach (Entity plot in farmland)
                {
                    if (Require(plot, out CFarmland cFarmland))
                    {
                        cFarmland.TimeUntilDry = 0;
                        cFarmland.SprinklerType = SprinklerType.None;
                        Set(plot, cFarmland);
                    }
                }
            }
        }
    }
}