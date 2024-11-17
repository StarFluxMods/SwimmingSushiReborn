using KitchenLib.Customs;
using KitchenLib.Utils;
using UnityEngine;

namespace SwimmingSushi.Customs.Items
{
    public class PortionedSalmonRoll : CustomItem
    {
        public override string UniqueNameID => "PortionedSalmonRoll";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("PlaceholderPortionedSalmonRoll").AssignMaterialsByNames();
    }
}