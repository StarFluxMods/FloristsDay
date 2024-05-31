using System.Collections.Generic;
using Kitchen;
using KitchenLib.Utils;
using KitchenMods;
using ParentsEvent.Components;
using ParentsEvent.Customs.ItemGroups;
using Unity.Collections;
using Unity.Entities;
using UnityEngine;

namespace ParentsEvent.Systems
{
    public class RemoveDummyDirt : DaySystem, IModSystem
    {
        private EntityQuery _dirtPatches;
        private EntityQuery _players;
        protected override void Initialise()
        {
            base.Initialise();
            _dirtPatches = GetEntityQuery(new QueryHelper()
                .All(typeof(CRenewableFlowerPatch), typeof(CItemHolder), typeof(CItemHolderPreventTransfer)));
            
            _players = GetEntityQuery(new QueryHelper()
                .All(typeof(CPlayer)));
        }

        private static int GetTimeToDry(int playerCount)
        {
            switch (playerCount)
            {
                case 1:
                    return Random.Range(25, 30);
                case 2:
                    return Random.Range(20, 25);
                case 3:
                    return Random.Range(15, 20);
                case 4:
                    return Random.Range(10, 15);
                default:
                    return Random.Range(10, 15);
            }
        }

        protected override void OnUpdate()
        {
            using NativeArray<Entity> dirtPatches = _dirtPatches.ToEntityArray(Allocator.Temp);

            for (int i = 0; i < dirtPatches.Length; i++)
            {
                Entity dirtPatch = dirtPatches[i];
                if (Require(dirtPatch, out CItemHolder cItemHolder) && Require(dirtPatch, out CRenewableFlowerPatch cRenewableFlowerPatch))
                {
                    if (cItemHolder.HeldItem != Entity.Null && Require(cItemHolder.HeldItem, out CItem cItem))
                    {
                        if (cItem.ID == GDOUtils.GetCustomGameDataObject<WetDirt>().ID)
                        {
                            EntityManager.DestroyEntity(cItemHolder.HeldItem);
                            EntityManager.RemoveComponent<CItemHolderPreventTransfer>(dirtPatch);
                            cRenewableFlowerPatch.TimeSinceLastWater = GetSingleton<SGameTime>().TotalTime;
                            cRenewableFlowerPatch.IsWatered = true;
                            cRenewableFlowerPatch.TimeToDry = GetTimeToDry(_players.CalculateEntityCount());
                            EntityManager.SetComponentData(dirtPatch, cRenewableFlowerPatch);
                        }
                    }
                }
            }
        }
    }
}