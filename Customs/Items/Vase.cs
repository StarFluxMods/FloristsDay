using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using ParentsEvent.Utilities;
using UnityEngine;

namespace ParentsEvent.Customs.Items
{
    public class Vase : CustomItem
    {
        public override string UniqueNameID => "Vase";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("FloristsVase").AssignMaterialsByNames();
        public override Appliance DedicatedProvider => GDOReferences.FloristsVaseProvider;
        public override bool IsIndisposable => true;
    }
}