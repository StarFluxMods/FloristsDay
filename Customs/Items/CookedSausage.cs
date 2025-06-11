using System.Collections.Generic;
using KitchenData;
using KitchenLib.Utils;
using ParentsEvent.Customs.Generics;
using ParentsEvent.Utilities;
using UnityEngine;

namespace ParentsEvent.Customs.Items
{
    public class CookedSausage : GenericStackableItem
    {
        public override string UniqueNameID => "CookedSausage";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("CookedSausage").AssignMaterialsByNames();
        public override List<Item.ItemProcess> Processes => new()
        {
            new Item.ItemProcess
            {
                Process = GDOReferences.Cook,
                Duration = 3,
                Result = GDOReferences.BurnedFood,
                IsBad = true
            }
        };
    }
}