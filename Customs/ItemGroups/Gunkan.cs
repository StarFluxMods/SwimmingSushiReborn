using System.Collections.Generic;
using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using SwimmingSushiReborn.Utilies;
using UnityEngine;

namespace SwimmingSushiReborn.Customs.ItemGroups
{
    public class Gunkan : CustomItemGroup
    {
        public override string UniqueNameID => "Gunkan";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("Gunkan").AssignMaterialsByNames();

        public override List<ItemGroup.ItemSet> Sets => new()
        {
            new ItemGroup.ItemSet
            {
                Items = new List<Item>
                {
                    GDOReferences.SeaweedCooked,
                    GDOReferences.CookedRice
                },
                Min = 2,
                Max = 2,
                IsMandatory = true
            },
            new ItemGroup.ItemSet
            {
                Items = new List<Item>
                {
                    GDOReferences.Roe
                },
                Min = 1,
                Max = 1
            }
        };

        public override void OnRegister(ItemGroup gameDataObject)
        {
            base.OnRegister(gameDataObject);

            if (gameDataObject.Prefab.TryGetComponent(out ItemGroupView itemGroupView))
            {
                itemGroupView.ComponentGroups = new List<ItemGroupView.ComponentGroup>
                {
                    new()
                    {
                        Item = GDOReferences.SeaweedCooked,
                        GameObject = gameDataObject.Prefab.GetChild("Gunkan/Seaweed")
                    },
                    new()
                    {
                        Item = GDOReferences.CookedRice,
                        GameObject = gameDataObject.Prefab.GetChild("Gunkan/Rice")
                    },
                    new()
                    {
                        Item = GDOReferences.Roe,
                        GameObject = gameDataObject.Prefab.GetChild("Gunkan/Roe")
                    }
                };
            }
        }
    }
}