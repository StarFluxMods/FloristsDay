using KitchenData;
using KitchenLib.Utils;
using ParentsEvent.Customs.Appliances;
using ParentsEvent.Customs.Dishes;
using ParentsEvent.Customs.ItemGroups;
using ParentsEvent.Customs.Items;
using ParentsEvent.Customs.LayoutProfiles;
using ParentsEvent.Customs.RestaurantSettings;

namespace ParentsEvent.Utilities
{
    public class GDOReferences
    {
        #region Vanilla

        

        #endregion
        
        #region RestaurantSetting
public static RestaurantSetting ParentsSetting => (RestaurantSetting)GDOUtils.GetCustomGameDataObject<ParentsSetting>().GameDataObject;
#endregion

public static LayoutProfile ParentsLayout => (LayoutProfile)GDOUtils.GetCustomGameDataObject<ParentsLayout>().GameDataObject;
#endregion

#region Item
public static Item DryDirt => (Item)GDOUtils.GetCustomGameDataObject<DryDirt>().GameDataObject;
public static Item EmptyVase => (Item)GDOUtils.GetCustomGameDataObject<EmptyVase>().GameDataObject;
public static Item EmptyWateringCan => (Item)GDOUtils.GetCustomGameDataObject<EmptyWateringCan>().GameDataObject;
public static Item FlowerBlue => (Item)GDOUtils.GetCustomGameDataObject<FlowerBlue>().GameDataObject;
public static Item FlowerGreen => (Item)GDOUtils.GetCustomGameDataObject<FlowerGreen>().GameDataObject;
public static Item FlowerRed => (Item)GDOUtils.GetCustomGameDataObject<FlowerRed>().GameDataObject;
public static Item RoastedNuts => (Item)GDOUtils.GetCustomGameDataObject<RoastedNuts>().GameDataObject;
public static Item RolledAlmondDessert => (Item)GDOUtils.GetCustomGameDataObject<RolledAlmondDessert>().GameDataObject;
#endregion

#region ItemGroup
public static ItemGroup FilledWateringCan => (ItemGroup)GDOUtils.GetCustomGameDataObject<FilledWateringCan>().GameDataObject;
public static ItemGroup FlowerVase => (ItemGroup)GDOUtils.GetCustomGameDataObject<FlowerVase>().GameDataObject;
public static ItemGroup UnrolledAlmondDessert => (ItemGroup)GDOUtils.GetCustomGameDataObject<UnrolledAlmondDessert>().GameDataObject;
public static ItemGroup WetDirt => (ItemGroup)GDOUtils.GetCustomGameDataObject<WetDirt>().GameDataObject;
#endregion

#region Dish
public static Dish FlowersDish => (Dish)GDOUtils.GetCustomGameDataObject<FlowersDish>().GameDataObject;
public static Dish RolledAlmondDessertDish => (Dish)GDOUtils.GetCustomGameDataObject<RolledAlmondDessertDish>().GameDataObject;
#endregion

#region Appliance
public static Appliance VaseProvider => (Appliance)GDOUtils.GetCustomGameDataObject<VaseProvider>().GameDataObject;
public static Appliance WateringCanProvider => (Appliance)GDOUtils.GetCustomGameDataObject<WateringCanProvider>().GameDataObject;
#endregion


    }
}