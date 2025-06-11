using Unity.Entities;

namespace ParentsEvent.Components
{
    public struct CItemUndergoingPortion : IComponentData
    {
        public bool IsBeingSplit => Progress == -1;
        public float Progress;
        public float CurrentChange;
        public Entity Actor;
    }
}