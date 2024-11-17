using System.Collections.Generic;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using SwimmingSushi.Utilies;
using UnityEngine;

namespace SwimmingSushi.Customs.Items
{
    public class ChoppedSalmonRoll : CustomItem
    {
        public override string UniqueNameID => "ChoppedSalmonRoll";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("PlaceholderChoppedSalmonRoll").AssignMaterialsByNames();
        public override int SplitCount => 3;
        public override List<Item> SplitDepletedItems => new List<Item>
        {
            GDOReferences.PortionedSalmonRoll
        };

        public override Item SplitSubItem => GDOReferences.PortionedSalmonRoll;
    }
}