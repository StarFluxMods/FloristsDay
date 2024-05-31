using System.Collections.Generic;
using System.Linq;
using Kitchen;
using Kitchen.Layouts;
using KitchenLib.Utils;
using ParentsEvent.Customs.Appliances;
using UnityEngine;

namespace ParentsEvent.Customs.LayoutProfiles.Decorators
{
    public class ParentsDecorator : Decorator
    {
        public override bool Decorate(Room room)
        {
            List<CLayoutAppliancePlacement> list = new List<CLayoutAppliancePlacement>();
            List<Vector2> list2 = new List<Vector2>();
            int minimumFeatures = 0;
            int maximumFeatures = 12;
            int num = 0;
            List<LayoutPosition> ShuffledPositions = (from r in Blueprint.TilesOfRoom(room) orderby UnityEngine.Random.value select r).ToList();

            foreach (LayoutPosition layoutPosition in ShuffledPositions)
            {
                bool flag = true;
                foreach (LayoutPosition p3 in LayoutHelpers.Directions)
                {
                    LayoutPosition layoutPosition2 = p3 + layoutPosition;
                    if (list2.Contains(layoutPosition2) || this.Blueprint.HasFeature(layoutPosition2, FeatureType.Generic))
                    {
                        flag = false;
                        break;
                    }
                }

                if (flag)
                {
                    list.Add(new CLayoutAppliancePlacement
                    {
                        Position = layoutPosition,
                        Appliance = GDOUtils.GetCustomGameDataObject<DirtPatch>().ID,
                        Rotation = Quaternion.identity
                    });
                }
            }
            
            Mod.Logger.LogInfo("Decorated parents room with " + num + " features");
            list.ForEach(delegate(CLayoutAppliancePlacement p) { this.Decorations.Add(p); });
            return true;

        }
    }
}