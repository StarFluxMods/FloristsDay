using KitchenData;
using KitchenMods;
using ParentsEvent.Enums;
using Unity.Entities;

namespace ParentsEvent.Components
{
    public struct CSprinkler : IComponentData, IModComponent, IItemProperty
    {
        public SprinklerType SprinklerType;
    }
}