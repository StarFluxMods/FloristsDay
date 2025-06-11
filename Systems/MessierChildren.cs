using System.Xml.Serialization.Configuration;
using Kitchen;
using KitchenData;
using KitchenMods;
using ParentsEvent.Components;
using Unity.Collections;
using Unity.Entities;

namespace ParentsEvent.Systems
{
    [UpdateInGroup(typeof(UpdateCustomerStatesGroup))]
    public class MessierChildren : GameSystemBase, IModSystem
    {
        private EntityQuery _eatingGroups;
        protected override void Initialise()
        {
            base.Initialise();
            _eatingGroups = GetEntityQuery(typeof(CGroupEating), typeof(CGroupMealPhase), typeof(CPatience), typeof(CWaitingForItem), typeof(CCustomerSettings), typeof(CPosition), typeof(CGroupMember));
        }

        protected override void OnUpdate()
        {
            using (NativeArray<Entity> eatingGroups = _eatingGroups.ToEntityArray(Allocator.Temp))
            {
                foreach (Entity eatingGroup in eatingGroups)
                {
                    if (RequireBuffer(eatingGroup, out DynamicBuffer<CGroupMember> groupMembers) && Require(eatingGroup, out CCustomerSettings cCustomerSettings))
                    {
                        float value = UnityEngine.Random.value;
                        int num = 2; 
                        bool shouldBeBuffedFloor = false;
                        if (Require(eatingGroup, out CHalloweenOrder cHalloweenOrder))
                        {
                            if (cHalloweenOrder.State == TrickTreatStates.TrickExtraMess)
                            {
                                num *= 3;
                            }
                            else if (cHalloweenOrder.State == TrickTreatStates.TreatBuffFloors)
                            {
                                shouldBeBuffedFloor = true;
                                num *= 3;
                            }
                        }
                        float num2 = num;
                        if (value < num2 * groupMembers.Length * 0.4f * Time.DeltaTime * cCustomerSettings.Ordering.MessFactor && !cCustomerSettings.Ordering.PreventMess)
                        {
                            foreach (CGroupMember cGroupMember in groupMembers)
                            {
                                if (Has<CChildCustomer>(cGroupMember) && Require(cGroupMember, out CPosition cPosition))
                                {
                                    Entity mess = EntityManager.CreateEntity();
                                    Set(mess, cPosition);
                                    if (shouldBeBuffedFloor)
                                    {
                                        Set(mess, new CMessRequest
                                        {
                                            ID = AssetReference.BuffedFloor,
                                            OverwriteOtherMesses = true
                                        });
                                    }
                                    else
                                    {
                                        Set(mess, new CMessRequest
                                        {
                                            ID = AssetReference.CustomerMess
                                        });
                                        CSoundEvent.Create(EntityManager, SoundEvent.MessCreated);
                                        Mod.Logger.LogInfo("Created Additional Mess at Children's Position");
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}