using Kitchen;
using KitchenMods;
using ParentsEvent.Components;
using Unity.Collections;
using Unity.Entities;
using UnityEngine;

namespace ParentsEvent.Systems
{
    public class GrowFlowers : DaySystem, IModSystem
    {
        private EntityQuery _emptyDirtPatches;
        private static float renewtime = 5f;
        
        protected override void Initialise()
        {
            base.Initialise();
            _emptyDirtPatches = GetEntityQuery(new QueryHelper()
                .All(typeof(CRenewableFlowerPatch), typeof(CItemHolder)));
        }

        protected override void OnUpdate()
        {
            SGameTime sGameTime = GetSingleton<SGameTime>();
            
            using NativeArray<Entity> emptyDirtPatches = _emptyDirtPatches.ToEntityArray(Allocator.Temp);

            for (int i = 0; i < emptyDirtPatches.Length; i++)
            {
                Entity dirtPatch = emptyDirtPatches[i];
                if (!Require(dirtPatch, out CRenewableFlowerPatch renewableFlowerPatch) || !Require(dirtPatch, out CItemHolder cItemHolder)) continue;
                if (cItemHolder.HeldItem != Entity.Null) continue;
                if (sGameTime.TotalTime - renewableFlowerPatch.TimeSinceLastItem < renewtime) continue;
                if (renewableFlowerPatch.RequiresWatering && !renewableFlowerPatch.IsWatered) continue;

                int index = 0;
                if (renewableFlowerPatch.ShouldSelectRandom)
                {
                    index = Random.Range(0, renewableFlowerPatch.FlowerTypes.Length);
                }
                else
                {
                    if (renewableFlowerPatch.LastIndex == -1)
                    {
                        index = Random.Range(0, renewableFlowerPatch.FlowerTypes.Length);
                    }
                    else
                    {
                        index = renewableFlowerPatch.LastIndex + 1;
                        if (index >= renewableFlowerPatch.FlowerTypes.Length)
                        {
                            index = 0;
                        }
                    }
                }
                
                renewableFlowerPatch.LastIndex = index;
                EntityManager.SetComponentData(dirtPatch, renewableFlowerPatch);

                Entity flower = EntityManager.CreateEntity(typeof(CCreateItem));
                EntityManager.AddComponentData(flower, new CCreateItem
                {
                    Holder = dirtPatch,
                    ID = renewableFlowerPatch.FlowerTypes[index]
                });
            }
        }
    }
}