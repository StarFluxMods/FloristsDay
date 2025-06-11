using Kitchen;
using KitchenMods;
using MessagePack;
using ParentsEvent.Components;
using Unity.Collections;
using Unity.Entities;
using UnityEngine;

namespace ParentsEvent.Views
{
    public class WateringCanView : UpdatableObjectView<WateringCanView.ViewData>
    {
        public class UpdateView : IncrementalViewSystemBase<ViewData>, IModSystem
        {
            private EntityQuery Views;

            protected override void Initialise()
            {
                base.Initialise();

                Views = GetEntityQuery(new QueryHelper().All(typeof(CWateringCan), typeof(CLinkedView)));
            }

            protected override void OnUpdate()
            {
                using (NativeArray<Entity> farmlands = Views.ToEntityArray(Allocator.Temp))
                {
                    foreach (Entity farmland in farmlands)
                    {
                        if (Require(farmland, out CWateringCan cWateringCan) && Require(farmland, out CLinkedView cLinkedView))
                        {
                            SendUpdate(cLinkedView, new ViewData
                            {
                                HasWater = cWateringCan.WaterLevel != 0,
                            });
                        }
                    }
                }
            }
        }

        [MessagePackObject(false)]
        public struct ViewData : ISpecificViewData, IViewData.ICheckForChanges<ViewData>
        {
            [Key(1)] public bool HasWater;

            public IUpdatableObject GetRelevantSubview(IObjectView view) => view.GetSubView<WateringCanView>();

            public bool IsChangedFrom(ViewData cached)
            {
                return HasWater != cached.HasWater;
            }
        }

        protected override void UpdateData(ViewData view_data)
        {
            FilledWateringCan.SetActive(view_data.HasWater);
        }

        public GameObject FilledWateringCan;
    }
}