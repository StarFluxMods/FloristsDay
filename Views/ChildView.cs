using System;
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
    public class ChildView : UpdatableObjectView<ChildView.ViewData>
    {
        public class UpdateView : IncrementalViewSystemBase<ViewData>, IModSystem
        {
            private EntityQuery Views;

            protected override void Initialise()
            {
                base.Initialise();

                Views = GetEntityQuery(new QueryHelper().All(typeof(CCustomer), typeof(CChildCustomer), typeof(CLinkedView)));
            }

            protected override void OnUpdate()
            {
                using (NativeArray<Entity> farmlands = Views.ToEntityArray(Allocator.Temp))
                {
                    foreach (Entity farmland in farmlands)
                    {
                        if (Require(farmland, out CLinkedView cLinkedView))
                        {
                            SendUpdate(cLinkedView, new ViewData
                            {
                                IsChild = true
                            });
                        }
                    }
                }
            }
        }

        [MessagePackObject(false)]
        public struct ViewData : ISpecificViewData, IViewData.ICheckForChanges<ViewData>
        {
            [Key(1)] public bool IsChild;

            public IUpdatableObject GetRelevantSubview(IObjectView view) => view.GetSubView<ChildView>();

            public bool IsChangedFrom(ViewData cached)
            {
                return IsChild != cached.IsChild;
            }
        }

        public Animator Animator;
        private ViewData _viewData;
        
        protected override void UpdateData(ViewData view_data)
        {
            _viewData = view_data;
        }

        private void Update()
        {
            if (!_viewData.IsChild) return;
            if (Animator == null) return;
            Animator.transform.localPosition = Animator.GetBool("ShouldSit") ? new Vector3(0,0.5f,0) : new Vector3(0,0,0);
        }
    }
}