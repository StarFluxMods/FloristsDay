using System.Collections.Generic;
using Kitchen;
using KitchenMods;
using ParentsEvent.Components;
using ParentsEvent.Enums;
using Unity.Collections;
using Unity.Entities;
using UnityEngine;

namespace ParentsEvent.Systems
{
    public class WaterSprinklerArea : GameSystemBase, IModSystem
    {
        private static Dictionary<SprinklerType, int> SprinklerSizes = new Dictionary<SprinklerType, int>
        {
            { SprinklerType.None, 0},
            { SprinklerType.Small, 2},
            { SprinklerType.Large, 5},
        };
        private EntityQuery _farmland;
        protected override void Initialise()
        {
            base.Initialise();
            _farmland = EntityManager.CreateEntityQuery(typeof(CFarmland));
        }

        protected override void OnUpdate()
        {
            using (NativeArray<Entity> farmland = _farmland.ToEntityArray(Allocator.Temp))
            {
                foreach (Entity plot in farmland)
                {
                    if (!Require(plot, out CFarmland cFarmland) || !Require(plot, out CPosition cPosition)) continue;
                    if (cFarmland.SprinklerType == SprinklerType.None) continue;
                    List<Vector2> circle = GenerateFilledCirclePoints(new Vector2(0, 0), SprinklerSizes[cFarmland.SprinklerType]);
                    foreach (var x in circle)
                    {
                        Entity entity = TileManager.GetOccupant(new Vector3(x.x, 0, x.y) + cPosition);
                        if (entity == Entity.Null) continue;
                        if (!Require(entity, out CFarmland cFarmland2)) continue;
                        if (!(Random.value < 0.15f)) continue;
                        cFarmland2.TimeUntilDry += Time.DeltaTime * 15;
                        Set(entity, cFarmland2);
                    }
                }
            }
        }
        
        public static List<Vector2> GenerateFilledCirclePoints(Vector2 center, int radius)
        {
            List<Vector2> points = new List<Vector2>();
            int cx = (int)center.x;
            int cy = (int)center.y;
            int rSquared = radius * radius;

            for (int x = -radius; x <= radius; x++)
            {
                for (int y = -radius; y <= radius; y++)
                {
                    if (x * x + y * y <= rSquared)
                    {
                        points.Add(new Vector2(cx + x, cy + y));
                    }
                }
            }

            return points;
        }
    }
}