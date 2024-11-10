using System.Collections.Generic;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.References;
using KitchenLib.Utils;
using UnityEngine;

namespace SwimmingSushi.Customs.ItemGroups
{
    public class Nori : CustomItemGroup
    {
        public override string UniqueNameID => "Nori";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("Nori").AssignMaterialsByNames();
        public override bool AutoCollapsing => true;
        public override List<ItemGroup.ItemSet> Sets => new()
        {
            new ItemGroup.ItemSet
            {
                Items = new List<Item>
                {
                    (Item)GDOUtils.GetExistingGDO(ItemReferences.SeaweedCooked),
                    (Item)GDOUtils.GetExistingGDO(ItemReferences.SeaweedCooked)
                },
                Min = 2,
                Max = 2
            }
        };
    }
}