using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using Unity.Entities;
using UnityEngine;

namespace ParentsEvent.Customs.PlayerCosmetics
{
    public class SunflowerHat : CustomPlayerCosmetic
    {
        public override string UniqueNameID => "SunflowerHat";
        public override CosmeticType CosmeticType => CosmeticType.Hat;
        public override GameObject Visual => Mod.Bundle.LoadAsset<GameObject>("SunflowerHat").AssignMaterialsByNames();
        public override bool BlockHats => true;

        public override void OnRegister(PlayerCosmetic gameDataObject)
        {
            PlayerOutfitComponent playerOutfitComponent = gameDataObject.Visual.AddComponent<PlayerOutfitComponent>();
            playerOutfitComponent.Renderers.Add(GameObjectUtils.GetChildObject(gameDataObject.Visual, "Sunflower Hat/Hat").GetComponent<SkinnedMeshRenderer>());
        }
    }
}