using KitchenLib.Customs;
using KitchenLib.Utils;
using UnityEngine;

namespace SwimmingSushiReborn.Customs.Items
{
    public class CookedRice : CustomItem
    {
        public override string UniqueNameID => "CookedRice";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("CookedRice").AssignMaterialsByNames();
    }
}