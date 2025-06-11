using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using UnityEngine;

namespace ParentsEvent.Customs.Items
{
    public class FlowerRed : CustomItem
    {
        public override string UniqueNameID => "FlowerRed";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("Flower Red").AssignMaterialsByNames();
        public override string ColourBlindTag => "R";
        public override ItemValue ItemValue => ItemValue.Medium;

        public override void OnRegister(Item gameDataObject)
        {
            base.OnRegister(gameDataObject);

            Transform t = gameDataObject.Prefab.transform.Find("Colour Blind").transform;
            t.position = new Vector3(t.position.x, t.position.y + 0.5f, t.position.z);
        }
    }
}