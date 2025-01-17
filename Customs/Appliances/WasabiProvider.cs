using System.Collections.Generic;
using KitchenData;
using KitchenLib.Utils;
using SwimmingSushiReborn.Customs.Generic;
using SwimmingSushiReborn.Utilies;
using UnityEngine;

namespace SwimmingSushiReborn.Customs.Appliances
{
    public class WasabiProvider : GenericProvider
    {
        public override Item ProvidedItem => GDOReferences.WasabiStem;
        public override string UniqueNameID => "WasabiProvider";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("WasabiProvider").AssignMaterialsByNames();
        public override List<(Locale, ApplianceInfo)> InfoList => CenteralLang.Appliances.WasabiProvider;
    }
}