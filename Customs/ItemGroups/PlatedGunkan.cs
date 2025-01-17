using System.Collections.Generic;
using KitchenData;
using KitchenLib.Utils;
using SwimmingSushiReborn.Customs.Generic;
using SwimmingSushiReborn.Utilies;
using UnityEngine;

namespace SwimmingSushiReborn.Customs.ItemGroups
{
    public class PlatedGunkan : GenericPlatedDish
    {
        public override string UniqueNameID => "PlatedGunkan";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("PlatedGunkan").AssignMaterialsByNames();

        public override List<ItemGroup.ItemSet> Sets => new()
        {
            new ItemGroup.ItemSet
            {
                Items = new List<Item>
                {
                    GDOReferences.Plate,
                    GDOReferences.Gunkan
                },
                Min = 2,
                Max = 2,
                IsMandatory = true
            }
        };

        public override ItemValue ItemValue => ItemValue.SideMedium;
    }
}