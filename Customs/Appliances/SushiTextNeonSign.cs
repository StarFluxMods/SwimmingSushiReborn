using System.Collections.Generic;
using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using SwimmingSushiReborn.Utilies;
using UnityEngine;

namespace SwimmingSushiReborn.Customs.Appliances
{
    public class SushiTextNeonSign : CustomAppliance
    {
        public override string UniqueNameID => "SushiTextNeonSign";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("SushiTextNeonSign").AssignMaterialsByNames();
        public override List<IApplianceProperty> Properties => new List<IApplianceProperty>
        {
            new CMustHaveWall()
        };
        public override bool IsPurchasable => false;
        public override PriceTier PriceTier => PriceTier.Free;
        public override ShoppingTags ShoppingTags => ShoppingTags.Decoration;
        public override OccupancyLayer Layer => OccupancyLayer.Wall;
        public override List<(Locale, ApplianceInfo)> InfoList => CenteralLang.Appliances.FishTank;
    }
}