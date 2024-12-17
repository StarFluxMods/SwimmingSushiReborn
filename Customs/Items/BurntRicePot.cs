using System.Collections.Generic;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using SwimmingSushiReborn.Utilies;
using UnityEngine;

namespace SwimmingSushiReborn.Customs.Items
{
    public class BurntRicePot : CustomItem
    {
        public override string UniqueNameID => "BurntRicePot";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("BurntRicePot").AssignMaterialsByNames();
        public override bool IsIndisposable => true;
        
        public override List<Item.ItemProcess> Processes => new()
        {
            new Item.ItemProcess
            {
                Process = GDOReferences.Clean,
                Duration = 2,
                Result = GDOReferences.Pot
            }
        };
    }
}