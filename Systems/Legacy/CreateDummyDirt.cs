using Kitchen;
using KitchenLib.Utils;
using KitchenMods;
using ParentsEvent.Components;
using ParentsEvent.Customs.Items;
using ParentsEvent.Utilities;
using Unity.Collections;
using Unity.Entities;

namespace ParentsEvent.Systems
{
    public class FillUnwateredDirtPatches : DaySystem, IModSystem
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
                if (Require(dirtPatch, out CItemHolder cItemHolder) && Require(dirtPatch, out CRenewableFlowerPatch cRenewableFlowerPatch))
                {
                    if (cItemHolder.HeldItem == Entity.Null && cRenewableFlowerPatch.RequiresWatering && !cRenewableFlowerPatch.IsWatered)
                    {
                        Entity dryDirt = EntityManager.CreateEntity(typeof(CCreateItem));
                        EntityManager.AddComponentData(dryDirt, new CCreateItem
                        {
                            Holder = dirtPatch,
                            ID = GDOReferences.DryDirt.ID
                        });
                        EntityManager.AddComponentData(dirtPatch, new CItemHolderPreventTransfer
                        {
                            PreventTakingFrom = true
                        });
                    }
                }
            }
        }
    }
}