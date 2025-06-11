using Kitchen;
using KitchenMods;
using ParentsEvent.Components;
using Unity.Collections;
using Unity.Entities;
using UnityEngine;

namespace ParentsEvent.Systems
{
    public class FarmlandGrowth : DaySystem, IModSystem
    {
        private EntityQuery _farmland;
        protected override void Initialise()
        {
            base.Initialise();
            _farmland = GetEntityQuery(typeof(CFarmland), typeof(CItemHolder));
        }

        protected override void OnUpdate()
        {
            using (NativeArray<Entity> farmland = _farmland.ToEntityArray(Allocator.Temp))
            {
                foreach (Entity farmlandEntity in farmland)
                {
                    if (!Require(farmlandEntity, out CFarmland cFarmland)) continue;
                    if (cFarmland.TimeUntilDry <= 0) continue;
                    if (Mathf.Approximately(cFarmland.TimeUntilNextGrowthStage, -1))
                    {
                        cFarmland.TimeUntilNextGrowthStage = Random.Range(cFarmland.MinimumGrowthDelay, cFarmland.MaximumGrowthDelay);
                    }
                    else if (cFarmland.TimeUntilNextGrowthStage <= 0)
                    {
                        cFarmland.TimeUntilNextGrowthStage = Random.Range(cFarmland.MinimumGrowthDelay, cFarmland.MaximumGrowthDelay);
                        if (Require(farmlandEntity, out CItemHolder cItemHolder))
                        {
                            if (cItemHolder.HeldItem == Entity.Null)
                            {
                                cFarmland.RandomState = Random.Range(int.MinValue, int.MaxValue);
                                Entity flower = EntityManager.CreateEntity(typeof(CCreateItem));
                                EntityManager.AddComponentData(flower, new CCreateItem
                                {
                                    Holder = farmlandEntity,
                                    ID = cFarmland.CanGrowItems[Random.Range(0, cFarmland.CanGrowItems.Length)],
                                });
                            }
                            else
                            {
                                if (Require(cItemHolder.HeldItem, out CHasGrowthStages cHasGrowthStages))
                                {
                                    if (Has<CCanWilt>(cItemHolder.HeldItem)) EntityManager.RemoveComponent<CCanWilt>(cItemHolder.HeldItem);
                                    EntityManager.RemoveComponent<CHasGrowthStages>(cItemHolder.HeldItem);
                                    Set(cItemHolder.HeldItem, new CChangeItemType
                                    {
                                        NewID = cHasGrowthStages.CanGrowInto[Random.Range(0, cHasGrowthStages.CanGrowInto.Length)]
                                    });
                                }
                            }
                        }
                    }
                    else
                    {
                        cFarmland.TimeUntilNextGrowthStage -= Time.DeltaTime;
                    }
                    Set(farmlandEntity, cFarmland);
                }
            }
        }
    }
}