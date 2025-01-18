using System.Collections.Generic;
using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using SwimmingSushiReborn.Utilies;
using UnityEngine;

namespace SwimmingSushiReborn.Customs.ItemGroups
{
    public class UnrolledCrab : CustomItemGroup
    {
        public override string UniqueNameID => "UnrolledCrab";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("UnrolledCrab").AssignMaterialsByNames();

        public override List<ItemGroup.ItemSet> Sets => new()
        {
            new ItemGroup.ItemSet
            {
                Items = new List<Item>
                {
                    GDOReferences.RiceSheet
                },
                Min = 1,
                Max = 1,
                IsMandatory = true
            },
            new ItemGroup.ItemSet
            {
                Items = new List<Item>
                {
                    GDOReferences.Mayonnaise,
                    GDOReferences.CrabChopped
                },
                Min = 2,
                Max = 2
            }
        };

        public override List<Item.ItemProcess> Processes => new()
        {
            new Item.ItemProcess
            {
                Process = GDOReferences.Roll,
                Duration = 2,
                Result = GDOReferences.RolledCrab
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
                        Item = GDOReferences.RiceSheet,
                        GameObject = gameDataObject.Prefab.GetChild("RiceSheet")
                    },
                    new()
                    {
                        Item = GDOReferences.Mayonnaise,
                        GameObject = gameDataObject.Prefab.GetChild("Mayonnaise")
                    },
                    new()
                    {
                        Item = GDOReferences.CrabChopped,
                        GameObject = gameDataObject.Prefab.GetChild("CrabChopped")
                    }
                };
            }
        }
    }
}