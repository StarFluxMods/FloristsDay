using System.Collections.Generic;
using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using ParentsEvent.Utilities;
using UnityEngine;

namespace ParentsEvent.Customs.Appliances
{
    public class FloristsVaseProvider : CustomAppliance
    {
        public override string UniqueNameID => "FloristsVaseProvider";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("FloristsVaseProvider").AssignMaterialsByNames();
        public override List<IApplianceProperty> Properties => new List<IApplianceProperty>
        {
            new CItemProvider
            {
                Item = GDOReferences.Vase.ID,
                ProvidedItem = GDOReferences.Vase.ID,
                Available = 4,
                Maximum = 4
            }
        };
        public override bool SellOnlyAsDuplicate => true;
        public override bool IsPurchasable => true;
        public override PriceTier PriceTier => PriceTier.Medium;
        public override ShoppingTags ShoppingTags => ShoppingTags.Cooking | ShoppingTags.Misc;
        public override List<(Locale, ApplianceInfo)> InfoList => CenteralLang.Appliances.FloristsVaseProvider;

        public override void OnRegister(Appliance gameDataObject)
        {
            base.OnRegister(gameDataObject);
            LimitedItemSourceView limitedItemSourceView = gameDataObject.Prefab.AddComponent<LimitedItemSourceView>();
            limitedItemSourceView.Items = new List<GameObject>
            {
                gameDataObject.Prefab.GetChild("FloristsVaseProvider/FloristsVase.001"),
                gameDataObject.Prefab.GetChild("FloristsVaseProvider/FloristsVase.002"),
                gameDataObject.Prefab.GetChild("FloristsVaseProvider/FloristsVase.003"),
                gameDataObject.Prefab.GetChild("FloristsVaseProvider/FloristsVase.004"),
            };
        }
    }
}