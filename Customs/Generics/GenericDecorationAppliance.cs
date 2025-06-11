using KitchenData;
using KitchenLib.Customs;

namespace ParentsEvent.Customs.Generics
{
    public abstract class GenericDecorationAppliance : CustomAppliance
    {
        public override bool IsPurchasable => false;
        public override PriceTier PriceTier => PriceTier.Free;
        public override ShoppingTags ShoppingTags => ShoppingTags.Decoration;
    }
}