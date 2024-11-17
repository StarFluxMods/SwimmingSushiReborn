using KitchenLib.Customs;
using KitchenLib.Utils;
using Unity.Entities;
using UnityEngine;

namespace SwimmingSushi.Customs.Items
{
    public class CookedRice : CustomItem
    {
        public override string UniqueNameID => "CookedRice";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("CookedRice").AssignMaterialsByNames();
    }
}