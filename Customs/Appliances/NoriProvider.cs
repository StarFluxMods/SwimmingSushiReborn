using System.Collections.Generic;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using SwimmingSushi.Customs.ItemGroups;
using UnityEngine;

namespace SwimmingSushi.Customs.Appliances
{
    public class NoriProvider : CustomAppliance
    {
        public override string UniqueNameID => "NoriProvider";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("NoriProvider").AssignMaterialsByNames();
        public override List<IApplianceProperty> Properties => new List<IApplianceProperty>
        {
            KitchenPropertiesUtils.GetUnlimitedCItemProvider(GDOUtils.GetCustomGameDataObject<Nori>().ID)
        };
    }
}