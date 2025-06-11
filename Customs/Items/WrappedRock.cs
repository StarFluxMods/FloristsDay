using System.Collections.Generic;
using KitchenData;
using KitchenLib.Utils;
using ParentsEvent.Components;
using ParentsEvent.Customs.Generics;
using ParentsEvent.Utilities;
using UnityEngine;

namespace ParentsEvent.Customs.Items
{
    public class WrappedRock : GenericStackableItem
    {
        public override string UniqueNameID => "WrappedRock";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("WrappedRock").AssignMaterialsByNames();
        public override List<IItemProperty> Properties => new List<IItemProperty>
        {
            new CProvideBaseItem
            {
                BaseItem = GDOReferences.RockItem.ID
            },
            new CWrappedGift()
        };

        public override Factor EatingTime => 0;
        public override bool IsIndisposable => true;
        public override ItemValue ItemValue => ItemValue.SideSmall;
    }
}