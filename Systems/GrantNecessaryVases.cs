using System.Collections.Generic;
using Kitchen;
using KitchenData;
using KitchenMods;
using ParentsEvent.Utilities;
using Unity.Collections;
using Unity.Entities;
using UnityEngine;

namespace ParentsEvent.Systems
{
    public class GrantNecessaryVases : NightSystem, IModSystem
    {
        private EntityQuery _CreateAppliances;
        private EntityQuery _Providers;
        private EntityQuery _Unlocks;
        private EntityQuery _Parcels;

        protected override void Initialise()
        {
            base.Initialise();
            _CreateAppliances = GetEntityQuery(typeof(CCreateAppliance));
            _Providers = GetEntityQuery(typeof(CAppliance), typeof(CItemProvider));
            _Unlocks = GetEntityQuery(typeof(CProgressionUnlock));
            _Parcels = GetEntityQuery(typeof(CLetterAppliance));
        }

        protected override void OnUpdate()
        {
            if (!DoesRestaurantNeedVases()) return;
            if (!_CreateAppliances.IsEmpty) return;
            
            int maximumGroupSize = GetOrDefault<SKitchenParameters>().Parameters.MaximumGroupSize;
            int availableVases = GetTotalVases();
            int num = 0;
            if (availableVases < maximumGroupSize)
            {
                List<Vector3> postTiles = GetPostTiles();
                Vector3 parcelTile = GetParcelTile(postTiles, ref num);
                PostHelpers.CreateApplianceParcel(EntityManager, parcelTile, GDOReferences.FloristsVaseProvider.ID);
            }
        }

        private Vector3 GetParcelTile(List<Vector3> tiles, ref int offset)
        {
            Vector3 vector = Vector3.zero;
            bool flag = false;
            while (!flag && offset < tiles.Count)
            {
                int num = offset;
                offset = num + 1;
                vector = tiles[num];
                if (TileManager.GetOccupant(vector) != default || TileManager.GetTile(vector).HasFeature) continue;
                flag = true;
            }
            return flag ? vector : GetFallbackTile();
        }

        private int GetTotalVases()
        {
            int result = 0;
            using (NativeArray<CAppliance> appliances = _Providers.ToComponentDataArray<CAppliance>(Allocator.Temp))
            {
                using (NativeArray<CLetterAppliance> parcles = _Parcels.ToComponentDataArray<CLetterAppliance>(Allocator.Temp))
                {
                    foreach (CAppliance appliance in appliances)
                    {
                        if (Data.TryGet(appliance.ID, out Appliance applianceObject) && applianceObject.GetProperty(out CItemProvider providerObject) && providerObject.Item == GDOReferences.Vase.ID)
                        {
                            result += providerObject.Available;
                        }
                    }
                    
                    foreach (CLetterAppliance parcle in parcles)
                    {
                        if (Data.TryGet(parcle.ApplianceID, out Appliance applianceObject))
                        {
                            if (applianceObject.GetProperty(out CItemProvider providerObject))
                            {
                                if (providerObject.Item == GDOReferences.Vase.ID)
                                {
                                    result += providerObject.Available;
                                }
                            }
                        }
                    }
                }
            }

            return result;
        }

        private bool DoesRestaurantNeedVases()
        {
            using (NativeArray<CProgressionUnlock> unlocks = _Unlocks.ToComponentDataArray<CProgressionUnlock>(Allocator.Temp))
            {
                foreach (CProgressionUnlock unlock in unlocks)
                {
                    if (Data.TryGet(unlock.ID, out Dish dish))
                    {
                        if (dish.MinimumIngredients.Contains(GDOReferences.Vase)) return true;
                    }
                }
            }

            return false;
        }
    }
}