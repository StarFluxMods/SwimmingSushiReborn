using KitchenLib.Customs;
using KitchenLib.Utils;
using UnityEngine;

namespace SwimmingSushi.Customs.Items
{
    public class RolledSalmon : CustomItem
    {
        public override string UniqueNameID => "RolledSalmon";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("PlaceholderSushiRoll").AssignMaterialsByNames();
    }
}