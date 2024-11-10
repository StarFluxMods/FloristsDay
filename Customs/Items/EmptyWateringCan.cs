using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using ParentsEvent.Customs.Appliances;
using UnityEngine;

namespace ParentsEvent.Customs.Items
{
    public class EmptyWateringCan : CustomItem
    {
        public override string UniqueNameID => "EmptyWateringCan";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("EmptyWateringCan").AssignMaterialsByNames();
        public override Appliance DedicatedProvider => (Appliance)GDOUtils.GetCustomGameDataObject<WateringCanProvider>().GameDataObject;
        public override bool IsIndisposable => true;
    }
}