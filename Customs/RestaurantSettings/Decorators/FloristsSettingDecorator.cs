using System.Collections.Generic;
using Kitchen;
using Kitchen.Layouts;
using KitchenData;
using KitchenLib.References;
using UnityEngine;
namespace ParentsEvent.Customs.RestaurantSettings.Decorators
{
    public class FloristsSettingDecorator : Decorator
    {
        public override bool Decorate(Room room)
        {
	        if (Configuration is not DecorationsConfiguration decorationsConfiguration) return false;
	        Bounds bounds = Blueprint.GetBounds();
	        Vector3 frontDoor = Blueprint.GetFrontDoor();
	        NewPiece(decorationsConfiguration.Ground, 0f, 0f);
	        NewPiece(decorationsConfiguration.Pollen, 0f, 0f);
	        
	        // Decorate Top and Bottom

	        for (float x = bounds.min.x - xDifference; x < bounds.max.x + xDifference; x++)
	        {
		        for (float y = bounds.min.y - yDifference; y < bounds.max.y + yDifference; y++)
		        {
			        if (!(x > bounds.min.x - (decorationsConfiguration.BorderSpacing + 1)) || !(x < bounds.max.x + (decorationsConfiguration.BorderSpacing + 1)) || !(y > bounds.min.y - (decorationsConfiguration.BorderSpacing + 1)) || !(y < bounds.max.y + (decorationsConfiguration.BorderSpacing + 1)))
			        {
				        if (y > bounds.min.y)
				        {
					        foreach (var scatter in decorationsConfiguration.Scatters)
					        {
						        if (Random.value < scatter.Probability)
						        {
							        NewPiece(scatter.Appliance, x, y);
							        break;
						        }
					        }
				        }
			        }
		        }
	        }
	        
	        if (decorationsConfiguration.Cobblestone != null)
	        {
		        for (float num3 = PathStartLocation; num3 <= frontDoor.x; num3 += 0.8f)
		        {
			        NewPiece(decorationsConfiguration.Cobblestone, num3, bounds.min.y - 1.2f);
		        }
	        }


	        if (decorationsConfiguration.FrontBorder != null)
	        {
		        for (float num4 = bounds.min.x; num4 <= bounds.max.x; num4 += decorationsConfiguration.BorderSpacing)
		        {
			        if (Mathf.Abs(num4 - frontDoor.x) >= 0.7f && Blueprint[(int)num4, (int)bounds.min.y].Type != RoomType.Garden)
			        {
				        NewPiece(decorationsConfiguration.FrontBorder, num4, bounds.min.y - 0.7f);
			        }
		        }
	        }


	        for (float num5 = bounds.min.x - 1f; num5 <= bounds.max.x + 1f; num5 += 1f)
	        {
		        NewPiece(AssetReference.OutdoorMovementBlocker, num5, bounds.min.y - 3f);
	        }


	        float num6 = ((frontDoor.x < 3f) ? (frontDoor.x + 1f) : (frontDoor.x - 1f));


	        NewPiece(AssetReference.Nameplate, num6, bounds.min.y - 1f);
	        NewPiece(AssetReference.OutdoorMovementBlocker, bounds.min.x - 1f, bounds.min.y - 1f);
	        NewPiece(AssetReference.OutdoorMovementBlocker, bounds.min.x - 1f, bounds.min.y - 2f);

	        NewPiece(AssetReference.OutdoorMovementBlocker, bounds.max.x + 1f, bounds.min.y - 1f);
	        NewPiece(AssetReference.OutdoorMovementBlocker, bounds.max.x + 1f, bounds.min.y - 2f);
	        NewPiece(Profile.ExternalBin, frontDoor.x, frontDoor.z - 3f);
	        
	        
	        return true;
        }

        private int PathStartLocation = -20;
        private int xDifference = 15;
        private int yDifference = 6;

        public class DecorationsConfiguration : IDecorationConfiguration
        {
	        public IDecorator Decorator => new FloristsSettingDecorator();

	        public List<Scatter> Scatters;

	        public Appliance Cobblestone;

	        public Appliance FrontBorder;

	        public float BorderSpacing;

	        public Appliance Ground;
	        
	        public Appliance Pollen;

	        public bool OnlyDecorateLowerHalf;

	        public struct Scatter
	        {
		        public float Probability;

		        public Appliance Appliance;
	        }
        }
    }
}