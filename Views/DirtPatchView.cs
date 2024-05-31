using Kitchen;
using KitchenMods;
using MessagePack;
using ParentsEvent.Components;
using Unity.Collections;
using Unity.Entities;
using UnityEngine;

namespace ParentsEvent.Views
{
    public class DirtPatchView : UpdatableObjectView<DirtPatchView.ViewData>
	{
		public class UpdateView : IncrementalViewSystemBase<ViewData>, IModSystem
		{
			private EntityQuery Views;

			protected override void Initialise()
			{
				base.Initialise();

				Views = GetEntityQuery(new QueryHelper().All(typeof(CRenewableFlowerPatch), typeof(CLinkedView)));
			}

			protected override void OnUpdate()
			{
				using var entities = Views.ToEntityArray(Allocator.Temp);
				using var views = Views.ToComponentDataArray<CLinkedView>(Allocator.Temp);

				for (var i = 0; i < views.Length; i++)
				{
					var view = views[i];
					if (Require(entities[i], out CRenewableFlowerPatch cRenewableFlowerPatch))
					{
						ViewData data = new ViewData
						{
							isWatered = (cRenewableFlowerPatch.IsWatered && cRenewableFlowerPatch.RequiresWatering) || !cRenewableFlowerPatch.RequiresWatering
						};
						SendUpdate(view, data);
					}
				}
			}
		}

		[MessagePackObject(false)]
		public struct ViewData : ISpecificViewData, IViewData.ICheckForChanges<ViewData>
		{
			[Key(1)] public bool isWatered;

			public IUpdatableObject GetRelevantSubview(IObjectView view) => view.GetSubView<DirtPatchView>();

			public bool IsChangedFrom(ViewData cached)
			{
				return isWatered != cached.isWatered;
			}
		}

		protected override void UpdateData(ViewData view_data)
		{
			if (WateredLayer != null)
				WateredLayer.SetActive(view_data.isWatered);
		}
		
		public GameObject WateredLayer;
	}
}