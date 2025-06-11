using Kitchen;
using KitchenMods;
using ParentsEvent.Components;
using Unity.Collections;
using Unity.Entities;

namespace ParentsEvent.Systems
{
    public class DryFarmlandOverTime : GameSystemBase, IModSystem
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
                        switch (cFarmland.TimeUntilDry)
                        {
                            case > 0:
                                cFarmland.TimeUntilDry -= Time.DeltaTime * cFarmland.DryingRate;
                                Set(plot, cFarmland);
                                break;
                            case < 0:
                                cFarmland.TimeUntilDry = 0;
                                Set(plot, cFarmland);
                                break;
                        }
                    }
                }
            }
        }
    }
}