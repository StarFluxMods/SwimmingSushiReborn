using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using UnityEngine;

namespace SwimmingSushiReborn.Customs.Items
{
    public class RiceBall : CustomItem
    {
        public override string UniqueNameID => "RiceBall";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("RiceBall").AssignMaterialsByNames();
        public override ItemStorage ItemStorageFlags => ItemStorage.StackableFood;
    }
}