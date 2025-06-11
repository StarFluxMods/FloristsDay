using System.Collections.Generic;
using KitchenData;
using KitchenLib.Utils;
using ParentsEvent.Customs.Generics;
using ParentsEvent.Utilities;
using UnityEngine;

namespace ParentsEvent.Customs.Items
{
    public class ChocolateBarkPortion : GenericStackableItem
    {
        public override string UniqueNameID => "ChocolateBarkPortion";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("ChocolateBarkPortion").AssignMaterialsByNames();
        public override ItemValue ItemValue => ItemValue.Small;
    }
}