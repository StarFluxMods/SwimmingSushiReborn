using System.Collections.Generic;
using KitchenData;
using KitchenLib.Utils;
using SwimmingSushiReborn.Customs.Generic;
using SwimmingSushiReborn.Utilies;
using UnityEngine;

namespace SwimmingSushiReborn.Customs.ItemGroups
{
    public class PlatedSalmonRoll : GenericPlatedDish
    {
        public override string UniqueNameID => "PlatedSalmonRoll";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("PlatedSalmonRoll").AssignMaterialsByNames();
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
                    GDOReferences.PortionedSalmonRoll,
                },
                Min = 1,
                Max = 1
            }
        };

        public override ItemValue ItemValue => ItemValue.Medium;
    }
}