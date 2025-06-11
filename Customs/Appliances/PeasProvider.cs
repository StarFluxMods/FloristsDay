using System.Collections.Generic;
using CsvHelper;
using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using ParentsEvent.Utilities;
using UnityEngine;

namespace ParentsEvent.Customs.Appliances
{
    public class PeasProvider : CustomAppliance
    {
        public override string UniqueNameID => "PeasProvider";

        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("PeasProvider").AssignMaterialsByNames();

        public override List<IApplianceProperty> Properties => new List<IApplianceProperty>
        {
            KitchenPropertiesUtils.GetUnlimitedCItemProvider(GDOReferences.RawPeas.ID)
        };
        public override bool SellOnlyAsDuplicate => true;
        public override bool IsPurchasable => true;
        public override PriceTier PriceTier => PriceTier.Medium;
        public override ShoppingTags ShoppingTags => ShoppingTags.Cooking | ShoppingTags.Misc;

        public override RarityTier RarityTier => RarityTier.Uncommon;
        public override List<(Locale, ApplianceInfo)> InfoList => CenteralLang.Appliances.PeasProvider;
    }
}