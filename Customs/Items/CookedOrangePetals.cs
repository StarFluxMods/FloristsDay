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
    public class CookedOrangePetals : CustomItem
    {
        public override string UniqueNameID => "CookedOrangePetals";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("CookedOrangePetals").AssignMaterialsByNames();
        public override string ColourBlindTag => "O";
        public override int SplitCount => 6;

        public override List<Item> SplitDepletedItems => new()
        {
            GDOReferences.Pot
        };

        public override Item SplitSubItem => GDOReferences.OrangePetalSoup;

        public override void OnRegister(Item gameDataObject)
        {
            base.OnRegister(gameDataObject);
            ObjectsSplittableView objectsSplittableView = gameDataObject.Prefab.AddComponent<ObjectsSplittableView>();
            FieldInfo objectsInfo = ReflectionUtils.GetField<ObjectsSplittableView>("Objects");
            List<GameObject> objects = new List<GameObject>
            {
                gameDataObject.Prefab.GetChild("PottedOrangePetals/Petel.045"),
                gameDataObject.Prefab.GetChild("PottedOrangePetals/Petel.046"),
                gameDataObject.Prefab.GetChild("PottedOrangePetals/Petel.047"),
                gameDataObject.Prefab.GetChild("PottedOrangePetals/Petel.048"),
                gameDataObject.Prefab.GetChild("PottedOrangePetals/Petel.049"),
                gameDataObject.Prefab.GetChild("PottedOrangePetals/Petel.050"),
            };
            objectsInfo.SetValue(objectsSplittableView, objects);
        }
    }
}