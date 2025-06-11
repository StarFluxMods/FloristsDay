using Kitchen;
using KitchenLib.References;
using KitchenLib.Utils;
using KitchenMods;
using ParentsEvent.Components;
using ParentsEvent.Utilities;
using Unity.Entities;

namespace ParentsEvent.Systems
{
    public class ManagePortionIndicators : IndicatorManager, IModSystem
	{
		protected override ViewType ViewType => (ViewType)VariousUtils.GetID( $"{Mod.MOD_GUID}.portionIndicators");

		protected override ViewMode ViewMode => ViewMode.World;

		protected override EntityQuery GetSearchQuery()
		{
			return GetEntityQuery(typeof(CItem), typeof(CPortionableVase));
		}

		protected override bool ShouldHaveIndicator(Entity candidate)
		{
			
			if (!Has<CItemUndergoingPortion>(candidate))
			{
				return false;
			}
			CHeldBy cheldBy;
			if (Require(candidate, out cheldBy))
			{
				if (Has<CIsOnFire>(cheldBy))
				{
					return false;
				}
				if (Has<CHideHeldProgressIndicator>(cheldBy))
				{
					return false;
				}
				if (Has<CPlayer>(cheldBy))
				{
					return false;
				}
			}
			return !Has<CHideProgressIndicator>(candidate) && !Has<CStoredBy>(candidate);
		}

		protected override Entity CreateIndicator(Entity source)
		{
			Entity entity = base.CreateIndicator(source);
			EntityManager.AddComponent<CProgressIndicator>(entity);
			EntityManager.AddComponent<CPosition>(entity);
			UpdateIndicator(entity, source);
			return entity;
		}

		protected override void UpdateIndicator(Entity indicator, Entity source)
		{
			CItemUndergoingPortion citemUndergoingProcess;
			if (!Require(source, out citemUndergoingProcess))
			{
				return;
			}
			CHeldBy cheldBy;
			if (!Require(source, out cheldBy))
			{
				return;
			}
			CPosition cposition;
			if (!Require(cheldBy, out cposition))
			{
				return;
			}
			base.UpdateIndicator(indicator, source);
			EntityManager.SetComponentData(indicator, new CProgressIndicator
			{
				Progress = citemUndergoingProcess.Progress,
				IsUnknownLength = Has<CObfuscateProgressIndicator>(source),
				CurrentChange = citemUndergoingProcess.CurrentChange,
				Process = GDOReferences.DummySplit.ID,
				IsBad = false
			});
			EntityManager.SetComponentData(indicator, new CPosition(cposition));
		}
	}
}
