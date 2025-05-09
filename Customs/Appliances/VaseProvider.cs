using System.Collections.Generic;
using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using ParentsEvent.Customs.Items;
using ParentsEvent.Utilities;
using UnityEngine;

namespace ParentsEvent.Customs.Appliances
{
    public class VaseProvider : CustomAppliance
    {
        public override string UniqueNameID => "VaseProvider";

        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("Vase Provider").AssignMaterialsByNames();

        public override List<IApplianceProperty> Properties => new List<IApplianceProperty>
        {
            new CItemProvider
            {
                Available = -1,
                Maximum = -1,
                Item = GDOReferences.EmptyVase.ID
            }
        };

        public override PriceTier PriceTier => PriceTier.Medium;
        public override RarityTier RarityTier => RarityTier.Uncommon;
        public override bool IsPurchasable => true;
        public override bool SellOnlyAsDuplicate => true;

        public override List<(Locale, ApplianceInfo)> InfoList => new List<(Locale, ApplianceInfo)>
        {
            (Locale.English, new ApplianceInfo
            {
                Name = "Vases",
                Description = "Provides Vases"
            })
        };
    }
}