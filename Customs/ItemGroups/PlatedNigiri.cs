using System.Collections.Generic;
using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using SwimmingSushiReborn.Customs.Generic;
using SwimmingSushiReborn.Utilies;
using UnityEngine;

namespace SwimmingSushiReborn.Customs.ItemGroups
{
    public class PlatedNigiri : GenericPlatedDish
    {
        public override string UniqueNameID => "PlatedNigiri";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("PlatedNigiri").AssignMaterialsByNames();
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
                    GDOReferences.Nigiri,
                    GDOReferences.Nigiri,
                },
                Min = 1,
                Max = 2,
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
                        Item = GDOReferences.Nigiri,
                        Objects = new List<GameObject>
                        {
                            gameDataObject.Prefab.GetChild("Nigiri 1"),
                            gameDataObject.Prefab.GetChild("Nigiri 2")
                        }
                    }
                };
            }
        }
        public override ItemValue ItemValue => ItemValue.SideMedium;
    }
}