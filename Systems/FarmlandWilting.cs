using Kitchen;
using KitchenData;
using KitchenLib.Utils;
using KitchenMods;
using ParentsEvent.Components;
using ParentsEvent.Utilities;
using Unity.Collections;
using Unity.Entities;

namespace ParentsEvent.Systems
{
    public class FarmlandWilting : DaySystem, IModSystem
    {
        private EntityQuery _farmland;
        protected override void Initialise()
        {
            base.Initialise();
            _farmland = GetEntityQuery(typeof(CFarmland), typeof(CItemHolder));
        }

        protected override void OnUpdate()
        {
            if (!HasStatus((RestaurantStatus)VariousUtils.GetID($"{Mod.MOD_GUID}.card_flowers_wilter"))) return;
            using (NativeArray<Entity> farmland = _farmland.ToEntityArray(Allocator.Temp))
            {
                foreach (Entity farmlandEntity in farmland)
                {
                    if (!Require(farmlandEntity, out CFarmland cFarmland)) continue;
                    if (!Require(farmlandEntity, out CItemHolder cItemHolder)) continue;
                    if (cItemHolder.HeldItem == Entity.Null) continue;
                    if (!Require(cItemHolder.HeldItem, out CCanWilt cCanWilt)) continue;

                    if (cFarmland.TimeUntilDry <= 0)
                    {
                        cCanWilt.TimeDry += Time.DeltaTime;
                        if (cCanWilt.TimeDry > cCanWilt.WiltDelay)
                        {
                            Set(cItemHolder.HeldItem, new CChangeItemType
                            {
                                NewID = cCanWilt.WiltItem
                            });
                            EntityManager.RemoveComponent<CCanWilt>(cItemHolder.HeldItem);
                        }
                        else
                        {
                            Set(cItemHolder.HeldItem, cCanWilt);
                        }
                    }
                    else
                    {
                        cCanWilt.TimeDry = 0;
                        Set(cItemHolder.HeldItem, cCanWilt);
                    }

                }
            }
        }
    }
}