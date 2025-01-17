using System.Collections.Generic;
using KitchenData;
using KitchenLib.Utils;
using SwimmingSushiReborn.Customs.Generic;
using SwimmingSushiReborn.Utilies;
using UnityEngine;

namespace SwimmingSushiReborn.Customs.Appliances
{
    public class GingerProvider : GenericProvider
    {
        public override Item ProvidedItem => GDOReferences.Ginger;
        public override string UniqueNameID => "GingerProvider";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("GingerProvider").AssignMaterialsByNames();
        public override List<(Locale, ApplianceInfo)> InfoList => CenteralLang.Appliances.GingerProvider;
    }
}