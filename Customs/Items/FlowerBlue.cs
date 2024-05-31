using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using UnityEngine;

namespace ParentsEvent.Customs.Items
{
    public class FlowerBlue : CustomItem
    {
        public override string UniqueNameID => "FlowerBlue";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("Flower Blue").AssignMaterialsByNames();
        public override string ColourBlindTag => "B";

        public override void OnRegister(Item gameDataObject)
        {
            base.OnRegister(gameDataObject);

            Transform t = gameDataObject.Prefab.transform.Find("Colour Blind").transform;
            t.position = new Vector3(t.position.x, t.position.y + 0.5f, t.position.z);
        }
    }
}