using System.Collections.Generic;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using UnityEngine;

namespace SwimmingSushiReborn.Customs.Appliances
{
    public class RandomCube : CustomAppliance
    {
        public override string UniqueNameID => "RandomCube";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("RandomCube").AssignMaterialsByNames();
        public override bool IsPurchasable => false;
        public override DecorationType ThemeRequired => DecorationType.Affordable;
        public override ShoppingTags ShoppingTags => ShoppingTags.Decoration;

        public override List<(Locale, ApplianceInfo)> InfoList => new List<(Locale, ApplianceInfo)>
{
    (Locale.English, new ApplianceInfo{Name = "======================", Description = "Don't have time to roll sushi?", Tags = new List<string>{"Automatic", "2x <sprite name=\"roll\">"}}),
};
        
    }
}