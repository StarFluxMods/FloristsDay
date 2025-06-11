using System.Collections.Generic;
using Kitchen;
using KitchenLib.Preferences;
using KitchenMods;
using MessagePack;
using ParentsEvent.Components;
using ParentsEvent.Enums;
using ParentsEvent.Views.Local;
using TMPro;
using Unity.Collections;
using Unity.Entities;
using UnityEngine;

namespace ParentsEvent.Views
{
    public class FarmlandView : UpdatableObjectView<FarmlandView.ViewData>
    {
        public class UpdateView : IncrementalViewSystemBase<ViewData>, IModSystem
        {
            private EntityQuery Views;

            protected override void Initialise()
            {
                base.Initialise();

                Views = GetEntityQuery(new QueryHelper().All(typeof(CFarmland), typeof(CLinkedView)));
            }

            protected override void OnUpdate()
            {
                using (NativeArray<Entity> farmlands = Views.ToEntityArray(Allocator.Temp))
                {
                    foreach (Entity farmland in farmlands)
                    {
                        if (Require(farmland, out CFarmland cFarmland) && Require(farmland, out CLinkedView cLinkedView))
                        {
                            SendUpdate(cLinkedView, new ViewData
                            {
                                IsWet = cFarmland.TimeUntilDry != 0,
                                TimeUntilDry = cFarmland.TimeUntilDry,
                                RandomState = cFarmland.RandomState,
                                SprinklerType = cFarmland.SprinklerType,
                            });
                        }
                    }
                }
            }
        }

        [MessagePackObject(false)]
        public struct ViewData : ISpecificViewData, IViewData.ICheckForChanges<ViewData>
        {
            [Key(1)] public bool IsWet;
            [Key(2)] public float TimeUntilDry;
            [Key(3)] public float TimeUntilNextGrowthStage;
            [Key(4)] public int RandomState;
            [Key(5)] public SprinklerType SprinklerType;

            public IUpdatableObject GetRelevantSubview(IObjectView view) => view.GetSubView<FarmlandView>();

            public bool IsChangedFrom(ViewData cached)
            {
                return IsWet != cached.IsWet || !Mathf.Approximately(TimeUntilDry, cached.TimeUntilDry) || !Mathf.Approximately(TimeUntilNextGrowthStage, cached.TimeUntilNextGrowthStage) || RandomState != cached.RandomState || SprinklerType != cached.SprinklerType;
            }
        }

        private int CachedRandomState;
        protected override void UpdateData(ViewData view_data)
        {
            WetFarmland.SetActive(view_data.IsWet);
            DryFarmland.SetActive(!view_data.IsWet);
            DebugStats.SetActive(enableDebug);
            if (enableDebug)
            {
                DebugStatsTMP.text = view_data.TimeUntilDry + "\n" + view_data.TimeUntilNextGrowthStage;
            }

            if (view_data.RandomState != CachedRandomState)
            {
                CachedRandomState = view_data.RandomState;
                RandomPosition.Run();
            }
            
            SmallSprinkler.SetActive(view_data.SprinklerType == SprinklerType.Small);
            LargeSprinkler.SetActive(view_data.SprinklerType == SprinklerType.Large);

            foreach (GameObject mistObject in SprinklerMist)
            {
                if (mistObject.activeInHierarchy != Mod.manager.GetPreference<PreferenceBool>(Mod.PREFERENCE_ENABLE_SPRINKLER_MIST).Value)
                {
                    mistObject.SetActive(Mod.manager.GetPreference<PreferenceBool>(Mod.PREFERENCE_ENABLE_SPRINKLER_MIST).Value);
                }
            }
        }

        private bool enableDebug = false;
        public GameObject WetFarmland;
        public GameObject DryFarmland;
        public GameObject DebugStats;
        public TextMeshPro DebugStatsTMP;
        public RandomPositionView RandomPosition;
        public GameObject SmallSprinkler;
        public GameObject LargeSprinkler;
        public List<GameObject> SprinklerMist = new List<GameObject>();
    }
}