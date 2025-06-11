using KitchenLib.Utils;
using ParentsEvent.Customs.Generics;
using UnityEngine;

namespace ParentsEvent.Customs.Items
{
    public class CookedPeas : GenericStackableItem
    {
        public override string UniqueNameID => "CookedPeas";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("CookedPeas").AssignMaterialsByNames();
    }
}