using KitchenLib.Utils;
using ParentsEvent.Customs.Generics;
using UnityEngine;

namespace ParentsEvent.Customs.Items
{
    public class FramedPhoto : GenericStackableItem
    {
        public override string UniqueNameID => "FramedPhoto";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("FramedPhoto").AssignMaterialsByNames();
        public override bool IsIndisposable => true;
    }
}