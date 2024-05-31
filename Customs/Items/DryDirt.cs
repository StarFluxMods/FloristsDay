using KitchenLib.Customs;
using UnityEngine;

namespace ParentsEvent.Customs.Items
{
    public class DryDirt : CustomItem
    {
        public override string UniqueNameID => "DryDirt";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("DryDirt");
    }
}