using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using UnityEngine;

namespace SwimmingSushiReborn.Customs.Items
{
    public class Sashimi : CustomItem
    {
        public override string UniqueNameID => "Sashimi";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("Sashimi").AssignMaterialsByNames();
        public override ItemStorage ItemStorageFlags => ItemStorage.StackableFood;
    }
}