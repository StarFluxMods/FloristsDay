using KitchenData;
using KitchenMods;
using Unity.Entities;

namespace ParentsEvent.Components
{
    public struct CProvideBaseItem : IComponentData, IModComponent, IItemProperty
    {
        public int BaseItem;

        public struct Marker : IComponentData, IModComponent
        {
        }
    }
}