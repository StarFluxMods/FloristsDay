using System.IO;
using KitchenLib;
using KitchenLib.Logging;
using KitchenLib.Logging.Exceptions;
using KitchenMods;
using System.Linq;
using System.Reflection;
using KitchenData;
using KitchenLib.Achievements;
using KitchenLib.Event;
using KitchenLib.Interfaces;
using KitchenLib.Preferences;
using KitchenLib.References;
using KitchenLib.UI.PlateUp.PreferenceMenus;
using ParentsEvent.Menus;
using ParentsEvent.Utilities;
using UnityEngine;

namespace ParentsEvent
{
    public class Mod : BaseMod, IModSystem, IAutoRegisterAll
    {
        public const string MOD_GUID = "com.starfluxgames.parentsday";
        public const string MOD_NAME = "Florist's Day";
        public const string MOD_VERSION = "0.2.2";
        public const string MOD_AUTHOR = "StarFluxGames";
        public const string MOD_GAMEVERSION = ">=1.2.1";

        public static AssetBundle Bundle;
        public static KitchenLogger Logger;
        public static PreferenceManager manager;
        internal static AchievementsManager achievementsManager;
        
        internal static readonly string ACHIEVEMENT_PICK_FLOWER_WITHING_HALF_SECOND = "ACHIEVEMENT_PICK_FLOWER_WITHING_HALF_SECOND";
        internal static readonly string ACHIEVEMENT_WRAP_20_GIFTS = "ACHIEVEMENT_WRAP_20_GIFTS";
        internal static readonly string ACHIEVEMENT_ROTTEN_BOUQUET = "ACHIEVEMENT_ROTTEN_BOUQUET";
        internal static readonly string ACHIEVEMENT_5_SPRINKLERS = "ACHIEVEMENT_5_SPRINKLERS";

        public static readonly string PREFERENCE_ENABLE_POLLEN = "PREFERENCE_ENABLE_POLLEN";
        public static readonly string PREFERENCE_ENABLE_LEGACY = "PREFERENCE_ENABLE_LEGACY";
        public static readonly string PREFERENCE_ENABLE_SPRINKLER_MIST = "PREFERENCE_ENABLE_SPRINKLER_MIST";
        public static readonly string PREFERENCE_HAS_SHOWN_MYSTERY_MEAT_WARNING = "PREFERENCE_HAS_SHOWN_MYSTERY_MEAT_WARNING";
        internal static readonly bool ENABLE_ADDITIONAL_LOBBY_DISHES = false;
        
        internal static bool IsMysteryMeatInstalled = false;

        public Mod() : base(MOD_GUID, MOD_NAME, MOD_AUTHOR, MOD_VERSION, MOD_GAMEVERSION, Assembly.GetExecutingAssembly())
        {
        }

        protected override void OnInitialise()
        {
            Logger.LogWarning($"{MOD_GUID} v{MOD_VERSION} in use!");
            GDOReferences.CardChildren.IsUnlockable = !IsMysteryMeatInstalled;
        }

        protected override void OnUpdate()
        {
        }

        protected override void OnPostActivate(KitchenMods.Mod mod)
        {
            Bundle = mod.GetPacks<AssetBundleModPack>().SelectMany(e => e.AssetBundles).FirstOrDefault() ?? throw new MissingAssetBundleException(MOD_GUID);
            Logger = InitLogger();
			
            manager = new PreferenceManager(MOD_GUID);
            manager.RegisterPreference(new PreferenceBool(PREFERENCE_ENABLE_POLLEN, true));
            manager.RegisterPreference(new PreferenceBool(PREFERENCE_ENABLE_LEGACY, false));
            manager.RegisterPreference(new PreferenceBool(PREFERENCE_ENABLE_SPRINKLER_MIST, true));
            manager.RegisterPreference(new PreferenceBool(PREFERENCE_HAS_SHOWN_MYSTERY_MEAT_WARNING, false));
            manager.Load();
            manager.Save();
            
            achievementsManager = new AchievementsManager(MOD_GUID, MOD_NAME);
            // achievementsManager.RegisterAchievement(new Achievement(ACHIEVEMENT_PICK_FLOWER_WITHING_HALF_SECOND, "Petal to the Metal", "Pick a flower within half a second of it blooming", Bundle.LoadAsset<Texture2D>("PetalToTheMetalIcon")));
            achievementsManager.RegisterAchievement(new Achievement(ACHIEVEMENT_WRAP_20_GIFTS, "Paper Cut", "Wrap 20 Gifts in a single run", Bundle.LoadAsset<Texture2D>("PaperCutIcon")));
            achievementsManager.RegisterAchievement(new Achievement(ACHIEVEMENT_ROTTEN_BOUQUET, "Rotten Bouquet", "Let 10 flowers wilt without harvesting", Bundle.LoadAsset<Texture2D>("WiltedFlowers")));
            achievementsManager.RegisterAchievement(new Achievement(ACHIEVEMENT_5_SPRINKLERS, "Aqua Overkill", "Run 5 Sprinklers at the same time in a single day", Bundle.LoadAsset<Texture2D>("AquaOverkillIcon")));

            achievementsManager.Load();
            achievementsManager.Save();
            
            MainMenuPreferencesesMenu.RegisterMenu(MOD_NAME, typeof(PreferencesMenus));
            PauseMenuPreferencesesMenu.RegisterMenu(MOD_NAME, typeof(PreferencesMenus));
            BasePreferencesMenu.RegisterUsableMenu(typeof(PreferencesMenus));

            // RefGenerator.GenerateGDOReferences(Assembly.GetExecutingAssembly(), Path.Combine(Application.persistentDataPath, "GeneratedReferences.cs"));
            
            foreach (KitchenMods.Mod loadedMod in ModPreload.Mods)
            {
                if (loadedMod.ID != 3350486642) continue;
                IsMysteryMeatInstalled = true;
                break;
            }

            Events.BuildGameDataEvent += (s, args) =>
            {
                if (args.firstBuild)
                {
                    // Assigns the Dedicated Provider for Vanilla Turkey Bones
                    if (args.gamedata.TryGet(ItemReferences.TurkeyBones, out Item TurkeyBones))
                    {
                        TurkeyBones.DedicatedProvider = GDOReferences.TurkeyBonesProvider;
                    }

                    // Blocks Individual Dining & Children
                    if (args.gamedata.TryGet(UnlockCardReferences.IndividualDining, out UnlockCard IndividualDining))
                    {
                        if (!IndividualDining.BlockedBy.Contains(GDOReferences.CardChildren))
                        {
                            IndividualDining.BlockedBy.Add(GDOReferences.CardChildren);
                        }
                    }
                    
                    // Blocks AllYouCanEat & Wrapped Gifts
                    if (args.gamedata.TryGet(UnlockCardReferences.AllYouCanEat, out UnlockCard AllYouCanEat))
                    {
                        if (!AllYouCanEat.BlockedBy.Contains(GDOReferences.DishWrappedGift))
                        {
                            AllYouCanEat.BlockedBy.Add(GDOReferences.DishWrappedGift);
                        }
                    }

                    if (args.gamedata.TryGet(ApplianceReferences.Countertop, out Appliance Countertop))
                    {
                        // Adding Processes to Florists Watering Can Provider
                        if (args.gamedata.TryGet(GDOReferences.FloristsWateringCanProvider.ID, out Appliance FloristsWateringCanProvider))
                        {
                            foreach (Appliance.ApplianceProcesses process in Countertop.Processes)
                            {
                                bool found = false;
                                foreach (Appliance.ApplianceProcesses process2 in FloristsWateringCanProvider.Processes)
                                {
                                    if (process.Process == process2.Process)
                                    {
                                        found = true;
                                        break;
                                    }
                                }

                                if (!found)
                                {
                                    FloristsWateringCanProvider.Processes.Add(process);
                                }
                            }
                        }
                        
                        // Adding Processes to Florists Watering Can Provider
                        if (args.gamedata.TryGet(GDOReferences.SmallSprinklerProvider.ID, out Appliance SmallSprinklerProvider))
                        {
                            foreach (Appliance.ApplianceProcesses process in Countertop.Processes)
                            {
                                bool found = false;
                                foreach (Appliance.ApplianceProcesses process2 in SmallSprinklerProvider.Processes)
                                {
                                    if (process.Process == process2.Process)
                                    {
                                        found = true;
                                        break;
                                    }
                                }

                                if (!found)
                                {
                                    SmallSprinklerProvider.Processes.Add(process);
                                }
                            }
                        }
                        
                        // Adding Processes to Legacy Watering Can Provider
                        if (args.gamedata.TryGet(GDOReferences.WateringCanProvider.ID, out Appliance WateringCanProvider))
                        {
                            foreach (Appliance.ApplianceProcesses process in Countertop.Processes)
                            {
                                bool found = false;
                                foreach (Appliance.ApplianceProcesses process2 in WateringCanProvider.Processes)
                                {
                                    if (process.Process == process2.Process)
                                    {
                                        found = true;
                                        break;
                                    }
                                }

                                if (!found)
                                {
                                    WateringCanProvider.Processes.Add(process);
                                }
                            }
                        }
                        
                        // Add Process to Chopped Nuts
                        if (args.gamedata.TryGet(GDOReferences.NutsChopped.ID, out Item NutsChopped))
                        {
                            bool found = false;
                            foreach (Item.ItemProcess process in NutsChopped.Processes)
                            {
                                if (process.Process == GDOReferences.Cook && process.Result == GDOReferences.RoastedNuts)
                                {
                                    found = true;
                                    break;
                                }
                            }
                            if (!found)
                            {
                                NutsChopped.Processes.Add(new Item.ItemProcess
                                {
                                    Process = GDOReferences.Cook,
                                    Result = GDOReferences.RoastedNuts,
                                    Duration = 1
                                });
                            }
                        }
                    }
                }
            };
        }
    }
}