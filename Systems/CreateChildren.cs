using Kitchen;
using KitchenData;
using KitchenLib.Utils;
using KitchenMods;
using ParentsEvent.Components;
using Unity.Collections;
using Unity.Entities;
using UnityEngine;

namespace ParentsEvent.Systems
{
    public class CreateChildren : DaySystem, IModSystem
    {
        private EntityQuery _CustomerGroups;
        protected override void Initialise()
        {
            base.Initialise();
            _CustomerGroups = GetEntityQuery(typeof(CCustomerGroup));
        }

        protected override void OnUpdate()
        {
            if (!HasStatus((RestaurantStatus)VariousUtils.GetID($"{Mod.MOD_GUID}.card_children"))) return;
            if (Mod.IsMysteryMeatInstalled) return;
            
            using (NativeArray<Entity> CustomerGroups = _CustomerGroups.ToEntityArray(Allocator.Temp))
            {
                foreach (Entity CustomerGroup in CustomerGroups)
                {
                    if (!Has<CChildCustomer.Marker>(CustomerGroup))
                    {
	                    if (RequireBuffer(CustomerGroup, out DynamicBuffer<CGroupMember> cGroupMemberBuffer))
                        {
                            if (cGroupMemberBuffer.Length >= 2)
                            {
                                if (Random.value < 0.5f || 1 == 1)
                                {
                                    CGroupMember cGroupMember = cGroupMemberBuffer[Random.Range(0, cGroupMemberBuffer.Length - 1)];
                                    Entity randomCustomerInGroup = cGroupMember.Customer;
                                    if (Require(randomCustomerInGroup, out CCustomer cCustomer))
                                    {
                                        cCustomer.Scale = 0.5f;
                                        cCustomer.Speed = 1.2f;
                                        Set<CChildCustomer>(randomCustomerInGroup);
                                        Set(randomCustomerInGroup, cCustomer);
                                    }
                                }
                            }
                        }
                        Set<CChildCustomer.Marker>(CustomerGroup);
                    }
                }
            }
        }
    }
}