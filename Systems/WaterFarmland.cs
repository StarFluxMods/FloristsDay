using Kitchen;
using KitchenMods;
using ParentsEvent.Components;
using Unity.Entities;

namespace ParentsEvent.Systems
{
    public class WaterFarmland : ItemInteractionSystem, IModSystem
    {
        private CFarmland cFarmland;
        private CWateringCan cWateringCan;
        private CItemHolder cItemHolder;
        
        protected override bool IsPossible(ref InteractionData data)
        {
            return Require(data.Target, out cFarmland) && Require(data.Interactor, out cItemHolder) && cItemHolder.HeldItem != Entity.Null && Require(cItemHolder.HeldItem, out cWateringCan) && cWateringCan.WaterLevel > 0;
        }

        protected override void Perform(ref InteractionData data)
        {
            cWateringCan.WaterLevel--;
            Set(cItemHolder.HeldItem, cWateringCan);
            cFarmland.TimeUntilDry += 5;
            Set(data.Target, cFarmland);
        }
    }
}