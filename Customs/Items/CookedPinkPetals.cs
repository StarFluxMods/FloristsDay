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
    public class CookedPinkPetals : CustomItem
    {
        public override string UniqueNameID => "CookedPinkPetals";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("CookedPinkPetals").AssignMaterialsByNames();
        public override string ColourBlindTag => "P";
        public override int SplitCount => 6;

        public override List<Item> SplitDepletedItems => new()
        {
            GDOReferences.Pot
        };

        public override Item SplitSubItem => GDOReferences.PinkPetalSoup;
        public override Item DisposesTo => GDOReferences.Pot;

        public override void OnRegister(Item gameDataObject)
        {
            base.OnRegister(gameDataObject);
            ObjectsSplittableView objectsSplittableView = gameDataObject.Prefab.AddComponent<ObjectsSplittableView>();
            FieldInfo objectsInfo = ReflectionUtils.GetField<ObjectsSplittableView>("Objects");
            List<GameObject> objects = new List<GameObject>
            {
                gameDataObject.Prefab.GetChild("PottedPinkPetals/Petel.036"),
                gameDataObject.Prefab.GetChild("PottedPinkPetals/Petel.037"),
                gameDataObject.Prefab.GetChild("PottedPinkPetals/Petel.038"),
                gameDataObject.Prefab.GetChild("PottedPinkPetals/Petel.039"),
                gameDataObject.Prefab.GetChild("PottedPinkPetals/Petel.040"),
                gameDataObject.Prefab.GetChild("PottedPinkPetals/Petel.041"),
            };
            objectsInfo.SetValue(objectsSplittableView, objects);
        }
    }
}