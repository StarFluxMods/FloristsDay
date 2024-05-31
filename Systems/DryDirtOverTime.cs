using Kitchen;
using KitchenMods;
using ParentsEvent.Components;
using Unity.Collections;
using Unity.Entities;

namespace ParentsEvent.Systems
{
    public class DryDirtOverTime : GameSystemBase, IModSystem
    {
        private EntityQuery _dirtPatches;
        protected override void Initialise()
        {
            base.Initialise();
            _dirtPatches = GetEntityQuery(new QueryHelper()
                .All(typeof(CRenewableFlowerPatch), typeof(CItemHolder)));
        }

        protected override void OnUpdate()
        {
            using NativeArray<Entity> dirtPatches = _dirtPatches.ToEntityArray(Allocator.Temp);
            for (int i = 0; i < dirtPatches.Length; i++)
            {
                Entity dirtPatch = dirtPatches[i];
                if (Require(dirtPatch, out CRenewableFlowerPatch cRenewableFlowerPatch))
                {
                    if ((cRenewableFlowerPatch.TimeSinceLastWater + cRenewableFlowerPatch.TimeToDry) < GetSingleton<SGameTime>().TotalTime)
                    {
                        cRenewableFlowerPatch.IsWatered = false;
                        EntityManager.SetComponentData(dirtPatch, cRenewableFlowerPatch);
                    }
                }

            }
        }
    }
}