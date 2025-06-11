using System.Collections.Generic;
using CustomSettingsAndLayouts;
using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using ParentsEvent.Customs.RestaurantSettings.Decorators;
using ParentsEvent.Utilities;
using UnityEngine;

namespace ParentsEvent.Customs.RestaurantSettings
{
    public class FloristsSetting : CustomRestaurantSetting
    {
        public override string UniqueNameID => "FloristsSetting";
        public override WeatherMode WeatherMode => WeatherMode.None;

        public override List<IDecorationConfiguration> Decorators => new List<IDecorationConfiguration>
        {
            new FloristsSettingDecorator.DecorationsConfiguration
            {
                Cobblestone = GDOReferences.Cobblestone,
                Ground = GDOReferences.CountrysideGround,
                Pollen = GDOReferences.Pollen,
                FrontBorder = GDOReferences.LogWall,
                BorderSpacing = 1,
                Scatters = new List<FloristsSettingDecorator.DecorationsConfiguration.Scatter>
                {
                    new FloristsSettingDecorator.DecorationsConfiguration.Scatter
                    {
                        Appliance = GDOReferences.Grass1,
                        Probability = 0.1f/4
                    },
                    new FloristsSettingDecorator.DecorationsConfiguration.Scatter
                    {
                        Appliance = GDOReferences.Grass2,
                        Probability = 0.20f/4
                    },
                    new FloristsSettingDecorator.DecorationsConfiguration.Scatter
                    {
                        Appliance = GDOReferences.Grass3,
                        Probability = 0.25f/4
                    },
                    new FloristsSettingDecorator.DecorationsConfiguration.Scatter
                    {
                        Appliance = GDOReferences.Flowers1,
                        Probability = 0.10f/4
                    },
                    new FloristsSettingDecorator.DecorationsConfiguration.Scatter
                    {
                        Appliance = GDOReferences.Flowers2,
                        Probability = 0.10f/4
                    },
                    new FloristsSettingDecorator.DecorationsConfiguration.Scatter
                    {
                        Appliance = GDOReferences.Flowers3,
                        Probability = 0.10f/4
                    },
                }
            }
        };

        public override Unlock StartingUnlock => GDOReferences.DishFloristsFlowers;
        public override List<(Locale, BasicInfo)> InfoList => CenteralLang.RestaurantSettings.FloristsSetting;

        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("FloristsSnowglobe").AssignMaterialsByNames();
        public override bool AlwaysLight => true;


        public override void OnRegister(RestaurantSetting gameDataObject)
        {
            base.OnRegister(gameDataObject);
            Registry.GrantCustomSetting(gameDataObject);
        }
    }
}