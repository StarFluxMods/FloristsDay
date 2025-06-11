using System.Collections.Generic;
using CsvHelper;
using Kitchen;
using Kitchen.Components;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using ParentsEvent.Customs.Generics;
using ParentsEvent.Utilities;
using UnityEngine;

namespace ParentsEvent.Customs.Appliances
{
    public class SausageProvider : GenericProvider
    {
        public override string UniqueNameID => "SausageProvider";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("SausageProvider").AssignMaterialsByNames();
        public override Item ProvidedItem => GDOReferences.RawSausage;
        public override List<(Locale, ApplianceInfo)> InfoList => CenteralLang.Appliances.SausageProvider;

        public override void OnRegister(Appliance gameDataObject)
        {
            base.OnRegister(gameDataObject);
            
            ItemSourceView itemSourceView = gameDataObject.Prefab.AddComponent<ItemSourceView>();
            itemSourceView.Renderer = gameDataObject.Prefab.GetChild("Short Fridge/Icon").GetComponent<MeshRenderer>();
            itemSourceView.Animator = gameDataObject.Prefab.GetChild("Short Fridge").GetComponent<Animator>();
            
            AnimationSoundSource animationSoundSource = gameDataObject.Prefab.GetChild("Short Fridge").AddComponent<AnimationSoundSource>();
            animationSoundSource.Category = SoundCategory.Effects;
            animationSoundSource.Clip = Mod.Bundle.LoadAsset<AudioClip>("Fridge_mixdown");
            animationSoundSource.ShouldLoop = false;
            animationSoundSource.SoundList = new List<AudioClip> { Mod.Bundle.LoadAsset<AudioClip>("Fridge_mixdown") };
        }
    }
}