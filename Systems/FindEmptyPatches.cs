using Kitchen;
using KitchenMods;
using ParentsEvent.Components;
using Unity.Collections;
using Unity.Entities;

namespace ParentsEvent.Systems
{
    public class FindEmptyPatches : GameSystemBase, IModSystem
    {
        private EntityQuery _DirtPatches;
        
        protected override void Initialise()
        {
            base.Initialise();
            _DirtPatches = GetEntityQuery(new QueryHelper()
                .All(typeof(CRenewableFlowerPatch), typeof(CItemHolder)));
        }

        protected override void OnUpdate()
        {
            using NativeArray<Entity> dirtPatches = _DirtPatches.ToEntityArray(Allocator.Temp);

            for (int i = 0; i < dirtPatches.Length; i++)
            {
                Entity dirtPatch = dirtPatches[i];
                if (Require(dirtPatch, out CItemHolder cItemHolder) && Require(dirtPatch, out CRenewableFlowerPatch cRenewableFlowerPatch))
                {
                    if (cItemHolder.HeldItem != Entity.Null)
                    {
                        SGameTime sGameTime = GetSingleton<SGameTime>();
                        cRenewableFlowerPatch.TimeSinceLastItem = sGameTime.TotalTime;
                        EntityManager.SetComponentData(dirtPatch, cRenewableFlowerPatch);
                    }
                }
            }
        }
    }
}