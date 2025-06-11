using System.Collections.Generic;
using KitchenData;
using KitchenLib.Utils;
using ParentsEvent.Customs.Generics;
using ParentsEvent.Utilities;
using ParentsEvent.Views.Local;
using UnityEngine;

namespace ParentsEvent.Customs.Appliances.SceneAppliances
{
    public class Flowers3 : GenericSceneAppliance
    {
        public override string UniqueNameID => "Flowers3";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("Flowers3").AssignMaterialsByNames();
        public override List<(Locale, ApplianceInfo)> InfoList => CenteralLang.Appliances.Flowers;
        
        public override void OnRegister(Appliance gameDataObject)
        {
            base.OnRegister(gameDataObject);
            
            RandomPositionView randomPositionView = gameDataObject.Prefab.AddComponent<RandomPositionView>();
            randomPositionView.AffectedObjects = new List<Transform>
            {
                gameDataObject.Prefab.GetChild("SM_Env_Flowers_03").transform
            };
            randomPositionView.minRotate = -180;
            randomPositionView.maxRotate = 180;
        }
    }
}