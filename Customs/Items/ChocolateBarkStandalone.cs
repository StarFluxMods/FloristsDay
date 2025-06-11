using System.Collections.Generic;
using KitchenData;
using KitchenLib.Utils;
using ParentsEvent.Customs.Generics;
using ParentsEvent.Utilities;
using UnityEngine;

namespace ParentsEvent.Customs.Items
{
    public class ChocolateBarkStandalone : GenericStackableItem
    {
        public override string UniqueNameID => "ChocolateBarkStandalone";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("ChocolateBarkStandalone").AssignMaterialsByNames();

        public override List<Item.ItemProcess> Processes => new()
        {
            new Item.ItemProcess
            {
                Process = GDOReferences.Chop,
                Duration = 1,
                Result = GDOReferences.ChocolateBarkChopped,
            }
        };
    }
}