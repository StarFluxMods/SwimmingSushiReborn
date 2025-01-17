using System.Collections.Generic;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using SwimmingSushiReborn.Components;
using SwimmingSushiReborn.Utilies;
using SwimmingSushiReborn.Views;
using UnityEngine;

namespace SwimmingSushiReborn.Customs.Items
{
    public class Salmon : CustomItem
    {
        public override string UniqueNameID => "Salmon";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("Salmon").AssignMaterialsByNames();

        public override List<Item.ItemProcess> Processes => new()
        {
            new Item.ItemProcess
            {
                Process = GDOReferences.Chop,
                Duration = 1,
                Result = GDOReferences.SalmonFillet
            }
        };

        public override List<IItemProperty> Properties => new List<IItemProperty>
        {
            new CSalmon
            {
                IsInSink = false
            }
        };

        public override Appliance DedicatedProvider => GDOReferences.SalmonProvider;

        public override void OnRegister(Item gameDataObject)
        {
            base.OnRegister(gameDataObject);
            SalmonView salmonView = gameDataObject.Prefab.AddComponent<SalmonView>();
            salmonView.animator = gameDataObject.Prefab.GetComponentInChildren<Animator>();
        }
    }
}