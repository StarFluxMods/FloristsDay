
using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using Unity.Entities;
using UnityEngine;

namespace ParentsEvent.Customs.PlayerCosmetics
{
    public class GnomeHat : CustomPlayerCosmetic
    {
        public override string UniqueNameID => "GnomeHat";
        public override CosmeticType CosmeticType => CosmeticType.Hat;
        public override GameObject Visual => Mod.Bundle.LoadAsset<GameObject>("GnomeHat").AssignMaterialsByNames();
        public override bool BlockHats => true;

        public override void OnRegister(PlayerCosmetic gameDataObject)
        {
            PlayerOutfitComponent playerOutfitComponent = gameDataObject.Visual.AddComponent<PlayerOutfitComponent>();
            playerOutfitComponent.Renderers.Add(GameObjectUtils.GetChildObject(gameDataObject.Visual, "Gnome Hat/GnomeHat").GetComponent<SkinnedMeshRenderer>());
        }
    }
}