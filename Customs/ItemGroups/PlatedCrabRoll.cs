using System.Collections.Generic;
using KitchenData;
using KitchenLib.Utils;
using SwimmingSushiReborn.Customs.Generic;
using SwimmingSushiReborn.Utilies;
using UnityEngine;

namespace SwimmingSushiReborn.Customs.ItemGroups
{
    public class PlatedCrabRoll : GenericPlatedDish
    {
        public override string UniqueNameID => "PlatedCrabRoll";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("PlatedCrabRoll").AssignMaterialsByNames();

        public override List<ItemGroup.ItemSet> Sets => new()
        {
            new ItemGroup.ItemSet
            {
                Items = new List<Item>
                {
                    GDOReferences.Plate,
                    GDOReferences.PortionedCrabRoll,
                },
                Min = 2,
                Max = 2,
                IsMandatory = true
            }
        };

        public override ItemValue ItemValue => ItemValue.MediumLarge;
    }
}