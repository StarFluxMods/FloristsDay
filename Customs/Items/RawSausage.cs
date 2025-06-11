using System.Collections.Generic;
using KitchenData;
using KitchenLib.Utils;
using ParentsEvent.Customs.Generics;
using ParentsEvent.Utilities;
using UnityEngine;

namespace ParentsEvent.Customs.Items
{
    public class RawSausage : GenericStackableItem
    {
        public override string UniqueNameID => "RawSausage";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("RawSausage").AssignMaterialsByNames();
        public override Appliance DedicatedProvider => GDOReferences.SausageProvider;

        public override List<Item.ItemProcess> Processes => new()
        {
            new Item.ItemProcess
            {
                Process = GDOReferences.Cook,
                Duration = 3,
                Result = GDOReferences.CookedSausage
            }
        };
    }
}