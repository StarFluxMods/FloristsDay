
using System.Collections.Generic;
using CsvHelper;
using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using ParentsEvent.Customs.Generics;
using ParentsEvent.Utilities;
using UnityEngine;

namespace ParentsEvent.Customs.Appliances
{
    public class TurkeyBonesProvider : GenericProvider
    {
        public override string UniqueNameID => "TurkeyBonesProvider";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("TurkeyBonesProvider").AssignMaterialsByNames();
        public override Item ProvidedItem => GDOReferences.TurkeyBones;
        public override List<(Locale, ApplianceInfo)> InfoList => CenteralLang.Appliances.TurkeyBonesProvider;
    }
}