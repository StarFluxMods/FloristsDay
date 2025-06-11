using KitchenLib.Customs;
using KitchenLib.Utils;
using UnityEngine;

namespace ParentsEvent.Customs.Items
{
    public class RoastedNuts : CustomItem
    {
        public override string UniqueNameID => "RoastedNuts";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("RoastedNuts").AssignMaterialsByNames();
    }
}