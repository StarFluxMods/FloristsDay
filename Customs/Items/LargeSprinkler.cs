using System.Collections.Generic;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using ParentsEvent.Components;
using ParentsEvent.Enums;
using UnityEngine;

namespace ParentsEvent.Customs.Items
{
    public class LargeSprinkler : CustomItem
    {
        public override string UniqueNameID => "LargeSprinkler";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("SmallSprinkler").AssignMaterialsByNames();
        public override bool IsIndisposable => false;
        public override List<IItemProperty> Properties => new List<IItemProperty>
        {
            new CSprinkler
            {
                SprinklerType = SprinklerType.Large
            }
        };
    }
}