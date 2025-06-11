using Kitchen;
using KitchenMods;
using ParentsEvent.Components;
using Unity.Collections;
using Unity.Entities;

namespace ParentsEvent.Systems
{
    public class ClearPortionComponent : GameSystemBase, IModSystem
    {
        private EntityQuery _PortioningVases;
        protected override void Initialise()
        {
            base.Initialise();
            _PortioningVases = EntityManager.CreateEntityQuery(typeof(CItem), typeof(CItemUndergoingPortion), typeof(CHeldBy));
        }

        protected override void OnUpdate()
        {
            using (NativeArray<Entity> PortioningVases = _PortioningVases.ToEntityArray(Allocator.Temp))
            {
                foreach (Entity Vase in PortioningVases)
                {
                    if (Require(Vase, out CHeldBy cHeldBy))
                    {
                        if (!Has<CAppliance>(cHeldBy.Holder))
                        {
                            EntityManager.RemoveComponent<CItemUndergoingPortion>(Vase);
                        }
                    }
                }
            }
        }
    }
}