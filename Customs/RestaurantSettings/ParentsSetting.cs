using System.Collections.Generic;
using CustomSettingsAndLayouts;
using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.References;
using KitchenLib.Utils;
using ParentsEvent.Customs.Dishes;
using ParentsEvent.Utilities;
using UnityEngine;

namespace ParentsEvent.Customs.RestaurantSettings
{
    public class ParentsSetting : CustomRestaurantSetting
    {
        public override string UniqueNameID => "ParentsSetting";
        public override WeatherMode WeatherMode => WeatherMode.None;

        public override List<IDecorationConfiguration> Decorators => new List<IDecorationConfiguration>
        {
            new CountrysideDecorator.DecorationsConfiguration
            {
                Cobblestone = GDOReferences.Cobblestone,
                Ground = GDOReferences.CountrysideGround,
                FrontBorder = GDOReferences.LogWall,
                BorderSpacing = 1,
                Scatters = new List<CountrysideDecorator.DecorationsConfiguration.Scatter>
                {
                    new CountrysideDecorator.DecorationsConfiguration.Scatter
                    {
                        Appliance = GDOReferences.Tree,
                        Probability = 0.35f
                    },
                    new CountrysideDecorator.DecorationsConfiguration.Scatter
                    {
                        Appliance = GDOReferences.Rock,
                        Probability = 0.1f
                    }
                }
            }
        };

        public override UnlockPack UnlockPack { get; protected set; }
        public override Dish FixedDish => GDOReferences.FlowersDish;
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("Parents Icon").AssignMaterialsByNames();
        public override bool AlwaysLight => true;

        public override List<(Locale, BasicInfo)> InfoList => new List<(Locale, BasicInfo)>
        {
            (Locale.English, new BasicInfo
            {
                Name = "Parents"
            })
        };


        public override void OnRegister(RestaurantSetting gameDataObject)
        {
            base.OnRegister(gameDataObject);
            Registry.GrantCustomSetting(gameDataObject);
        }
    }
}