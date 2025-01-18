using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using UnityEngine;

namespace SwimmingSushiReborn.Customs.Items
{
    public class PortionedCrabRoll : CustomItem
    {
        public override string UniqueNameID => "PortionedCrabRoll";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("PortionedCrabRoll").AssignMaterialsByNames();
        public override ItemStorage ItemStorageFlags => ItemStorage.StackableFood;
    }
}