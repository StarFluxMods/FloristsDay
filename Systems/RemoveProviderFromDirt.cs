using Kitchen;
using KitchenMods;
using ParentsEvent.Components;
using Unity.Collections;
using Unity.Entities;

namespace ParentsEvent.Systems
{
    public class RemoveProviderFromDirt : GameSystemBase, IModSystem
    {
        private EntityQuery _dirtPatchQuery;
        protected override void Initialise()
        {
            base.Initialise();
            _dirtPatchQuery = GetEntityQuery(new QueryHelper().All(typeof(CRenewableFlowerPatch), typeof(CItemProvider)));
        }

        protected override void OnUpdate()
        {
            using NativeArray<Entity> dirtPatches = _dirtPatchQuery.ToEntityArray(Allocator.Temp);
            for (int i = 0; i < dirtPatches.Length; i++)
            {
                EntityManager.RemoveComponent<CItemProvider>(dirtPatches[i]);
            }
        }
    }
}