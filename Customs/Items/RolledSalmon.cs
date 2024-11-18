using System.Collections.Generic;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using SwimmingSushiReborn.Utilies;
using UnityEngine;

namespace SwimmingSushiReborn.Customs.Items
{
    public class RolledSalmon : CustomItem
    {
        public override string UniqueNameID => "RolledSalmon";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("RolledSalmon").AssignMaterialsByNames();

        public override List<Item.ItemProcess> Processes => new()
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