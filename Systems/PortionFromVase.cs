using Kitchen;
using KitchenMods;
using ParentsEvent.Components;
using ParentsEvent.Utilities;
using Unity.Collections;
using Unity.Entities;
using UnityEngine;
using EntityManagerExtensions = Unity.Entities.EntityManagerExtensions;

namespace ParentsEvent.Systems
{
    public class PortionFromVase : DaySystem, IModSystem
    {
        private EntityQuery _AppliancesBeingActedOn;
        private readonly float PROGRESS_SPEED = 1;
        
        protected override void Initialise()
        {
            base.Initialise();
            _AppliancesBeingActedOn = EntityManager.CreateEntityQuery(typeof(CAppliance), typeof(CBeingActedOnBy), typeof(CItemHolder), typeof(CBeingActedOn));
        }

        protected override void OnUpdate()
        {
            using (NativeArray<Entity> AppliancesBeingActedOn = _AppliancesBeingActedOn.ToEntityArray(Allocator.Temp))
            {
                foreach (Entity appliance in AppliancesBeingActedOn)
                {
                    if (!Require(appliance, out CItemHolder cItemHolder)) continue;
                    if (cItemHolder.HeldItem == Entity.Null) continue;
                    if (!Has<CPortionableVase>(cItemHolder.HeldItem)) continue;
                    if (!Require(cItemHolder.HeldItem, out CItem cItem)) continue;
                    if (cItem.Items.Count <= 1) continue;
                    
                    if (RequireBuffer(appliance, out DynamicBuffer<CBeingActedOnBy> cBeingActedOnBy))
                    {
                        foreach (CBeingActedOnBy actor in cBeingActedOnBy)
                        {
                            if (!Has<CPlayer>(actor.Interactor)) continue;

                            if (Require(cItemHolder, out CItemUndergoingPortion cItemUndergoingPortion))
                            {
                                if (cItemUndergoingPortion.Progress >= 1)
                                {
                                    if (Require(cItemUndergoingPortion.Actor, out CItemHolder cItemHolderPlayer) && cItemHolderPlayer.HeldItem == Entity.Null)
                                    {
                                        for (var i = 0; i < cItem.Items.Count; i++)
                                        {
                                            var item = cItem.Items[i];
                                            if (item == GDOReferences.FloristsVase.ID) continue;
                                            cItem.Items.RemoveAt(i);
                                            Set(cItemHolder, cItem);

                                            Entity newItem = EntityManager.CreateEntity();
                                            Set(newItem, new CCreateItem
                                            {
                                                Holder = cItemUndergoingPortion.Actor,
                                                ID = item
                                            });
                                            EntityManager.RemoveComponent<CItemUndergoingPortion>(cItemHolder);
                                            break;
                                        }

                                        if (cItem.Items.Count == 1)
                                        {
                                            Set(cItemHolder, new CChangeItemType
                                            {
                                                NewID = GDOReferences.Vase.ID
                                            });
                                        }
                                    }
                                }
                                else
                                {
                                    float progressIncrease = Time.DeltaTime * PROGRESS_SPEED;
                                    cItemUndergoingPortion.Progress = Mathf.Clamp01(cItemUndergoingPortion.Progress + progressIncrease);
                                    cItemUndergoingPortion.CurrentChange = progressIncrease;
                                    Set(cItemHolder, cItemUndergoingPortion);
                                }
                            }
                            else
                            {
                                Set(cItemHolder, new CItemUndergoingPortion
                                {
                                    Progress = 0,
                                    Actor = actor.Interactor
                                });
                            }
                        }
                    }
                }
            }
        }
    }
}