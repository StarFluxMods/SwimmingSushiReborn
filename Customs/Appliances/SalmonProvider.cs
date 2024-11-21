using KitchenData;
using KitchenLib.Utils;
using SwimmingSushiReborn.Customs.Generic;
using SwimmingSushiReborn.Utilies;
using UnityEngine;

namespace SwimmingSushiReborn.Customs.Appliances
{
    public class SalmonProvider : GenericProvider
    {
        public override string ProvidedItemName => "Salmon";
        public override Item ProvidedItem => GDOReferences.Salmon;
        public override string UniqueNameID => "SalmonProvider";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("SalmonProvider").AssignMaterialsByNames();
    }
}