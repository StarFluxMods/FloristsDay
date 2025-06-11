using KitchenData;
using KitchenLib.Utils;
using ParentsEvent.Customs.Generics;
using ParentsEvent.Utilities;
using UnityEngine;

namespace ParentsEvent.Customs.Items
{
    public class RawPeas : GenericStackableItem
    {
        public override string UniqueNameID => "RawPeas";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("RawPeas").AssignMaterialsByNames();
        public override Appliance DedicatedProvider => GDOReferences.PeasProvider;
    }
}