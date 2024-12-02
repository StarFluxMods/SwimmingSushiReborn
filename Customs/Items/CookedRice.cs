using System.Collections.Generic;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using SwimmingSushiReborn.Utilies;
using UnityEngine;

namespace SwimmingSushiReborn.Customs.Items
{
    public class CookedRice : CustomItem
    {
        public override string UniqueNameID => "CookedRice";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("CookedRice").AssignMaterialsByNames();
        public override ItemStorage ItemStorageFlags => ItemStorage.StackableFood;

        public override List<Item.ItemProcess> Processes => new()
        {
            new Item.ItemProcess
            {
                Process = GDOReferences.Knead,
                Duration = 2,
                Result = GDOReferences.RiceBall
            }
        };
    }
}