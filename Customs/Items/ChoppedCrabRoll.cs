using System.Collections.Generic;
using System.Reflection;
using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using SwimmingSushiReborn.Utilies;
using UnityEngine;

namespace SwimmingSushiReborn.Customs.Items
{
    public class ChoppedCrabRoll : CustomItem
    {
        public override string UniqueNameID => "ChoppedCrabRoll";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("ChoppedCrabRoll").AssignMaterialsByNames();
        public override int SplitCount => 1;

        public override List<Item> SplitDepletedItems => new()
        {
            GDOReferences.PortionedCrabRoll
        };

        public override Item SplitSubItem => GDOReferences.PortionedCrabRoll;
    }
}