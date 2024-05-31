using System.Collections.Generic;
using System.Reflection;
using HarmonyLib;
using Kitchen;
using Kitchen.Layouts;
using KitchenData;
using KitchenLib.Utils;
using Mono.WebBrowser;
using ParentsEvent.Customs.LayoutProfiles;
using ParentsEvent.Customs.LayoutProfiles.Decorators;

namespace ParentsEvent.Patches
{
    /*
     * This patch is used to run a custom Decorator set for the Parents Layout
     */
    [HarmonyPatch(typeof(LayoutDecorator), "AttemptDecoration")]
    public class LayoutDecoratorPatch
    {
        static bool Prefix(LayoutDecorator __instance)
        {
            FieldInfo _Blueprint = ReflectionUtils.GetField<LayoutDecorator>("Blueprint");
            FieldInfo _Profile = ReflectionUtils.GetField<LayoutDecorator>("Profile");
            FieldInfo _Setting = ReflectionUtils.GetField<LayoutDecorator>("Setting");

            LayoutBlueprint Blueprint = (LayoutBlueprint)_Blueprint.GetValue(__instance);
            LayoutProfile Profile = (LayoutProfile)_Profile.GetValue(__instance);
            RestaurantSetting Setting = (RestaurantSetting)_Setting.GetValue(__instance);

            if (Profile.ID != GDOUtils.GetCustomGameDataObject<ParentsLayout>().ID) return true;

            __instance.Decorations = new List<CLayoutAppliancePlacement>();
            Decorator decorator = new DiningDecorator().Setup(Blueprint, Profile, null, __instance.Decorations);
            Decorator parentsDecorator = new ParentsDecorator().Setup(Blueprint, Profile, null, __instance.Decorations);
            Decorator decorator2 = new KitchenDecorator().Setup(Blueprint, Profile, null, __instance.Decorations);

            foreach (Room room in Blueprint.Rooms())
            {
                if (room.Type == RoomType.Garden)
                {
                    parentsDecorator.Decorate(room);
                }

                if (room.Type == RoomType.Kitchen)
                {
                    decorator2.Decorate(room);
                }

                if (room.Type == RoomType.Dining)
                {
                    int num = 5;
                    while (num-- > 0 && !decorator.Decorate(room))
                    {
                    }

                    if (num <= 0)
                    {
                        throw new LayoutFailureException("Failed to decorate dining room");
                    }
                }
            }

            foreach (IDecorationConfiguration decorationConfiguration in Setting.Decorators)
            {
                try
                {
                    Decorator decorator3 = (Decorator)decorationConfiguration.Decorator;
                    decorator3.Setup(Blueprint, Profile, decorationConfiguration, __instance.Decorations);
                    decorator3.Decorate(default(Room));
                }
                catch (Exception arg)
                {
                    throw new LayoutFailureException(string.Format("Failed to apply decorator {0}: {1}", decorationConfiguration.Decorator, arg));
                }
            }

            return false;
        }
    }
}