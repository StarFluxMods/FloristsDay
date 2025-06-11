using KitchenData;
using KitchenMods;
using Unity.Collections;
using Unity.Entities;

namespace ParentsEvent.Components
{
    public struct CHasGrowthStages : IComponentData, IModComponent, IItemProperty
    {
        public FixedList32<int> CanGrowInto;
    }
}