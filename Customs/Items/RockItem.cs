using KitchenLib.Utils;
using ParentsEvent.Customs.Generics;
using UnityEngine;

namespace ParentsEvent.Customs.Items
{
    public class RockItem : GenericStackableItem
    {
        public override string UniqueNameID => "RockItem";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("RockItem").AssignMaterialsByNames();
        public override bool IsIndisposable => true;
    }
}