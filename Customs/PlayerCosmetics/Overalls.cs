using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using Unity.Entities;
using UnityEngine;

namespace ParentsEvent.Customs.PlayerCosmetics
{
    public class Overalls : CustomPlayerCosmetic
    {
        public override string UniqueNameID => "Overalls";
        public override CosmeticType CosmeticType => CosmeticType.Outfit;
        public override GameObject Visual => Mod.Bundle.LoadAsset<GameObject>("Overalls").AssignMaterialsByNames();

        public override void OnRegister(PlayerCosmetic gameDataObject)
        {
            PlayerOutfitComponent playerOutfitComponent = gameDataObject.Visual.AddComponent<PlayerOutfitComponent>();
            playerOutfitComponent.Renderers.Add(GameObjectUtils.GetChildObject(gameDataObject.Visual, "Overalls.001/Buttons").GetComponent<SkinnedMeshRenderer>());
            playerOutfitComponent.Renderers.Add(GameObjectUtils.GetChildObject(gameDataObject.Visual, "Overalls.001/Flower").GetComponent<SkinnedMeshRenderer>());
            playerOutfitComponent.Renderers.Add(GameObjectUtils.GetChildObject(gameDataObject.Visual, "Overalls.001/Leaf").GetComponent<SkinnedMeshRenderer>());
            playerOutfitComponent.Renderers.Add(GameObjectUtils.GetChildObject(gameDataObject.Visual, "Overalls.001/Overalls").GetComponent<SkinnedMeshRenderer>());
            playerOutfitComponent.Renderers.Add(GameObjectUtils.GetChildObject(gameDataObject.Visual, "Overalls.001/Pouch").GetComponent<SkinnedMeshRenderer>());
            playerOutfitComponent.Renderers.Add(GameObjectUtils.GetChildObject(gameDataObject.Visual, "Overalls.001/Undershirt").GetComponent<SkinnedMeshRenderer>());
        }
    }
}