using System.Collections.Generic;
using Kitchen;
using KitchenData;
using KitchenLib.Utils;
using SwimmingSushiReborn.Customs.Generic;
using SwimmingSushiReborn.Utilies;
using UnityEngine;

namespace SwimmingSushiReborn.Customs.ItemGroups
{
    public class ChonkyNigiri : GenericFoodItemGroup
    {
        public override string UniqueNameID => "ChonkyNigiri";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("ChonkyNigiri").AssignMaterialsByNames();

        public override List<ItemGroup.ItemSet> Sets => new()
        {
            new ItemGroup.ItemSet
            {
                Items = new List<Item>
                {
                    GDOReferences.RiceBall,
                    GDOReferences.RiceBall
                },
                Min = 2,
                Max = 2,
                IsMandatory = true
            },
            new ItemGroup.ItemSet
            {
                Items = new List<Item>
                {
                    GDOReferences.SalmonFillet
                },
                Min = 1,
                Max = 1,
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
                        Item = GDOReferences.RiceBall,
                        GameObject = gameDataObject.Prefab.GetChild("Nigiri/Nigiri/Rice")
                    },
                    new()
                    {
                        Item = GDOReferences.SalmonFillet,
                        GameObject = gameDataObject.Prefab.GetChild("Nigiri/Nigiri/Salmon")
                    }
                };
            }
        }
    }
}