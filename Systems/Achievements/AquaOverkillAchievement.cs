using Kitchen;
using KitchenMods;
using ParentsEvent.Components;
using ParentsEvent.Enums;
using Unity.Collections;
using Unity.Entities;

namespace ParentsEvent.Systems.Achievements
{
    public class AquaOverkillAchievement : DaySystem, IModSystem
    {
        private EntityQuery _Farmland;
        protected override void Initialise()
        {
            base.Initialise();
            _Farmland = EntityManager.CreateEntityQuery(typeof(CFarmland));
        }
        
        protected override void OnUpdate()
        {
            if (HasSingleton<SAquaOverkillChecked>()) return;
            int sprinklerCount = 0;
            using (NativeArray<Entity> Farmland = _Farmland.ToEntityArray(Allocator.Temp))
            {
                foreach (Entity FarmlandPlot in Farmland)
                {
                    if (Require(FarmlandPlot, out CFarmland cFarmland))
                    {
                        if (cFarmland.SprinklerType != SprinklerType.None)
                        {
                            sprinklerCount++;
                        }
                    }
                }
            }

            if (sprinklerCount >= 5)
            {
                EntityManager.CreateEntity(typeof(SAquaOverkillChecked), typeof(CDestroyApplianceAtNight));
                Mod.achievementsManager.UnlockAchievement(Mod.ACHIEVEMENT_5_SPRINKLERS);
            }
        }
    }
}