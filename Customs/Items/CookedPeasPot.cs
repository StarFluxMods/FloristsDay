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
    public class CookedPeasPot : CustomItem
    {
        public override string UniqueNameID => "CookedPeasPot";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("CookedPeasPot").AssignMaterialsByNames();
        public override int SplitCount => 4;

        public override List<Item> SplitDepletedItems => new()
        {
            GDOReferences.Pot
        };

        public override Item SplitSubItem => GDOReferences.CookedPeas;
    }
}