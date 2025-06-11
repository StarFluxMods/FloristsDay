using System.Collections.Generic;
using System.Reflection;
using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using ParentsEvent.Customs.Generics;
using ParentsEvent.Utilities;
using UnityEngine;

namespace ParentsEvent.Customs.Items
{
    public class CookedBluePetals : CustomItem
    {
        public override string UniqueNameID => "CookedBluePetals";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("CookedBluePetals").AssignMaterialsByNames();
        public override string ColourBlindTag => "B";
        public override int SplitCount => 6;

        public override List<Item> SplitDepletedItems => new()
        {
            GDOReferences.Pot
        };

        public override Item SplitSubItem => GDOReferences.BluePetalSoup;

        public override void OnRegister(Item gameDataObject)
        {
            base.OnRegister(gameDataObject);
            ObjectsSplittableView objectsSplittableView = gameDataObject.Prefab.AddComponent<ObjectsSplittableView>();
            FieldInfo objectsInfo = ReflectionUtils.GetField<ObjectsSplittableView>("Objects");
            List<GameObject> objects = new List<GameObject>
            {
                gameDataObject.Prefab.GetChild("PottedBluePetals/Petel.051"),
                gameDataObject.Prefab.GetChild("PottedBluePetals/Petel.052"),
                gameDataObject.Prefab.GetChild("PottedBluePetals/Petel.053"),
                gameDataObject.Prefab.GetChild("PottedBluePetals/Petel.054"),
                gameDataObject.Prefab.GetChild("PottedBluePetals/Petel.055"),
                gameDataObject.Prefab.GetChild("PottedBluePetals/Petel.056"),
            };
            objectsInfo.SetValue(objectsSplittableView, objects);
        }
    }
}