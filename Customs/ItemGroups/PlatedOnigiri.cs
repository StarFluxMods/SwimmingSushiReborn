using System.Collections.Generic;
using KitchenData;
using KitchenLib.Utils;
using SwimmingSushiReborn.Customs.Generic;
using SwimmingSushiReborn.Utilies;
using UnityEngine;

namespace SwimmingSushiReborn.Customs.ItemGroups
{
    public class PlatedOnigiri : GenericPlatedDish
    {
        public override string UniqueNameID => "PlatedOnigiri";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("PlatedOnigiri").AssignMaterialsByNames();

        public override List<ItemGroup.ItemSet> Sets => new()
        {
            new ItemGroup.ItemSet
            {
                Items = new List<Item>
                {
                    GDOReferences.Plate,
                    GDOReferences.Onigiri,
                },
                Min = 2,
                Max = 2,
                IsMandatory = true
            },
        };

        public override ItemValue ItemValue => ItemValue.SideMedium;
    }
}