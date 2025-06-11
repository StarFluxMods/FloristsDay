using System.Collections.Generic;
using System.Reflection;
using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using ParentsEvent.Utilities;
using UnityEngine;

namespace ParentsEvent.Customs.ItemGroups
{
    public class BoxedFramedPhoto : CustomItemGroup
    {
        public override string UniqueNameID => "BoxedFramedPhoto";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("BoxedFramedPhoto").AssignMaterialsByNames();
        public override bool IsIndisposable => true;

        public override List<ItemGroup.ItemSet> Sets => new()
        {
            new ItemGroup.ItemSet
            {
                Items = new List<Item>
                {
                    GDOReferences.CardboardBox,
                    GDOReferences.FramedPhoto,
                },
                Min = 2,
                Max = 2,
            }
        };

        public override List<Item.ItemProcess> Processes => new()
        {
            new Item.ItemProcess
            {
                Process = GDOReferences.Knead,
                Duration = 1,
                Result = GDOReferences.WrappedFramedPhoto
            }
        };
    }
}