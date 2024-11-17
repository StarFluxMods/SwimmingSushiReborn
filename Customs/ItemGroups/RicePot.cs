using System.Collections.Generic;
using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.References;
using KitchenLib.Utils;
using SwimmingSushi.Customs.Items;
using UnityEngine;

namespace SwimmingSushi.Customs.ItemGroups
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
                    (Item)GDOUtils.GetExistingGDO(ItemReferences.Pot),
                },
                Min = 1,
                Max = 1,
                IsMandatory = true
            },
            new ItemGroup.ItemSet
            {
                Items = new List<Item>
                {
                    (Item)GDOUtils.GetExistingGDO(ItemReferences.Water),
                    (Item)GDOUtils.GetExistingGDO(ItemReferences.Rice),
                },
                Min = 2,
                Max = 2
            }
        };
        public override List<Item.ItemProcess> Processes => new List<Item.ItemProcess>
        {
            new Item.ItemProcess
            {
                Process = (Process)GDOUtils.GetExistingGDO(ProcessReferences.Cook),
                Duration = 2,
                Result = (Item)GDOUtils.GetCustomGameDataObject<CookedRicePot>().GameDataObject
            }
        };

        public override void OnRegister(ItemGroup gameDataObject)
        {
            base.OnRegister(gameDataObject);

            if (gameDataObject.Prefab.TryGetComponent<ItemGroupView>(out ItemGroupView itemGroupView))
            {
                itemGroupView.ComponentGroups = new List<ItemGroupView.ComponentGroup>
                {
                    new ItemGroupView.ComponentGroup
                    {
                        Item = (Item)GDOUtils.GetExistingGDO(ItemReferences.Rice),
                        GameObject = gameDataObject.Prefab.GetChild("Rice")
                    },
                    new ItemGroupView.ComponentGroup
                    {
                        Item = (Item)GDOUtils.GetExistingGDO(ItemReferences.Water),
                        GameObject = gameDataObject.Prefab.GetChild("Water")
                    }
                };
            }
        }
    }
}