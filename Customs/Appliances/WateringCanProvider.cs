using System.Collections.Generic;
using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using ParentsEvent.Customs.Items;
using UnityEngine;

namespace ParentsEvent.Customs.Appliances
{
    public class WateringCanProvider : CustomAppliance
    {
        public override string UniqueNameID => "WateringCanProvider";

        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("WateringCan Provider").AssignMaterialsByNames();

        public override List<IApplianceProperty> Properties => new List<IApplianceProperty>
        {
            new CItemProvider
            {
                Available = 1,
                Maximum = 1,
                Item = GDOUtils.GetCustomGameDataObject<EmptyWateringCan>().ID,
                PreventReturns = true,
                AutoPlaceOnHolder = true
            },
            new CItemHolder()
        };

        public override PriceTier PriceTier => PriceTier.Medium;
        public override RarityTier RarityTier => RarityTier.Uncommon;
        public override bool IsPurchasable => true;
        public override bool SellOnlyAsDuplicate => true;

        public override List<(Locale, ApplianceInfo)> InfoList => new List<(Locale, ApplianceInfo)>
        {
            (Locale.English, new ApplianceInfo
            {
                Name = "Watering Can",
                Description = "Provides a Watering Can"
            })
        };

        public override void OnRegister(Appliance gameDataObject)
        {
            base.OnRegister(gameDataObject);
            
            HoldPointContainer holdPointContainer = gameDataObject.Prefab.AddComponent<HoldPointContainer>();
            LimitedItemSourceView limitedItemSourceView = gameDataObject.Prefab.AddComponent<LimitedItemSourceView>();
            
            holdPointContainer.HoldPoint = gameDataObject.Prefab.GetChild("Block/HoldPoint").transform;

            limitedItemSourceView.Items = new List<GameObject>
            {
                gameDataObject.Prefab.GetChild("EmptyWateringCan")
            };

            limitedItemSourceView.DisplayedItems = GDOUtils.GetCustomGameDataObject<EmptyWateringCan>().ID;
        }
    }
}