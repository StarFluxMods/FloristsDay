using Kitchen;
using KitchenMods;
using ParentsEvent.Components;
using Unity.Entities;

namespace ParentsEvent.Systems
{
    public class HelperSystem : GameSystemBase, IModSystem
    {
        public static HelperSystem Instance;
        protected override void Initialise()
        {
            base.Initialise();
            Instance = this;
        }

        protected override void OnUpdate()
        {
        }

        public bool IsCustomerChild(Entity group, int index)
        {
            if (!RequireBuffer(group, out DynamicBuffer<CGroupMember> cGroupMemberBuffer)) return false;
            return cGroupMemberBuffer.Length >= index && Has<CChildCustomer>(cGroupMemberBuffer[index].Customer);
        }

        public bool RequireHelper<T>(Entity entity, out T result) where T : struct, IComponentData
        {
            return Require<T>(entity, out result);
        }
    }
}