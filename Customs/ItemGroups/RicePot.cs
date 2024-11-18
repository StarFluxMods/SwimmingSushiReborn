using System.Collections.Generic;
using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using SwimmingSushi.Utilies;
using UnityEngine;

namespace SwimmingSushiReborn.Customs.ItemGroups
{
    public class RicePot : CustomItemGroup
    {
        public override string UniqueNameID => "RicePot";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("RicePot").AssignMaterialsByNames();
        public override List<ItemGroup.ItemSet> Sets => new()
        {
            new ItemGroup.ItemSet
            {
                Items = new List<Item>
                {
                    GDOReferences.Pot
                },
                Min = 1,
                Max = 1,
                IsMandatory = true
            },
            new ItemGroup.ItemSet
            {
                Items = new List<Item>
                {
                    GDOReferences.Water,
                    GDOReferences.Rice
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
                Result = GDOReferences.CookedRicePot
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
                        Item = GDOReferences.Rice,
                        GameObject = gameDataObject.Prefab.GetChild("Rice")
                    },
                    new()
                    {
                        Item = GDOReferences.Water,
                        GameObject = gameDataObject.Prefab.GetChild("Water")
                    }
                };
            }
        }
    }
}