using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using SwimmingSushiReborn.Utilies;
using UnityEngine;

namespace SwimmingSushiReborn.Customs.Decor
{
    public class WallpaperBubbles : CustomDecor
    {
        public override string UniqueNameID => "WallpaperBubbles";
        public override Material Material => MaterialUtils.GetCustomMaterial("Wallpaper - Bubbles");
        public override Appliance ApplicatorAppliance => GDOReferences.WallpaperApplicator;
        public override LayoutMaterialType Type => LayoutMaterialType.Wallpaper;
        public override bool IsAvailable => false;
    }
}