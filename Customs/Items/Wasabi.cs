using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using UnityEngine;

namespace SwimmingSushiReborn.Customs.Items
{
    public class Wasabi : CustomItem
    {
        public override string UniqueNameID => "Wasabi";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("Wasabi").AssignMaterialsByNames();
        public override ItemStorage ItemStorageFlags => ItemStorage.StackableFood;
        public override bool IsMergeableSide => true;
        public override ItemValue ItemValue => ItemValue.SideSmall;
    }
}