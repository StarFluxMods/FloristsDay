using System.Collections.Generic;
using CustomSettingsAndLayouts;
using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.References;
using KitchenLib.Utils;
using ParentsEvent.Customs.Dishes;
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
                Cobblestone = (Appliance)GDOUtils.GetExistingGDO(ApplianceReferences.Cobblestone),
                Ground = (Appliance)GDOUtils.GetExistingGDO(ApplianceReferences.CountrysideGround),
                FrontBorder = (Appliance)GDOUtils.GetExistingGDO(ApplianceReferences.LogWall),
                BorderSpacing = 1,
                Scatters = new List<CountrysideDecorator.DecorationsConfiguration.Scatter>
                {
                    new CountrysideDecorator.DecorationsConfiguration.Scatter
                    {
                        Appliance = (Appliance)GDOUtils.GetExistingGDO(ApplianceReferences.Tree),
                        Probability = 0.35f
                    },
                    new CountrysideDecorator.DecorationsConfiguration.Scatter
                    {
                        Appliance = (Appliance)GDOUtils.GetExistingGDO(ApplianceReferences.Rock),
                        Probability = 0.1f
                    }
                }
            }
        };

        public override UnlockPack UnlockPack { get; protected set; }
        public override Dish FixedDish => (Dish)GDOUtils.GetCustomGameDataObject<FlowersDish>().GameDataObject;
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