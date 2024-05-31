using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using ParentsEvent.Customs.Appliances;
using UnityEngine;

namespace ParentsEvent.Customs.Items
{
    public class EmptyVase : CustomItem
    {
        public override string UniqueNameID => "EmptyVase";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("Empty Vase").AssignMaterialsByNames();
        public override Appliance DedicatedProvider => (Appliance)GDOUtils.GetCustomGameDataObject<VaseProvider>().GameDataObject;
        public override bool IsIndisposable => false;
    }
}