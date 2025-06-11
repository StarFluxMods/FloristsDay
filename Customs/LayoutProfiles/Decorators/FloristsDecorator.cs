using System.Collections.Generic;
using System.Linq;
using Kitchen;
using Kitchen.Layouts;
using ParentsEvent.Utilities;
using UnityEngine;

namespace ParentsEvent.Customs.LayoutProfiles.Decorators
{
    public class FloristsDecorator : Decorator
    {
        private List<LayoutPosition> used_positions = new List<LayoutPosition>();
        public override bool Decorate(Room room)
        {
            List<CLayoutAppliancePlacement> farmlandToAdd = new List<CLayoutAppliancePlacement>();
            List<CLayoutAppliancePlacement> additionalFarmlandToAdd = new List<CLayoutAppliancePlacement>();
            int minFarmland = 3;
            int maxFarmland = 5;
            List<LayoutPosition> ShuffledPositions = (from r in Blueprint.TilesOfRoom(room) orderby UnityEngine.Random.value select r).ToList();
            
            foreach (LayoutPosition position in ShuffledPositions)
            {
                if (farmlandToAdd.Count >= maxFarmland) break;
                if (!IsValidPosition(room, position)) continue;
                
                farmlandToAdd.Add(new CLayoutAppliancePlacement
                {
                    Position = position,
                    Appliance = GDOReferences.Farmland.ID,
                    Rotation = Quaternion.identity
                });
                used_positions.Add(position);

                foreach (LayoutPosition circlePoint in Circle)
                {
                    if (!IsValidPosition(room, circlePoint + position)) continue;
                    additionalFarmlandToAdd.Add(new CLayoutAppliancePlacement
                    {
                        Position = circlePoint + position,
                        Appliance = GDOReferences.Farmland.ID,
                        Rotation = Quaternion.identity
                    });
                    used_positions.Add(circlePoint + position);
                }
            }

            if (farmlandToAdd.Count > maxFarmland || farmlandToAdd.Count <= minFarmland) return false;
            
            foreach (var decoration in farmlandToAdd)
            {
                Decorations.Add(decoration);
            }
            foreach (var decoration in additionalFarmlandToAdd)
            {
                Decorations.Add(decoration);
            }
            
            return true;
        }

        private bool IsValidPosition(Room room, LayoutPosition position)
        {
            if (used_positions.Contains(position)) return false;
            if (Blueprint.HasFeature(position)) return false;
            if (!Blueprint.TilesOfRoom(room).Contains(position)) return false;
            return true;
        }

        private static readonly List<LayoutPosition> Circle = new()
        {
            new LayoutPosition(1, 0),
            new LayoutPosition(0, 1),
            new LayoutPosition(-1, 0),
            new LayoutPosition(0, -1),
            new LayoutPosition(1, 1),
            new LayoutPosition(-1, 1),
            new LayoutPosition(1, -1),
            new LayoutPosition(-1, -1),
            new LayoutPosition(-2, 0),
            new LayoutPosition(-2, 1),
            new LayoutPosition(-2, -1),
            new LayoutPosition(2, 0),
            new LayoutPosition(2, 1),
            new LayoutPosition(2, -1),
            new LayoutPosition(0, -2),
            new LayoutPosition(1, -2),
            new LayoutPosition(-1, -2),
            new LayoutPosition(0, 2),
            new LayoutPosition(1, 2),
            new LayoutPosition(-1, 2),
        };
    }
}