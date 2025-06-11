using KitchenData;
using KitchenLib.Customs;

namespace ParentsEvent.Customs.Generics
{
    public abstract class GenericStackableItem : CustomItem
    {
        public override ItemStorage ItemStorageFlags => ItemStorage.StackableFood;
    }
}