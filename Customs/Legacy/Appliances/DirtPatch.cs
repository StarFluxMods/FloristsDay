using System.Collections.Generic;
using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using ParentsEvent.Components;
using ParentsEvent.Customs.Items;
using ParentsEvent.Utilities;
using ParentsEvent.Views;
using Unity.Collections;
using UnityEngine;

namespace ParentsEvent.Customs.Appliances
{
    public class DirtPatch : CustomAppliance
    {
        public override string UniqueNameID => "DirtPatch";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("DirtPatch").AssignMaterialsByNames();

        public override List<IApplianceProperty> Properties => new List<IApplianceProperty>
        {
            new CItemHolder(),
            new CRenewableFlowerPatch
            {
                TimeSinceLastItem = 0,
                FlowerTypes = new FixedList32<int>()
                {
                    GDOReferences.FlowerRed.ID,
                    GDOReferences.FlowerGreen.ID,
                    GDOReferences.FlowerBlue.ID
                },
                RequiresWatering = true,
                TimeSinceLastWater = 0,
                IsWatered = false,
                LastIndex = -1
            },
            new CImmovable(),
        };

        public override List<(Locale, ApplianceInfo)> InfoList => new List<(Locale, ApplianceInfo)>
        {
            (
                Locale.English,
                new ApplianceInfo
                {
                    Name = "Dirt Patch",
                }
            )
        };

        public override void OnRegister(Appliance gameDataObject)
        {
            base.OnRegister(gameDataObject);

            DirtPatchClientView dirtPatchClientView = gameDataObject.Prefab.AddComponent<DirtPatchClientView>();
            HoldPointContainer holdPointContainer = gameDataObject.Prefab.AddComponent<HoldPointContainer>();

            dirtPatchClientView.HoldPoints = new[]
            {
                gameDataObject.Prefab.GetChild("HoldPoints/HoldPoint1"),
                gameDataObject.Prefab.GetChild("HoldPoints/HoldPoint2"),
                gameDataObject.Prefab.GetChild("HoldPoints/HoldPoint3"),
                gameDataObject.Prefab.GetChild("HoldPoints/HoldPoint7"),
                gameDataObject.Prefab.GetChild("HoldPoints/HoldPoint8"),
                gameDataObject.Prefab.GetChild("HoldPoints/HoldPoint9")
            };

            DirtPatchView dirtPatchView = gameDataObject.Prefab.AddComponent<DirtPatchView>();
            dirtPatchView.WateredLayer = gameDataObject.Prefab.GetChild("WetLand");
        }
    }
}