using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using SwimmingSushiReborn.Utilies;
using UnityEngine;

namespace SwimmingSushiReborn.Customs.Decor
{
    public class SandFloor : CustomDecor
    {
        public override string UniqueNameID => "SandFloor";
        public override Material Material => MaterialUtils.GetCustomMaterial("Sand Floor");
        public override Appliance ApplicatorAppliance => GDOReferences.FlooringApplicator;
        public override LayoutMaterialType Type => LayoutMaterialType.Floor;
        public override bool IsAvailable => false;
    }
}