using System.Collections.Generic;
using KitchenData;
using KitchenLib.Utils;
using SwimmingSushiReborn.Customs.Generic;
using SwimmingSushiReborn.Utilies;
using UnityEngine;

namespace SwimmingSushiReborn.Customs.ItemGroups
{
    public class Onigiri : GenericFoodItemGroup
    {
        public override string UniqueNameID => "Onigiri";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("Onigiri").AssignMaterialsByNames();
        public override bool AutoCollapsing => true;
        public override List<ItemGroup.ItemSet> Sets => new()
        {
            new ItemGroup.ItemSet
            {
                Items = new List<Item>
                {
                    GDOReferences.CookedRice,
                    GDOReferences.SeaweedCooked
                },
                Min = 2,
                Max = 2
            }
        };
    }
}