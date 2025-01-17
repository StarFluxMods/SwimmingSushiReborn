using System.Collections.Generic;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using SwimmingSushiReborn.Utilies;
using UnityEngine;

namespace SwimmingSushiReborn.Customs.Items
{
    public class WasabiStem : CustomItem
    {
        public override string UniqueNameID => "WasabiStem";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("WasabiStem").AssignMaterialsByNames();
        public override ItemStorage ItemStorageFlags => ItemStorage.StackableFood;

        public override List<Item.ItemProcess> Processes => new()
        {
            new Item.ItemProcess
            {
                Process = GDOReferences.Chop,
                Duration = 1,
                Result = GDOReferences.Wasabi
            }
        };

        public override Appliance DedicatedProvider => GDOReferences.WasabiProvider;
    }
}