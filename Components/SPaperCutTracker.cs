using KitchenMods;
using Unity.Entities;

namespace ParentsEvent.Components
{
    public struct SPaperCutTracker : IComponentData, IModComponent
    {
        public int WrappedGiftCount;
    }
}