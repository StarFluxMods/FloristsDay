using KitchenData;
using KitchenLib.Utils;
using ParentsEvent.Customs.Generics;
using ParentsEvent.Utilities;
using UnityEngine;

namespace ParentsEvent.Customs.Items
{
    public class CardboardBox : GenericStackableItem
    {
        public override string UniqueNameID => "CardboardBox";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("CardboardBox").AssignMaterialsByNames();
        public override Appliance DedicatedProvider => GDOReferences.CardboardBoxProvider;
    }
}