using System.Collections.Generic;
using KitchenData;
using KitchenLib.Utils;
using SwimmingSushiReborn.Customs.Generic;
using SwimmingSushiReborn.Utilies;
using UnityEngine;

namespace SwimmingSushiReborn.Customs.Appliances
{
    public class SalmonProvider : GenericProvider
    {
        public override Item ProvidedItem => GDOReferences.Salmon;
        public override string UniqueNameID => "SalmonProvider";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("SalmonProvider").AssignMaterialsByNames();
        public override List<(Locale, ApplianceInfo)> InfoList => CenteralLang.Appliances.SalmonProvider;
    }
}