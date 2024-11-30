using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using SwimmingSushiReborn.Utilies;
using UnityEngine;

namespace SwimmingSushiReborn.Customs.Items
{
    public class Roe : CustomItem
    {
        public override string UniqueNameID => "Roe";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("Roe").AssignMaterialsByNames();
        public override ItemStorage ItemStorageFlags => ItemStorage.StackableFood;
        public override Appliance DedicatedProvider => GDOReferences.RoeProvider;
    }
}