using System.Collections.Generic;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using SwimmingSushi.Utilies;
using UnityEngine;

namespace SwimmingSushiReborn.Customs.ItemGroups
{
    public class PlatedSalmonRoll : CustomItemGroup
    {
        public override string UniqueNameID => "PlatedSalmonRoll";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("PlaceHolderPlatedSalmonRoll").AssignMaterialsByNames();
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

        public override Item DisposesTo => GDOReferences.Plate;
        public override Item DirtiesTo => GDOReferences.PlateDirty;
    }
}