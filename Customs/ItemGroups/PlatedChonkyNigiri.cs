using System.Collections.Generic;
using KitchenData;
using KitchenLib.Utils;
using SwimmingSushiReborn.Customs.Generic;
using SwimmingSushiReborn.Utilies;
using UnityEngine;

namespace SwimmingSushiReborn.Customs.ItemGroups
{
    public class PlatedChonkyNigiri : GenericPlatedDish
    {
        public override string UniqueNameID => "PlatedChonkyNigiri";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("PlatedChonkyNigiri").AssignMaterialsByNames();

        public override List<ItemGroup.ItemSet> Sets => new()
        {
            new ItemGroup.ItemSet
            {
                Items = new List<Item>
                {
                    GDOReferences.Plate,
                },
                Min = 1,
                Max = 1,
                IsMandatory = true
            },
            new ItemGroup.ItemSet
            {
                Items = new List<Item>
                {
                    GDOReferences.ChonkyNigiri
                },
                Min = 1,
                Max = 1
            }
        };

        public override ItemValue ItemValue => ItemValue.SideMedium;
    }
}