using System.Collections.Generic;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using SwimmingSushiReborn.Utilies;
using UnityEngine;

namespace SwimmingSushiReborn.Customs.ItemGroups
{
    public class Nigiri : CustomItemGroup
    {
        public override string UniqueNameID => "Nigiri";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("PlaceholderNigiri").AssignMaterialsByNames();
        public override bool AutoCollapsing => true;
        public override List<ItemGroup.ItemSet> Sets => new()
        {
            new ItemGroup.ItemSet
            {
                Items = new List<Item>
                {
                    GDOReferences.CookedRice,
                    GDOReferences.SalmonFillet
                },
                Min = 2,
                Max = 2
            }
        };
    }
}