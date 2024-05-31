using KitchenData;
using KitchenMods;
using Unity.Collections;
using Unity.Entities;

namespace ParentsEvent.Components
{
    public struct CRenewableFlowerPatch : IComponentData, IModComponent, IApplianceProperty
    {
        public FixedList32<int> FlowerTypes;
        public float TimeSinceLastItem;
        public bool ShouldSelectRandom;
        public int LastIndex;
        
        public bool RequiresWatering;
        public float TimeSinceLastWater;
        public float TimeToDry;
        public bool IsWatered;
    }
}