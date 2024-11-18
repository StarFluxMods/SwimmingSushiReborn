using KitchenData;
using KitchenLib.Utils;
using SwimmingSushi.Customs.Generic;
using SwimmingSushi.Utilies;
using UnityEngine;

namespace SwimmingSushiReborn.Customs.Appliances
{
    public class NoriProvider : GenericProvider
    {
        public override string ProvidedItemName => "Nori";
        public override Item ProvidedItem => GDOReferences.Nori;
        public override string UniqueNameID => "NoriProvider";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("NoriProvider").AssignMaterialsByNames();
    }
}