using System.Collections.Generic;
using KitchenData;
using KitchenLib.Utils;
using SwimmingSushiReborn.Customs.Generic;
using SwimmingSushiReborn.Utilies;
using UnityEngine;

namespace SwimmingSushiReborn.Customs.Appliances
{
    public class RoeProvider : GenericProvider
    {
        public override Item ProvidedItem => GDOReferences.Roe;
        public override string UniqueNameID => "RoeProvider";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("RoeProvider").AssignMaterialsByNames();
        public override List<(Locale, ApplianceInfo)> InfoList => CenteralLang.Appliances.RoeProvider;
    }
}