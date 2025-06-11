using System.Collections.Generic;
using KitchenData;
using ParentsEvent.Components;
using UnityEngine;

namespace ParentsEvent.Customs.Generics
{
    public abstract class GenericFlower : GenericStackableItem
    {
        public override ItemValue ItemValue => ItemValue.Medium;

        public override List<IItemProperty> Properties => new List<IItemProperty>
        {
            new CFlower()
        };

        public override void OnRegister(Item gameDataObject)
        {
            base.OnRegister(gameDataObject);

            Transform t = gameDataObject.Prefab.transform.Find("Colour Blind").transform;
            t.position = new Vector3(t.position.x, t.position.y + 0.5f, t.position.z);
        }
    }
}