using System.Collections.Generic;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using SwimmingSushi.Utilies;
using UnityEngine;

namespace SwimmingSushi.Customs.Items
{
    public class Salmon : CustomItem
    {
        public override string UniqueNameID => "Salmon";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("PlaceholderSalmon").AssignMaterialsByNames();
        public override List<Item.ItemProcess> Processes => new List<Item.ItemProcess>
        {
            new Item.ItemProcess
            {
                Process = GDOReferences.Chop,
                Duration = 1,
                Result = GDOReferences.SalmonFillet
            }
        };
    }
}