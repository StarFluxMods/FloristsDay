using KitchenData;
using KitchenMods;
using Unity.Entities;

namespace ParentsEvent.Components
{
    public struct CCanWilt : IComponentData, IModComponent, IItemProperty
    {
        public int WiltItem;
        public float TimeDry;
        public float WiltDelay;
    }
}