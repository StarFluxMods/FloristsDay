using KitchenData;
using KitchenLib.References;
using KitchenLib.Utils;
using ParentsEvent.Customs.Appliances;
using ParentsEvent.Customs.Appliances.SceneAppliances;
using ParentsEvent.Customs.Dishes;
using ParentsEvent.Customs.ItemGroups;
using ParentsEvent.Customs.Items;
using ParentsEvent.Customs.LayoutProfiles;
using ParentsEvent.Customs.PlayerCosmetics;
using ParentsEvent.Customs.Processes;
using ParentsEvent.Customs.RestaurantSettings;
using ParentsEvent.Customs.UnlockCard;

namespace ParentsEvent.Utilities
{
    public class GDOReferences
    {
        #region Vanilla

        #region Item

        public static Item Chocolate => (Item)GDOUtils.GetExistingGDO(ItemReferences.Chocolate);
        public static Item Water => (Item)GDOUtils.GetExistingGDO(ItemReferences.Water);
        public static Item NutsIngredient => (Item)GDOUtils.GetExistingGDO(ItemReferences.NutsIngredient);
        public static Item Sugar => (Item)GDOUtils.GetExistingGDO(ItemReferences.Sugar);
        public static Item Pot => (Item)GDOUtils.GetExistingGDO(ItemReferences.Pot);
        public static Item Onion => (Item)GDOUtils.GetExistingGDO(ItemReferences.Onion);
        public static Item PlateDirty => (Item)GDOUtils.GetExistingGDO(ItemReferences.PlateDirty);
        public static Item Plate => (Item)GDOUtils.GetExistingGDO(ItemReferences.Plate);
        public static Item BoiledPotatoServing => (Item)GDOUtils.GetExistingGDO(ItemReferences.BoiledPotatoServing);
        public static Item Potato => (Item)GDOUtils.GetExistingGDO(ItemReferences.Potato);
        public static Item TurkeyGravy => (Item)GDOUtils.GetExistingGDO(ItemReferences.TurkeyGravy);
        public static Item BurnedFood => (Item)GDOUtils.GetExistingGDO(ItemReferences.BurnedFood);
        public static Item TurkeyBones => (Item)GDOUtils.GetExistingGDO(ItemReferences.TurkeyBones);
        public static Item Mushroom => (Item)GDOUtils.GetExistingGDO(ItemReferences.Mushroom);
        public static Item CheeseGrated => (Item)GDOUtils.GetExistingGDO(ItemReferences.CheeseGrated);
        public static Item Cheese => (Item)GDOUtils.GetExistingGDO(ItemReferences.Cheese);
        public static Item CookieTray => (Item)GDOUtils.GetExistingGDO(ItemReferences.CookieTray);
        public static Item ChocolateMelted => (Item)GDOUtils.GetExistingGDO(ItemReferences.ChocolateMelted);
        public static Item NutsChopped => (Item)GDOUtils.GetExistingGDO(ItemReferences.NutsChopped);

        #endregion

        #region LayoutProfile

        public static LayoutProfile DinerLayout => (LayoutProfile)GDOUtils.GetExistingGDO(LayoutProfileReferences.DinerLayout);

        #endregion

        #region Appliance

        public static Appliance Cobblestone => (Appliance)GDOUtils.GetExistingGDO(ApplianceReferences.Cobblestone);
        public static Appliance CountrysideGround => (Appliance)GDOUtils.GetExistingGDO(ApplianceReferences.CountrysideGround);
        public static Appliance LogWall => (Appliance)GDOUtils.GetExistingGDO(ApplianceReferences.LogWall);
        public static Appliance Tree => (Appliance)GDOUtils.GetExistingGDO(ApplianceReferences.Tree);
        public static Appliance Rock => (Appliance)GDOUtils.GetExistingGDO(ApplianceReferences.Rock);

        #endregion

        #region Process

        public static Process Chop => (Process)GDOUtils.GetExistingGDO(ProcessReferences.Chop);
        public static Process Cook => (Process)GDOUtils.GetExistingGDO(ProcessReferences.Cook);
        public static Process Clean => (Process)GDOUtils.GetExistingGDO(ProcessReferences.Clean);
        public static Process SteepTea => (Process)GDOUtils.GetExistingGDO(ProcessReferences.SteepTea);
        public static Process Knead => (Process)GDOUtils.GetExistingGDO(ProcessReferences.Knead);

        #endregion

        #region UnlockCard

        public static UnlockCard IndividualDining => (UnlockCard)GDOUtils.GetExistingGDO(UnlockCardReferences.IndividualDining);
        public static UnlockCard AllYouCanEat => (UnlockCard)GDOUtils.GetExistingGDO(UnlockCardReferences.AllYouCanEat);

        #endregion

        #region Dish

        public static Dish MashedPotato => (Dish)GDOUtils.GetExistingGDO(DishReferences.MashedPotato);
        public static Dish DishTurkeyGravy => (Dish)GDOUtils.GetExistingGDO(DishReferences.TurkeyGravy);

        #endregion

        #endregion

        #region UnlockCard

        public static UnlockCard CardChildren => (UnlockCard)GDOUtils.GetCustomGameDataObject<CardChildren>().GameDataObject;
        public static UnlockCard CardFlowerWiltering => (UnlockCard)GDOUtils.GetCustomGameDataObject<CardFlowerWiltering>().GameDataObject;

        #endregion

        #region Process

        public static Process DummySplit => (Process)GDOUtils.GetCustomGameDataObject<DummySplit>().GameDataObject;

        #endregion

        #region PlayerCosmetic

        public static PlayerCosmetic GnomeHat => (PlayerCosmetic)GDOUtils.GetCustomGameDataObject<GnomeHat>().GameDataObject;
        public static PlayerCosmetic Overalls => (PlayerCosmetic)GDOUtils.GetCustomGameDataObject<Overalls>().GameDataObject;
        public static PlayerCosmetic SunflowerHat => (PlayerCosmetic)GDOUtils.GetCustomGameDataObject<SunflowerHat>().GameDataObject;

        #endregion

        #region RestaurantSetting

        public static RestaurantSetting ParentsSetting => (RestaurantSetting)GDOUtils.GetCustomGameDataObject<ParentsSetting>().GameDataObject;
        public static RestaurantSetting FloristsSetting => (RestaurantSetting)GDOUtils.GetCustomGameDataObject<FloristsSetting>().GameDataObject;

        #endregion

        #region LayoutProfile

        public static LayoutProfile FloristsLayout => (LayoutProfile)GDOUtils.GetCustomGameDataObject<FloristsLayout>().GameDataObject;
        public static LayoutProfile ParentsLayout => (LayoutProfile)GDOUtils.GetCustomGameDataObject<ParentsLayout>().GameDataObject;

        #endregion

        #region Item

        public static Item BlueFlower => (Item)GDOUtils.GetCustomGameDataObject<BlueFlower>().GameDataObject;
        public static Item BluePetals => (Item)GDOUtils.GetCustomGameDataObject<BluePetals>().GameDataObject;
        public static Item BluePetalSoup => (Item)GDOUtils.GetCustomGameDataObject<BluePetalSoup>().GameDataObject;
        public static Item CardboardBox => (Item)GDOUtils.GetCustomGameDataObject<CardboardBox>().GameDataObject;
        public static Item ChocolateBarkChilled => (Item)GDOUtils.GetCustomGameDataObject<ChocolateBarkChilled>().GameDataObject;
        public static Item ChocolateBarkChopped => (Item)GDOUtils.GetCustomGameDataObject<ChocolateBarkChopped>().GameDataObject;
        public static Item ChocolateBarkPortion => (Item)GDOUtils.GetCustomGameDataObject<ChocolateBarkPortion>().GameDataObject;
        public static Item ChocolateBarkStandalone => (Item)GDOUtils.GetCustomGameDataObject<ChocolateBarkStandalone>().GameDataObject;
        public static Item CookedBluePetals => (Item)GDOUtils.GetCustomGameDataObject<CookedBluePetals>().GameDataObject;
        public static Item CookedOrangePetals => (Item)GDOUtils.GetCustomGameDataObject<CookedOrangePetals>().GameDataObject;
        public static Item CookedPeas => (Item)GDOUtils.GetCustomGameDataObject<CookedPeas>().GameDataObject;
        public static Item CookedPeasPot => (Item)GDOUtils.GetCustomGameDataObject<CookedPeasPot>().GameDataObject;
        public static Item CookedPinkPetals => (Item)GDOUtils.GetCustomGameDataObject<CookedPinkPetals>().GameDataObject;
        public static Item CookedSausage => (Item)GDOUtils.GetCustomGameDataObject<CookedSausage>().GameDataObject;
        public static Item FlowerBulb => (Item)GDOUtils.GetCustomGameDataObject<FlowerBulb>().GameDataObject;
        public static Item FramedPhoto => (Item)GDOUtils.GetCustomGameDataObject<FramedPhoto>().GameDataObject;
        public static Item LargeSprinkler => (Item)GDOUtils.GetCustomGameDataObject<LargeSprinkler>().GameDataObject;
        public static Item OrangeFlower => (Item)GDOUtils.GetCustomGameDataObject<OrangeFlower>().GameDataObject;
        public static Item OrangePetals => (Item)GDOUtils.GetCustomGameDataObject<OrangePetals>().GameDataObject;
        public static Item OrangePetalSoup => (Item)GDOUtils.GetCustomGameDataObject<OrangePetalSoup>().GameDataObject;
        public static Item PinkFlower => (Item)GDOUtils.GetCustomGameDataObject<PinkFlower>().GameDataObject;
        public static Item PinkPetals => (Item)GDOUtils.GetCustomGameDataObject<PinkPetals>().GameDataObject;
        public static Item PinkPetalSoup => (Item)GDOUtils.GetCustomGameDataObject<PinkPetalSoup>().GameDataObject;
        public static Item RawPeas => (Item)GDOUtils.GetCustomGameDataObject<RawPeas>().GameDataObject;
        public static Item RawSausage => (Item)GDOUtils.GetCustomGameDataObject<RawSausage>().GameDataObject;
        public static Item RockItem => (Item)GDOUtils.GetCustomGameDataObject<RockItem>().GameDataObject;
        public static Item SmallSprinkler => (Item)GDOUtils.GetCustomGameDataObject<SmallSprinkler>().GameDataObject;
        public static Item ToyTruck => (Item)GDOUtils.GetCustomGameDataObject<ToyTruck>().GameDataObject;
        public static Item Vase => (Item)GDOUtils.GetCustomGameDataObject<Vase>().GameDataObject;
        public static Item WateringCan => (Item)GDOUtils.GetCustomGameDataObject<WateringCan>().GameDataObject;
        public static Item WiltedFlower => (Item)GDOUtils.GetCustomGameDataObject<WiltedFlower>().GameDataObject;
        public static Item WiltedFlowerBulb => (Item)GDOUtils.GetCustomGameDataObject<WiltedFlowerBulb>().GameDataObject;
        public static Item WrappedFramedPhoto => (Item)GDOUtils.GetCustomGameDataObject<WrappedFramedPhoto>().GameDataObject;
        public static Item WrappedRock => (Item)GDOUtils.GetCustomGameDataObject<WrappedRock>().GameDataObject;
        public static Item WrappedToyTruck => (Item)GDOUtils.GetCustomGameDataObject<WrappedToyTruck>().GameDataObject;
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

        public static ItemGroup BoxedFramedPhoto => (ItemGroup)GDOUtils.GetCustomGameDataObject<BoxedFramedPhoto>().GameDataObject;
        public static ItemGroup BoxedRock => (ItemGroup)GDOUtils.GetCustomGameDataObject<BoxedRock>().GameDataObject;
        public static ItemGroup BoxedToyTruck => (ItemGroup)GDOUtils.GetCustomGameDataObject<BoxedToyTruck>().GameDataObject;
        public static ItemGroup ChocolateBarkRaw => (ItemGroup)GDOUtils.GetCustomGameDataObject<ChocolateBarkRaw>().GameDataObject;
        public static ItemGroup FloristsVase => (ItemGroup)GDOUtils.GetCustomGameDataObject<FloristsVase>().GameDataObject;
        public static ItemGroup PlatedSausage => (ItemGroup)GDOUtils.GetCustomGameDataObject<PlatedSausage>().GameDataObject;
        public static ItemGroup PottedBluePetals => (ItemGroup)GDOUtils.GetCustomGameDataObject<PottedBluePetals>().GameDataObject;
        public static ItemGroup PottedOrangePetals => (ItemGroup)GDOUtils.GetCustomGameDataObject<PottedOrangePetals>().GameDataObject;
        public static ItemGroup PottedPeas => (ItemGroup)GDOUtils.GetCustomGameDataObject<PottedPeas>().GameDataObject;
        public static ItemGroup PottedPinkPetals => (ItemGroup)GDOUtils.GetCustomGameDataObject<PottedPinkPetals>().GameDataObject;
        public static ItemGroup StuffedMushroom => (ItemGroup)GDOUtils.GetCustomGameDataObject<StuffedMushroom>().GameDataObject;
        public static ItemGroup FilledWateringCan => (ItemGroup)GDOUtils.GetCustomGameDataObject<FilledWateringCan>().GameDataObject;
        public static ItemGroup FlowerVase => (ItemGroup)GDOUtils.GetCustomGameDataObject<FlowerVase>().GameDataObject;
        public static ItemGroup UnrolledAlmondDessert => (ItemGroup)GDOUtils.GetCustomGameDataObject<UnrolledAlmondDessert>().GameDataObject;
        public static ItemGroup WetDirt => (ItemGroup)GDOUtils.GetCustomGameDataObject<WetDirt>().GameDataObject;

        #endregion

        #region Dish

        public static Dish DishBangersAndMash => (Dish)GDOUtils.GetCustomGameDataObject<DishBangersAndMash>().GameDataObject;
        public static Dish DishBangersAndMashGravy => (Dish)GDOUtils.GetCustomGameDataObject<DishBangersAndMashGravy>().GameDataObject;
        public static Dish DishBangersAndMashPeas => (Dish)GDOUtils.GetCustomGameDataObject<DishBangersAndMashPeas>().GameDataObject;
        public static Dish DishChocolateBark => (Dish)GDOUtils.GetCustomGameDataObject<DishChocolateBark>().GameDataObject;
        public static Dish DishFloristsFlowers => (Dish)GDOUtils.GetCustomGameDataObject<DishFloristsFlowers>().GameDataObject;
        public static Dish DishPetalSoup => (Dish)GDOUtils.GetCustomGameDataObject<DishPetalSoup>().GameDataObject;
        public static Dish DishStuffedMushroom => (Dish)GDOUtils.GetCustomGameDataObject<DishStuffedMushroom>().GameDataObject;
        public static Dish DishWrappedGift => (Dish)GDOUtils.GetCustomGameDataObject<DishWrappedGift>().GameDataObject;
        public static Dish FlowersDish => (Dish)GDOUtils.GetCustomGameDataObject<FlowersDish>().GameDataObject;
        public static Dish RolledAlmondDessertDish => (Dish)GDOUtils.GetCustomGameDataObject<RolledAlmondDessertDish>().GameDataObject;

        #endregion

        #region Appliance

        public static Appliance BeeHive => (Appliance)GDOUtils.GetCustomGameDataObject<BeeHive>().GameDataObject;
        public static Appliance CardboardBoxProvider => (Appliance)GDOUtils.GetCustomGameDataObject<CardboardBoxProvider>().GameDataObject;
        public static Appliance Farmland => (Appliance)GDOUtils.GetCustomGameDataObject<Farmland>().GameDataObject;
        public static Appliance FloristsVaseProvider => (Appliance)GDOUtils.GetCustomGameDataObject<FloristsVaseProvider>().GameDataObject;
        public static Appliance FloristsWateringCanProvider => (Appliance)GDOUtils.GetCustomGameDataObject<FloristsWateringCanProvider>().GameDataObject;
        public static Appliance FlowerGrowthChart => (Appliance)GDOUtils.GetCustomGameDataObject<FlowerGrowthChart>().GameDataObject;
        public static Appliance FlowerRug => (Appliance)GDOUtils.GetCustomGameDataObject<FlowerRug>().GameDataObject;
        public static Appliance GardenGnome => (Appliance)GDOUtils.GetCustomGameDataObject<GardenGnome>().GameDataObject;
        public static Appliance MossyLog => (Appliance)GDOUtils.GetCustomGameDataObject<MossyLog>().GameDataObject;
        public static Appliance PeasProvider => (Appliance)GDOUtils.GetCustomGameDataObject<PeasProvider>().GameDataObject;
        public static Appliance PressedFlowerFrame => (Appliance)GDOUtils.GetCustomGameDataObject<PressedFlowerFrame>().GameDataObject;
        public static Appliance SausageProvider => (Appliance)GDOUtils.GetCustomGameDataObject<SausageProvider>().GameDataObject;
        public static Appliance SmallSprinklerProvider => (Appliance)GDOUtils.GetCustomGameDataObject<SmallSprinklerProvider>().GameDataObject;
        public static Appliance TurkeyBonesProvider => (Appliance)GDOUtils.GetCustomGameDataObject<TurkeyBonesProvider>().GameDataObject;
        public static Appliance DirtPatch => (Appliance)GDOUtils.GetCustomGameDataObject<DirtPatch>().GameDataObject;
        public static Appliance FlowerPot => (Appliance)GDOUtils.GetCustomGameDataObject<FlowerPot>().GameDataObject;
        public static Appliance VaseProvider => (Appliance)GDOUtils.GetCustomGameDataObject<VaseProvider>().GameDataObject;
        public static Appliance WateringCanProvider => (Appliance)GDOUtils.GetCustomGameDataObject<WateringCanProvider>().GameDataObject;
        public static Appliance Flowers1 => (Appliance)GDOUtils.GetCustomGameDataObject<Flowers1>().GameDataObject;
        public static Appliance Flowers2 => (Appliance)GDOUtils.GetCustomGameDataObject<Flowers2>().GameDataObject;
        public static Appliance Flowers3 => (Appliance)GDOUtils.GetCustomGameDataObject<Flowers3>().GameDataObject;
        public static Appliance Grass1 => (Appliance)GDOUtils.GetCustomGameDataObject<Grass1>().GameDataObject;
        public static Appliance Grass2 => (Appliance)GDOUtils.GetCustomGameDataObject<Grass2>().GameDataObject;
        public static Appliance Grass3 => (Appliance)GDOUtils.GetCustomGameDataObject<Grass3>().GameDataObject;
        public static Appliance Pollen => (Appliance)GDOUtils.GetCustomGameDataObject<Pollen>().GameDataObject;

        #endregion
    }
}