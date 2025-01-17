using System.Collections.Generic;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using SwimmingSushiReborn.Utilies;
using UnityEngine;

namespace SwimmingSushiReborn.Customs.Items
{
    public class GingerPortion : CustomItem
    {
        public override string UniqueNameID => "GingerPortion";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("GingerPortion").AssignMaterialsByNames();
        public override ItemStorage ItemStorageFlags => ItemStorage.StackableFood;
        public override bool IsMergeableSide => true;
        public override ItemValue ItemValue => ItemValue.SideSmall;
    }
}