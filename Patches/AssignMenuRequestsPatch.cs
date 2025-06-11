using HarmonyLib;
using Kitchen;
using KitchenData;
using ParentsEvent.Systems;
using ParentsEvent.Utilities;
using Unity.Entities;

namespace ParentsEvent.Patches
{
    [HarmonyPatch(typeof(AssignMenuRequests), "OrderItem")]
    public class AssignMenuRequestsPatch
    {
        static bool Prefix(Item item_data, Entity group, int member_index)
        {
            if ((item_data.ID == GDOReferences.WrappedRock.ID || item_data.ID == GDOReferences.WrappedFramedPhoto.ID || item_data.ID == GDOReferences.WrappedToyTruck.ID) && !HelperSystem.Instance.IsCustomerChild(group, member_index)) return false;
            return true;
        }
    }
}