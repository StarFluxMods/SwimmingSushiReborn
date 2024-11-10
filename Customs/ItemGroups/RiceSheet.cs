using System.Collections.Generic;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.References;
using KitchenLib.Utils;
using UnityEngine;

namespace SwimmingSushi.Customs.ItemGroups
{
    public class RiceSheet : CustomItemGroup
    {
        public override string UniqueNameID => "RiceSheet";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("RiceSheet").AssignMaterialsByNames();
        public override bool AutoCollapsing => true;
        public override List<ItemGroup.ItemSet> Sets => new()
        {
            new ItemGroup.ItemSet
            {
                Items = new List<Item>
                {
                    (Item)GDOUtils.GetExistingGDO(ItemReferences.Rice),
                    (Item)GDOUtils.GetCustomGameDataObject<Nori>().GameDataObject
                },
                Min = 2,
                Max = 2
            }
        };
    }
}