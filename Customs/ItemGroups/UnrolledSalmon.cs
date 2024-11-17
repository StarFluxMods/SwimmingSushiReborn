using System.Collections.Generic;
using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using UnityEngine;
using SwimmingSushi.Utilies;

namespace SwimmingSushi.Customs.ItemGroups
{
    public class UnrolledSalmon : CustomItemGroup
    {
        public override string UniqueNameID => "UnrolledSalmon";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("UnrolledSalmon").AssignMaterialsByNames();
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
                    GDOReferences.SalmonFillet,
                    GDOReferences.ChoppedAvocado
                },
                Min = 2,
                Max = 2
            }
        };
        public override List<Item.ItemProcess> Processes => new List<Item.ItemProcess>
        {
            new Item.ItemProcess
            {
                Process = GDOReferences.Cook,
                Duration = 2,
                Result = GDOReferences.RolledSalmon
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
                        Item = GDOReferences.SalmonFillet,
                        GameObject = gameDataObject.Prefab.GetChild("PlaceholderSalmonFillet")
                    },
                    new()
                    {
                        Item = GDOReferences.ChoppedAvocado,
                        GameObject = gameDataObject.Prefab.GetChild("PlaceholderAvocadoSlices")
                    }
                };
            }
        }
    }
}