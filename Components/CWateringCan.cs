using KitchenData;
using KitchenMods;
using Unity.Entities;

namespace ParentsEvent.Components
{
    public struct CWateringCan : IComponentData, IModComponent, IItemProperty
    {
        public int WaterLevel;
    }
}