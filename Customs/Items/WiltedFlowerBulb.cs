using System.Collections.Generic;
using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.References;
using KitchenLib.Utils;
using ParentsEvent.Components;
using ParentsEvent.Customs.Generics;
using ParentsEvent.Utilities;
using Unity.Collections;
using UnityEngine;

namespace ParentsEvent.Customs.Items
{
    public class WiltedFlowerBulb : CustomItem
    {
        public override string UniqueNameID => "WiltedFlowerBulb";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("WiltedFlowerBulb").AssignMaterialsByNames();
        public override List<IItemProperty> Properties => new List<IItemProperty>
        {
            new CWilted()
        };
    }
}