using System.Collections.Generic;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using SwimmingSushi.Customs.ItemGroups;
using SwimmingSushi.Customs.Items;
using UnityEngine;

namespace SwimmingSushi.Customs.Appliances
{
    public class SalmonProvider : CustomAppliance
    {
        public override string UniqueNameID => "SalmonProvider";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("PlaceholderSalmonProvider").AssignMaterialsByNames();
        public override List<IApplianceProperty> Properties => new List<IApplianceProperty>
        {
            KitchenPropertiesUtils.GetUnlimitedCItemProvider(GDOUtils.GetCustomGameDataObject<Salmon>().ID)
        };
    }
}