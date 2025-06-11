using Kitchen;
using KitchenMods;
using ParentsEvent.Components;
using Unity.Collections;
using Unity.Entities;

namespace ParentsEvent.Systems.Achievements
{
    public class RottenBouquetAchievement : DaySystem, IModSystem
    {
        private EntityQuery _WiltedFlowers;
        private bool IsComplete;

        protected override void Initialise()
        {
            base.Initialise();
            _WiltedFlowers = EntityManager.CreateEntityQuery(typeof(CWilted));
        }

        protected override void OnUpdate()
        {
            if (IsComplete) return;
            using (NativeArray<Entity> WiltedFlowers = _WiltedFlowers.ToEntityArray(Allocator.Temp))
            {
                int UnharvestedFlowers = 0;
                foreach (Entity WiltedFlower in WiltedFlowers)
                {
                    if (Require(WiltedFlower, out CHeldBy cHeldBy))
                    {
                        if (cHeldBy.Holder != Entity.Null && Has<CFarmland>(cHeldBy.Holder))
                        {
                            UnharvestedFlowers++;
                        }
                    }
                }

                if (UnharvestedFlowers >= 10)
                {
                    IsComplete = true;
                    Mod.achievementsManager.UnlockAchievement(Mod.ACHIEVEMENT_ROTTEN_BOUQUET);
                }
            }
        }
    }
}