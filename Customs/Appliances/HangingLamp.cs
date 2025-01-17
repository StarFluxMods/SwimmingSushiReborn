using System.Collections.Generic;
using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using SwimmingSushiReborn.Utilies;
using UnityEngine;

namespace SwimmingSushiReborn.Customs.Appliances
{
    public class HangingLamp : CustomAppliance
    {
        public override string UniqueNameID => "HangingLamp";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("HangingLamp").AssignMaterialsByNames();
        public override bool IsPurchasable => false;
        public override ShoppingTags ShoppingTags => ShoppingTags.Decoration;
        public override PriceTier PriceTier => PriceTier.Free;
        public override OccupancyLayer Layer => OccupancyLayer.Ceiling;
        public override List<(Locale, ApplianceInfo)> InfoList => CenteralLang.Appliances.HangingLamp;

        public override void OnRegister(Appliance gameDataObject)
        {
            base.OnRegister(gameDataObject);
            FadeAtNight fadeAtNight = gameDataObject.Prefab.AddComponent<FadeAtNight>();
            fadeAtNight.ReplaceShader = "Simple Flat";
            fadeAtNight.ReplaceWith = MaterialUtils.GetExistingMaterial("Simple Flat Transparent Replacement");
        }
    }
}