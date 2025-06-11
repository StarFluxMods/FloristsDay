using System.Collections.Generic;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;

namespace ParentsEvent.Customs.Generics
{
    public abstract class GenericProvider : CustomAppliance
    {
        public abstract Item ProvidedItem { get; }

        public override List<IApplianceProperty> Properties => new()
        {
            KitchenPropertiesUtils.GetUnlimitedCItemProvider(ProvidedItem.ID)
        };

        public override bool SellOnlyAsDuplicate => true;
        public override bool IsPurchasable => true;
        public override PriceTier PriceTier => PriceTier.Medium;
        public override ShoppingTags ShoppingTags => ShoppingTags.Cooking | ShoppingTags.Misc;
        public override RarityTier RarityTier => RarityTier.Uncommon;
    }
}