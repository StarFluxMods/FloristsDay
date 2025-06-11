using Kitchen;
using KitchenMods;
using ParentsEvent.Components;
using Unity.Collections;
using Unity.Entities;

namespace ParentsEvent.Systems.Achievements
{
    public class PaperCutAchievement : DaySystem, IModSystem
    {
        private EntityQuery _WrappedGifts;
        protected override void Initialise()
        {
            base.Initialise();
            _WrappedGifts = EntityManager.CreateEntityQuery(typeof(CWrappedGift));
        }

        protected override void OnUpdate()
        {
            using (NativeArray<Entity> WrappedGifts = _WrappedGifts.ToEntityArray(Allocator.Temp))
            {
                foreach (Entity WrappedGift in WrappedGifts)
                {
                    if (Has<CTrackedGift>(WrappedGift)) continue;
                    Set<CTrackedGift>(WrappedGift);

                    if (!HasSingleton<SPaperCutTracker>())
                    {
                        EntityManager.CreateEntity(typeof(SPaperCutTracker));
                    }
                    
                    SPaperCutTracker singleton = GetSingleton<SPaperCutTracker>();
                    singleton.WrappedGiftCount++;
                    SetSingleton(singleton);

                    if (singleton.WrappedGiftCount == 20)
                    {
                        singleton.WrappedGiftCount = 0;
                        SetSingleton(singleton);
                        Mod.achievementsManager.UnlockAchievement(Mod.ACHIEVEMENT_WRAP_20_GIFTS);
                    }
                }
            }
        }
    }
}