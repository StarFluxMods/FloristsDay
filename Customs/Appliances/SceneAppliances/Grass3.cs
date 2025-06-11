using System.Collections.Generic;
using Kitchen;
using KitchenData;
using KitchenLib.Utils;
using ParentsEvent.Customs.Generics;
using ParentsEvent.Utilities;
using ParentsEvent.Views.Local;
using UnityEngine;

namespace ParentsEvent.Customs.Appliances.SceneAppliances
{
    public class Grass3 : GenericSceneAppliance
    {
        public override string UniqueNameID => "Grass3";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("Grass3").AssignMaterialsByNames();
        public override List<(Locale, ApplianceInfo)> InfoList => CenteralLang.Appliances.Grass;
        
        public override void OnRegister(Appliance gameDataObject)
        {
            base.OnRegister(gameDataObject);
            
            RandomPositionView randomPositionView = gameDataObject.Prefab.AddComponent<RandomPositionView>();
            randomPositionView.AffectedObjects = new List<Transform>
            {
                gameDataObject.Prefab.GetChild("SM_Generic_Grass_Patch_03").transform
            };
            randomPositionView.minRotate = -180;
            randomPositionView.maxRotate = 180;
        }
    }
}