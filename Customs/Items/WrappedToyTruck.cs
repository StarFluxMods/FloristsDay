using System.Collections.Generic;
using KitchenData;
using KitchenLib.Utils;
using ParentsEvent.Components;
using ParentsEvent.Customs.Generics;
using ParentsEvent.Utilities;
using UnityEngine;

namespace ParentsEvent.Customs.Items
{
    public class WrappedToyTruck : GenericStackableItem
    {
        public override string UniqueNameID => "WrappedToyTruck";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("WrappedToyTruck").AssignMaterialsByNames();
        public override List<IItemProperty> Properties => new List<IItemProperty>
        {
            new CProvideBaseItem
            {
                BaseItem = GDOReferences.ToyTruck.ID
            },
            new CWrappedGift()
        };

        public override Factor EatingTime => 0;
        public override bool IsIndisposable => true;
        public override ItemValue ItemValue => ItemValue.SideSmall;
    }
}