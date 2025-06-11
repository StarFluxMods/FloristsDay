using System.Collections.Generic;
using Kitchen;
using KitchenLib.References;
using KitchenMods;
using ParentsEvent.Components;
using Unity.Entities;

namespace ParentsEvent.Systems
{
    public class FillWateringCan : ItemInteractionSystem, IModSystem
    {
        private static List<int> WaterSuppliers = new()
        {
            ApplianceReferences.SinkLarge,
            ApplianceReferences.SinkNormal,
            ApplianceReferences.SinkPower,
            ApplianceReferences.SinkSoak,
            ApplianceReferences.SinkStarting,
        };
        
        private CWateringCan cWateringCan;
        private CItemHolder cItemHolder;
        
        protected override bool IsPossible(ref InteractionData data)
        {
            return Require(data.Target, out CAppliance cAppliance) && WaterSuppliers.Contains(cAppliance.ID) && Require(data.Interactor, out cItemHolder) && cItemHolder.HeldItem != Entity.Null && Require(cItemHolder.HeldItem, out cWateringCan);
        }

        protected override void Perform(ref InteractionData data)
        {
            cWateringCan.WaterLevel = 5;
            Set(cItemHolder.HeldItem, cWateringCan);
        }
    }
}