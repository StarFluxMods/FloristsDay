using KitchenLib.Utils;
using ParentsEvent.Customs.Generics;
using UnityEngine;

namespace ParentsEvent.Customs.Items
{
    public class ToyTruck : GenericStackableItem
    {
        public override string UniqueNameID => "ToyTruck";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("ToyTruck").AssignMaterialsByNames();
        public override bool IsIndisposable => true;
    }
}