using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using SwimmingSushiReborn.Utilies;
using UnityEngine;

namespace SwimmingSushiReborn.Customs.Decor
{
    public class WallpaperSeaweed : CustomDecor
    {
        public override string UniqueNameID => "WallpaperSeaweed";
        public override Material Material => MaterialUtils.GetCustomMaterial("Wallpaper - Seaweed");
        public override Appliance ApplicatorAppliance => GDOReferences.WallpaperApplicator;
        public override LayoutMaterialType Type => LayoutMaterialType.Wallpaper;
        public override bool IsAvailable => false;
    }
}