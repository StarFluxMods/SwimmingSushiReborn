using System.Collections.Generic;
using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.References;
using KitchenLib.Utils;
using SwimmingSushi.Customs.Items;
using UnityEngine;
using IngredientLib.Ingredient.Items;

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
                    (Item)GDOUtils.GetCustomGameDataObject<RiceSheet>().GameDataObject
                },
                Min = 1,
                Max = 1,
                IsMandatory = true
            },
            new ItemGroup.ItemSet
            {
                Items = new List<Item>
                {
                    (Item)GDOUtils.GetCustomGameDataObject<SalmonFillet>().GameDataObject,
                    (Item)GDOUtils.GetCustomGameDataObject<ChoppedAvocado>().GameDataObject
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
                Result = (Item)GDOUtils.GetCustomGameDataObject<RolledSalmon>().GameDataObject
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
                        Item = (Item)GDOUtils.GetCustomGameDataObject<RiceSheet>().GameDataObject,
                        GameObject = gameDataObject.Prefab.GetChild("RiceSheet")
                    },
                    new ItemGroupView.ComponentGroup
                    {
                        Item = (Item)GDOUtils.GetCustomGameDataObject<SalmonFillet>().GameDataObject,
                        GameObject = gameDataObject.Prefab.GetChild("PlaceholderSalmonFillet")
                    },
                    new ItemGroupView.ComponentGroup
                    {
                        Item = (Item)GDOUtils.GetCustomGameDataObject<ChoppedAvocado>().GameDataObject,
                        GameObject = gameDataObject.Prefab.GetChild("PlaceholderAvocadoSlices")
                    }
                };
            }
        }
    }
}