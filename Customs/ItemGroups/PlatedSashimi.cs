using System.Collections.Generic;
using KitchenData;
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
                    GDOReferences.Sashimi,
                },
                Min = 2,
                Max = 2,
                IsMandatory = true
            }
        };

        public override ItemValue ItemValue => ItemValue.Small;
    }
}