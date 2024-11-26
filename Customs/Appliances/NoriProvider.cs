using System.Collections.Generic;
using KitchenData;
using KitchenLib.Utils;
using SwimmingSushiReborn.Customs.Generic;
using SwimmingSushiReborn.Utilies;
using UnityEngine;

namespace SwimmingSushiReborn.Customs.Appliances
{
    public class NoriProvider : GenericProvider
    {
        public override Item ProvidedItem => GDOReferences.Nori;
        public override string UniqueNameID => "NoriProvider";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("NoriProvider").AssignMaterialsByNames();
        public override List<(Locale, ApplianceInfo)> InfoList => CenteralLang.Appliances.NoriProvider;
    }
}