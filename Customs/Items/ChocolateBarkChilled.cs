using System.Collections.Generic;
using KitchenData;
using KitchenLib.Utils;
using ParentsEvent.Customs.Generics;
using ParentsEvent.Utilities;
using UnityEngine;

namespace ParentsEvent.Customs.Items
{
    public class ChocolateBarkChilled : GenericStackableItem
    {
        public override string UniqueNameID => "ChocolateBarkChilled";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("ChocolateBarkChilled").AssignMaterialsByNames();
        public override int SplitCount => 1;

        public override List<Item> SplitDepletedItems => new()
        {
            GDOReferences.CookieTray
        };

        public override Item SplitSubItem => GDOReferences.ChocolateBarkStandalone;
    }
}