using System.Collections.Generic;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using SwimmingSushiReborn.Utilies;
using UnityEngine;

namespace SwimmingSushiReborn.Customs.ItemGroups
{
    public class Nori : CustomItemGroup
    {
        public override string UniqueNameID => "Nori";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("Nori").AssignMaterialsByNames();
        public override bool AutoCollapsing => true;
        public override List<ItemGroup.ItemSet> Sets => new()
        {
            new ItemGroup.ItemSet
            {
                Items = new List<Item>
                {
                    GDOReferences.SeaweedCooked,
                    GDOReferences.SeaweedCooked
                },
                Min = 2,
                Max = 2
            }
        };

        public override Appliance DedicatedProvider => GDOReferences.NoriProvider;
    }
}