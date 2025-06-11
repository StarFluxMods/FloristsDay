using HarmonyLib;
using Kitchen;
using KitchenLib.Utils;
using ParentsEvent.Views;
using UnityEngine;

namespace ParentsEvent.Patches
{
    [HarmonyPatch(typeof(LocalViewRouter), "GetPrefab")]
    public class LocalViewRouterPatch_ProgressIndicator
    {
        static void Prefix(ref ViewType view_type)
        {
            if (view_type == (ViewType)VariousUtils.GetID( $"{Mod.MOD_GUID}.portionIndicators"))
            {
                view_type = ViewType.ProgressView;
            }
        }
    }
}