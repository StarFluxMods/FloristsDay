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
    public class SmallSprinklerProvider : CustomAppliance
    {
        public override string UniqueNameID => "SmallSprinklerProvider";

        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("SmallSprinklerProvider").AssignMaterialsByNames();

        public override List<IApplianceProperty> Properties => new List<IApplianceProperty>
        {
            new CItemProvider
            {
                Available = 1,
                Maximum = 1,
                Item = GDOReferences.SmallSprinkler.ID,
                PreventReturns = true,
                AutoPlaceOnHolder = true
            },
            new CItemHolder()
        };
        public override bool IsPurchasable => true;
        public override PriceTier PriceTier => PriceTier.Medium;
        public override ShoppingTags ShoppingTags => ShoppingTags.Automation;

        public override RarityTier RarityTier => RarityTier.Rare;
        public override List<(Locale, ApplianceInfo)> InfoList => CenteralLang.Appliances.SmallSprinklerProvider;

        public override void OnRegister(Appliance gameDataObject)
        {
            base.OnRegister(gameDataObject);

            HoldPointContainer holdPointContainer = gameDataObject.Prefab.AddComponent<HoldPointContainer>();
            LimitedItemSourceView limitedItemSourceView = gameDataObject.Prefab.AddComponent<LimitedItemSourceView>();
 
            holdPointContainer.HoldPoint = gameDataObject.Prefab.GetChild("HoldPoint").transform;

            limitedItemSourceView.Items = new List<GameObject>
            {
                gameDataObject.Prefab.GetChild("SmallSprinkler")
            };

            limitedItemSourceView.DisplayedItems = GDOReferences.SmallSprinkler.ID;
        }
    }
}