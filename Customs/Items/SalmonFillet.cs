using KitchenLib.Customs;
using KitchenLib.Utils;
using UnityEngine;

namespace SwimmingSushi.Customs.Items
{
    public class SalmonFillet : CustomItem
    {
        public override string UniqueNameID => "SalmonFillet";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("PlaceholderSalmonFillet").AssignMaterialsByNames();
    }
}