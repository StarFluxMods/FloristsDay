using System.Collections.Generic;
using System.Reflection;
using Kitchen;
using KitchenData;
using KitchenLib.Utils;
using ParentsEvent.Customs.Generics;
using ParentsEvent.Utilities;
using UnityEngine;

namespace ParentsEvent.Customs.Items
{
    public class ChocolateBarkChopped : GenericStackableItem
    {
        public override string UniqueNameID => "ChocolateBarkChopped";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("ChocolateBarkChopped").AssignMaterialsByNames();
        public override int SplitCount => 8;

        public override List<Item> SplitDepletedItems => new()
        {
            GDOReferences.ChocolateBarkPortion
        };

        public override Item SplitSubItem => GDOReferences.ChocolateBarkPortion;
        
        public override void OnRegister(Item gameDataObject)
        {
            base.OnRegister(gameDataObject);
            ObjectsSplittableView objectsSplittableView = gameDataObject.Prefab.AddComponent<ObjectsSplittableView>();
            FieldInfo objectsInfo = ReflectionUtils.GetField<ObjectsSplittableView>("Objects");
            List<GameObject> objects = new List<GameObject>
            {
                gameDataObject.Prefab.GetChild("Portion.001"),
                gameDataObject.Prefab.GetChild("Portion.002"),
                gameDataObject.Prefab.GetChild("Portion.003"),
                gameDataObject.Prefab.GetChild("Portion.004"),
                gameDataObject.Prefab.GetChild("Portion.005"),
                gameDataObject.Prefab.GetChild("Portion.006"),
                gameDataObject.Prefab.GetChild("Portion.007"),
                gameDataObject.Prefab.GetChild("Portion.008"),
            };
            objectsInfo.SetValue(objectsSplittableView, objects);
        }
    }
}