using KitchenData;
using KitchenMods;
using Unity.Entities;

namespace ParentsEvent.Components
{
    public struct CFlower : IComponentData, IModComponent, IItemProperty
    {
        public float TimeSinceBloomed;
    }
}