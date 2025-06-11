using System.Collections.Generic;
using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using ParentsEvent.Utilities;
using UnityEngine;

namespace ParentsEvent.Customs.Appliances
{
    public class FloristsWateringCanProvider : CustomAppliance
    {
        public override string UniqueNameID => "FloristsWateringCanProvider";

        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("WateringCanProvider").AssignMaterialsByNames();

        public override List<IApplianceProperty> Properties => new List<IApplianceProperty>
        {
            new CItemProvider
            {
                Available = 1,
                Maximum = 1,
                Item = GDOReferences.WateringCan.ID,
                PreventReturns = true,
                AutoPlaceOnHolder = true
            },
            new CItemHolder()
        };
        public override bool SellOnlyAsDuplicate => true;
        public override bool IsPurchasable => true;
        public override PriceTier PriceTier => PriceTier.Medium;
        public override ShoppingTags ShoppingTags => ShoppingTags.Cooking | ShoppingTags.Misc;

        public override RarityTier RarityTier => RarityTier.Uncommon;
        public override List<(Locale, ApplianceInfo)> InfoList => CenteralLang.Appliances.FloristsWateringCanProvider;

        public override void OnRegister(Appliance gameDataObject)
        {
            base.OnRegister(gameDataObject);

            HoldPointContainer holdPointContainer = gameDataObject.Prefab.AddComponent<HoldPointContainer>();
            LimitedItemSourceView limitedItemSourceView = gameDataObject.Prefab.AddComponent<LimitedItemSourceView>();
 
            holdPointContainer.HoldPoint = gameDataObject.Prefab.GetChild("HoldPoint").transform;

            limitedItemSourceView.Items = new List<GameObject>
            {
                gameDataObject.Prefab.GetChild("WateringCan")
            };

            limitedItemSourceView.DisplayedItems = GDOReferences.WateringCan.ID;
        }
    }
}