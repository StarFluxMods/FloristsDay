using System.Collections.Generic;
using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using ParentsEvent.Components;
using ParentsEvent.Customs.Items;
using ParentsEvent.Views;
using Unity.Collections;
using UnityEngine;

namespace ParentsEvent.Customs.Appliances
{
    public class FlowerPot : CustomAppliance
    {
        public override string UniqueNameID => "FlowerPot";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("FlowerPot").AssignMaterialsByNames();

        public override List<IApplianceProperty> Properties => new List<IApplianceProperty>
        {
            new CItemHolder(),
            new CRenewableFlowerPatch
            {
                TimeSinceLastItem = 0,
                FlowerTypes = new FixedList32<int>()
                {
                    GDOUtils.GetCustomGameDataObject<FlowerRed>().ID,
                    GDOUtils.GetCustomGameDataObject<FlowerGreen>().ID,
                    GDOUtils.GetCustomGameDataObject<FlowerBlue>().ID
                },
                RequiresWatering = true,
                TimeSinceLastWater = 0,
                IsWatered = false
            }
        };

        public override ShoppingTags ShoppingTags => ShoppingTags.Basic;

        public override List<(Locale, ApplianceInfo)> InfoList => new List<(Locale, ApplianceInfo)>
        {
            (
                Locale.English,
                new ApplianceInfo
                {
                    Name = "Dirty Flower Pot",
                    Description = "Bring the garden inside!"
                }
            )
        };

        public override List<Appliance> RequiresForShop => new List<Appliance>
        {
            (Appliance)GDOUtils.GetCustomGameDataObject<DirtPatch>().GameDataObject
        };

        public override bool IsPurchasable => true;

        public override void OnRegister(Appliance gameDataObject)
        {
            base.OnRegister(gameDataObject);

            DirtPatchClientView dirtPatchClientView = gameDataObject.Prefab.AddComponent<DirtPatchClientView>();
            HoldPointContainer holdPointContainer = gameDataObject.Prefab.AddComponent<HoldPointContainer>();

            dirtPatchClientView.HoldPoints = new[]
            {
                gameDataObject.Prefab.GetChild("HoldPoint"),
            };

            DirtPatchView dirtPatchView = gameDataObject.Prefab.AddComponent<DirtPatchView>();
            dirtPatchView.WateredLayer = gameDataObject.Prefab.GetChild("FlowerPot/WetDirt");
        }
    }
}