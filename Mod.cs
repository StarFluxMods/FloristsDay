using KitchenLib;
using KitchenLib.Logging;
using KitchenLib.Logging.Exceptions;
using KitchenMods;
using System.Linq;
using System.Reflection;
using KitchenData;
using KitchenLib.Event;
using KitchenLib.Interfaces;
using KitchenLib.References;
using KitchenLib.Utils;
using ParentsEvent.Customs.Appliances;
using ParentsEvent.Customs.Items;
using UnityEngine;

namespace ParentsEvent
{
    public class Mod : BaseMod, IModSystem, IAutoRegisterAll
    {
        public const string MOD_GUID = "com.starfluxgames.parentsday";
        public const string MOD_NAME = "Florist's Day";
        public const string MOD_VERSION = "0.1.1";
        public const string MOD_AUTHOR = "StarFluxGames";
        public const string MOD_GAMEVERSION = ">=1.1.7";

        public static AssetBundle Bundle;
        public static KitchenLogger Logger;

        public Mod() : base(MOD_GUID, MOD_NAME, MOD_AUTHOR, MOD_VERSION, MOD_GAMEVERSION, Assembly.GetExecutingAssembly())
        {
        }

        protected override void OnInitialise()
        {
            Logger.LogWarning($"{MOD_GUID} v{MOD_VERSION} in use!");
        }

        protected override void OnUpdate()
        {
        }

        protected override void OnPostActivate(KitchenMods.Mod mod)
        {
            Bundle = mod.GetPacks<AssetBundleModPack>().SelectMany(e => e.AssetBundles).FirstOrDefault() ?? throw new MissingAssetBundleException(MOD_GUID);
            Logger = InitLogger();

            Events.BuildGameDataEvent += (s, args) =>
            {
                Appliance wateringCanProvider = (Appliance)GDOUtils.GetCustomGameDataObject<WateringCanProvider>().GameDataObject;
                Appliance counter = args.gamedata.Get<Appliance>(ApplianceReferences.Countertop);
                foreach (Appliance.ApplianceProcesses process in counter.Processes)
                {
                    wateringCanProvider.Processes.Add(process);
                }

                args.gamedata.Get<Item>(ItemReferences.NutsChopped).DerivedProcesses.Add(new Item.ItemProcess
                {
                    Process = args.gamedata.Get<Process>(ProcessReferences.Cook),
                    Duration = 2,
                    Result = (Item)GDOUtils.GetCustomGameDataObject<RoastedNuts>().GameDataObject
                });
            };
        }
    }
}