using System.Collections.Generic;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using ParentsEvent.Components;
using ParentsEvent.Utilities;
using ParentsEvent.Views;
using UnityEngine;

namespace ParentsEvent.Customs.Items
{
    public class WateringCan : CustomItem
    {
        public override string UniqueNameID => "WateringCan";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("WateringCan").AssignMaterialsByNames();
        public override List<IItemProperty> Properties => new List<IItemProperty>
        {
            new CWateringCan()
        };

        public override Appliance DedicatedProvider => GDOReferences.FloristsWateringCanProvider;
        public override bool IsIndisposable => true;

        public override void OnRegister(Item gameDataObject)
        {
            base.OnRegister(gameDataObject);

            WateringCanView wateringCanView = gameDataObject.Prefab.AddComponent<WateringCanView>();
            wateringCanView.FilledWateringCan = gameDataObject.Prefab.GetChild("FilledWateringCan/Water");
        }
    }
}