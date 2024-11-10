using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using ParentsEvent.Customs.Appliances;
using Unity.Entities;
using UnityEngine;

namespace ParentsEvent.Customs.Items
{
    public class FlowerGreen : CustomItem
    {
        public override string UniqueNameID => "FlowerGreen";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("Flower Green").AssignMaterialsByNames();
        public override string ColourBlindTag => "O";
        public override ItemValue ItemValue => ItemValue.Medium;

        public override void OnRegister(Item gameDataObject)
        {
            base.OnRegister(gameDataObject);

            Transform t = gameDataObject.Prefab.transform.Find("Colour Blind").transform;
            t.position = new Vector3(t.position.x, t.position.y + 0.5f, t.position.z);
        }
    }
}