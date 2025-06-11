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
    public class CardboardBoxProvider : GenericProvider
    {
        public override string UniqueNameID => "CardboardBoxProvider";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("CardboardBoxProvider").AssignMaterialsByNames();
        public override Item ProvidedItem => GDOReferences.CardboardBox;
        public override List<(Locale, ApplianceInfo)> InfoList => CenteralLang.Appliances.CardboardBoxProvider;
    }
}