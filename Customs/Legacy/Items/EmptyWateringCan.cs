using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using ParentsEvent.Customs.Appliances;
using ParentsEvent.Utilities;
using UnityEngine;

namespace ParentsEvent.Customs.Items
{
    public class EmptyWateringCan : CustomItem
    {
        public override string UniqueNameID => "EmptyWateringCan";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("EmptyWateringCan").AssignMaterialsByNames();
        public override Appliance DedicatedProvider => GDOReferences.WateringCanProvider;
        public override bool IsIndisposable => true;
    }
}