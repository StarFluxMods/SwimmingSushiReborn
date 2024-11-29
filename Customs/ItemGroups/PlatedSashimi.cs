using System.Collections.Generic;
using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using SwimmingSushiReborn.Customs.Generic;
using SwimmingSushiReborn.Utilies;
using UnityEngine;

namespace SwimmingSushiReborn.Customs.ItemGroups
{
    public class PlatedSashimi : GenericPlatedDish
    {
        public override string UniqueNameID => "PlatedSashimi";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("PlatedSashimi").AssignMaterialsByNames();
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
                    GDOReferences.Sashimi,
                },
                Min = 1,
                Max = 1,
            }
        };
        public override ItemValue ItemValue => ItemValue.SideMedium;
    }
}