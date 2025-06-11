using KitchenData;
using KitchenMods;
using ParentsEvent.Enums;
using Unity.Collections;
using Unity.Entities;

namespace ParentsEvent.Components
{
    public struct CFarmland : IComponentData, IModComponent, IApplianceProperty
    {
        // Drying Related
        public float TimeUntilDry;
        public float DryingRate;
        
        // View Related
        public int RandomState;
        public SprinklerType SprinklerType;
        
        // Growth Related
        public float MinimumGrowthDelay;
        public float MaximumGrowthDelay;
        public float TimeUntilNextGrowthStage;
        public FixedList32<int> CanGrowItems;
    }
}