using Kitchen;
using KitchenLib.References;
using KitchenMods;
using ParentsEvent.Components;
using Unity.Collections;
using Unity.Entities;

namespace ParentsEvent.Systems
{
    public class MopWatering : GameSystemBase, IModSystem
    {
        private EntityQuery _Mops;
        
        protected override void Initialise()
        {
            base.Initialise();
            _Mops = GetEntityQuery(typeof(CToolClean), typeof(CToolInUse));
        }

        protected override void OnUpdate()
        {
            using (NativeArray<Entity> Mops = _Mops.ToEntityArray(Allocator.Temp))
            {
                foreach (Entity Mop in Mops)
                {
                    if (Require(Mop, out CToolInUse cToolInUse) && Require(Mop, out CToolClean cToolClean) && cToolInUse.User != Entity.Null && Require(cToolInUse.User, out CPosition cPosition))
                    {
                        Entity occupant = TileManager.GetOccupant(cPosition);
                        float timeToAdd = 0;
                        switch (cToolClean.WaterAppliance)
                        {
                            case 377065033:
                                timeToAdd = 2;
                                break;
                            case -1424385600:
                                timeToAdd = 6;
                                break;
                            default:
                                timeToAdd = 2;
                                break;
                        }
                        if (occupant != Entity.Null && Require(occupant, out CFarmland cFarmland))
                        {
                            if (cFarmland.TimeUntilDry <= 0)
                            {
                                cFarmland.TimeUntilDry += timeToAdd;
                                Set(occupant, cFarmland);
                            }
                        }
                    }
                }
            }
        }
    }
}