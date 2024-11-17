using System.Collections.Generic;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using SwimmingSushi.Utilies;
using UnityEngine;

namespace SwimmingSushi.Customs.Items
{
    public class RolledSalmon : CustomItem
    {
        public override string UniqueNameID => "RolledSalmon";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("PlaceholderSushiRoll").AssignMaterialsByNames();
        public override List<Item.ItemProcess> Processes => new List<Item.ItemProcess>
        {
            new Item.ItemProcess
            {
                Process = GDOReferences.Chop,
                Duration = 2,
                Result = GDOReferences.ChoppedSalmonRoll
            }
        };
    }
}