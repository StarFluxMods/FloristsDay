using HarmonyLib;
using Kitchen;
using KitchenLib.Utils;
using ParentsEvent.Views;
using UnityEngine;

namespace ParentsEvent.Patches
{
    [HarmonyPatch(typeof(LocalViewRouter), "GetPrefab")]
    public class LocalViewRouterPatch_ChildView
    {
        static void Postfix(ViewType view_type, GameObject __result)
        {
            if (view_type != ViewType.Customer && view_type != ViewType.CustomerCat) return;
            if (__result.HasComponent<ChildView>()) return;
            ChildView view = __result.AddComponent<ChildView>();
            view.Animator = __result.GetComponentInChildren<Animator>();
        }
    }
}