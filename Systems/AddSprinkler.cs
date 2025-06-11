using Kitchen;
using KitchenMods;
using ParentsEvent.Components;
using ParentsEvent.Enums;
using Unity.Entities;

namespace ParentsEvent.Systems
{
    public class AddSprinkler : ItemInteractionSystem, IModSystem
    {
        private CFarmland cFarmland;
        private CSprinkler cSprinkler;
        private CItemHolder cItemHolder;
        
        protected override bool IsPossible(ref InteractionData data)
        {
            return Require(data.Target, out cFarmland) && cFarmland.SprinklerType == SprinklerType.None && Require(data.Interactor, out cItemHolder) && cItemHolder.HeldItem != Entity.Null && Require(cItemHolder.HeldItem, out cSprinkler);
        }

        protected override void Perform(ref InteractionData data)
        {
            cFarmland.SprinklerType = cSprinkler.SprinklerType;
            Set(data.Target, cFarmland);
            EntityManager.DestroyEntity(cItemHolder.HeldItem);
        }
    }
}