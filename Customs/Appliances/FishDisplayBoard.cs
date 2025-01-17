using System.Collections.Generic;
using Kitchen.Components;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using SwimmingSushiReborn.Components;
using SwimmingSushiReborn.Utilies;
using SwimmingSushiReborn.Views;
using UnityEngine;

namespace SwimmingSushiReborn.Customs.Appliances
{
    public class FishDisplayBoard : CustomAppliance
    {
        public override string UniqueNameID => "FishDisplayBoard";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("FishDisplayBoard").AssignMaterialsByNames();
        public override bool IsPurchasable => false;
        public override ShoppingTags ShoppingTags => ShoppingTags.Decoration;
        public override List<(Locale, ApplianceInfo)> InfoList => CenteralLang.Appliances.FishDisplayBoard;
        public override PriceTier PriceTier => PriceTier.Free;

        public override List<IApplianceProperty> Properties => new List<IApplianceProperty>
        {
            new CFishDisplayBoardView
            {
                isBeingInteractedWith = false
            }
        };

        public override void OnRegister(Appliance gameDataObject)
        {
            base.OnRegister(gameDataObject);
            FishDisplayBoardView fishDisplayBoardView = gameDataObject.Prefab.AddComponent<FishDisplayBoardView>();
            fishDisplayBoardView.animator = gameDataObject.Prefab.GetComponentInChildren<Animator>();
            fishDisplayBoardView.soundSource = gameDataObject.Prefab.AddComponent<SoundSource>();
            fishDisplayBoardView.soundSource.TargetVolume = 0;
            fishDisplayBoardView.soundSource.Category = SoundCategory.Effects;
            fishDisplayBoardView.soundSource.ShouldLoop = false;
            fishDisplayBoardView.soundSource.Clip = Mod.Bundle.LoadAsset<AudioClip>("Wet Fish Slap");
        }
    }
}