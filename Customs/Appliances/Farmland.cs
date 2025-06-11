using System.Collections.Generic;
using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using ParentsEvent.Components;
using ParentsEvent.Utilities;
using ParentsEvent.Views;
using ParentsEvent.Views.Local;
using TMPro;
using Unity.Collections;
using UnityEngine;

namespace ParentsEvent.Customs.Appliances
{
    public class Farmland : CustomAppliance
    {
        public override string UniqueNameID => "Farmland";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("Farmland").AssignMaterialsByNames();

        public override List<IApplianceProperty> Properties => new List<IApplianceProperty>
        {
            new CItemHolder(),
            new CItemHolderFilter
            {
                NoDirectInsertion = true
            },
            new CFarmland
            {
                CanGrowItems = new FixedList32<int>
                {
                    GDOReferences.FlowerBulb.ID
                },
                DryingRate = 1,
                MinimumGrowthDelay = 3,
                MaximumGrowthDelay = 6,
                TimeUntilNextGrowthStage = -1
            },
            new CImmovable(),
        };
        public override List<(Locale, ApplianceInfo)> InfoList => CenteralLang.Appliances.Farmland;

        public override void OnRegister(Appliance gameDataObject)
        {
            base.OnRegister(gameDataObject);
            HoldPointContainer holdPointContainer = gameDataObject.Prefab.AddComponent<HoldPointContainer>();
            holdPointContainer.HoldPoint = gameDataObject.Prefab.GetChild("HoldPoint").transform;
            
            RandomPositionView randomPositionView = gameDataObject.Prefab.AddComponent<RandomPositionView>();
            randomPositionView.AffectedObjects = new List<Transform>
            {
                gameDataObject.Prefab.GetChild("HoldPoint").transform
            };
            randomPositionView.minPosition = -0.3f;
            randomPositionView.maxPosition = 0.3f;
            randomPositionView.minRotate = -90;
            randomPositionView.maxRotate = 90;
            
            
            FarmlandView farmlandView = gameDataObject.Prefab.AddComponent<FarmlandView>();
            farmlandView.WetFarmland = gameDataObject.Prefab.GetChild("WetFarmland");
            farmlandView.DryFarmland = gameDataObject.Prefab.GetChild("DryFarmland");
            farmlandView.DebugStats = gameDataObject.Prefab.GetChild("DebugStats");
            farmlandView.DebugStatsTMP = farmlandView.DebugStats.GetComponent<TextMeshPro>();
            farmlandView.RandomPosition = randomPositionView;
            farmlandView.SmallSprinkler = gameDataObject.Prefab.GetChild("SprinklerFX/Small");
            farmlandView.LargeSprinkler = gameDataObject.Prefab.GetChild("SprinklerFX/Large");
            farmlandView.SprinklerMist = new List<GameObject>
            {
                gameDataObject.Prefab.GetChild("SprinklerFX/Small/FX_Sprinkler_01/FX_Sprinkler_Mist_01"),
                gameDataObject.Prefab.GetChild("SprinklerFX/Large/FX_Sprinkler_Large_01/FX_Sprinkler_Large_Mist_01")
            };
        }
    }
}