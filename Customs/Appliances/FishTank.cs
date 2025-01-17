using System.Collections.Generic;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using SwimmingSushiReborn.Utilies;
using UnityEngine;

namespace SwimmingSushiReborn.Customs.Appliances
{
    public class FishTank : CustomAppliance
    {
        public override string UniqueNameID => "FishTank";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("FishTank").AssignMaterialsByNames();
        public override bool IsPurchasable => false;
        public override PriceTier PriceTier => PriceTier.Free;
        public override ShoppingTags ShoppingTags => ShoppingTags.Decoration;
        public override List<(Locale, ApplianceInfo)> InfoList => CenteralLang.Appliances.FishTank;
    }
}