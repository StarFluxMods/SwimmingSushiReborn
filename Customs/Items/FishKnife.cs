using System.Collections.Generic;
using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using SwimmingSushiReborn.Utilies;
using UnityEngine;

namespace SwimmingSushiReborn.Customs.Items
{
    public class FishKnife : CustomItem
    {
        public override string UniqueNameID => "FishKnife";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("FishKnife").AssignMaterialsByNames();

        public override List<IItemProperty> Properties => new List<IItemProperty>
        {
            new CEquippableTool
            {
                CanHoldItems = true
            }
        };

        public override ToolAttachPoint HoldPose => ToolAttachPoint.Hand;
        public override Appliance DedicatedProvider => GDOReferences.FishKnifeProvider;
        public override bool IsIndisposable => true;
    }
}