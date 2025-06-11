using Kitchen;
using KitchenMods;
using ParentsEvent.Components;
using Unity.Collections;
using Unity.Entities;

namespace ParentsEvent.Systems
{
    public class ProvideWrappableGift : DaySystem, IModSystem
    {
        private EntityQuery _ItemRequests;
        protected override void Initialise()
        {
            base.Initialise();
            _ItemRequests = EntityManager.CreateEntityQuery(typeof(CItem), typeof(CRequestItemOf), typeof(CProvideBaseItem));
        }

        protected override void OnUpdate()
        {
            using (NativeArray<Entity> ItemRequests = _ItemRequests.ToEntityArray(Allocator.Temp))
            {
                foreach (Entity ItemRequest in ItemRequests)
                {
                    if (Has<CProvideBaseItem.Marker>(ItemRequest)) continue;
                    Mod.Logger.LogInfo("2");
                    if (!Require(ItemRequest, out CRequestItemOf cRequestItemOf)) continue;
                    Mod.Logger.LogInfo("3");
                    if (!Require(cRequestItemOf.Group, out CAssignedTable cAssignedTable)) continue;
                    Mod.Logger.LogInfo("4");
                    if (!RequireBuffer(cAssignedTable.Table, out DynamicBuffer<CTableSetParts> cTableSetParts)) continue;
                    Mod.Logger.LogInfo("5");
                    if (!RequireBuffer(cTableSetParts[0].Entity, out DynamicBuffer<CItemStored> cItemStored)) continue;
                    Mod.Logger.LogInfo("6");
                    if (!Require(ItemRequest, out CProvideBaseItem cProvideBaseItem)) continue;
                    Mod.Logger.LogInfo("7");
                    Entity item = EntityManager.CreateEntity(typeof(CCreateItem));
                    Mod.Logger.LogInfo($"Creating Item {cProvideBaseItem.BaseItem}");
                    Set(item, new CCreateItem
                    {
                        ID = cProvideBaseItem.BaseItem
                    });
                    Set(item, new CStoredBy
                    {
                        Storage = cTableSetParts[0].Entity
                    });
                    Set<CProvideBaseItem.Marker>(ItemRequest);
                    cItemStored.Add(new CItemStored
                    {
                        StoredItem = item
                    });

                }
            }
        }
    }
}