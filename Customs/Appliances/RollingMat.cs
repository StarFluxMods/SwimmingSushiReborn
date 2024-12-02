using System.Collections.Generic;
using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using SwimmingSushiReborn.Utilies;
using UnityEngine;
using UnityEngine.UIElements;

namespace SwimmingSushiReborn.Customs.Appliances
{
    public class RollingMat : CustomAppliance
    {
        public override string UniqueNameID => "RollingMat";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("RollingMat").AssignMaterialsByNames();

        public override List<IApplianceProperty> Properties => new()
        {
            new CItemHolder()
        };

        public override List<Appliance.ApplianceProcesses> Processes => new()
        {
            new Appliance.ApplianceProcesses
            {
                Process = GDOReferences.Knead,
                Speed = 2f,
                Validity = ProcessValidity.Generic
            }
        };

        public override List<Process> RequiresProcessForShop => new List<Process>
        {
            GDOReferences.Knead
        };

        public override bool IsPurchasable => true;
        public override PriceTier PriceTier => PriceTier.Medium;
        public override ShoppingTags ShoppingTags => ShoppingTags.Cooking | ShoppingTags.Misc;
        public override List<(Locale, ApplianceInfo)> InfoList => CenteralLang.Appliances.RollingMat;

        public override void OnRegister(Appliance gameDataObject)
        {
            base.OnRegister(gameDataObject);

            HoldPointContainer holdPointContainer = gameDataObject.Prefab.AddComponent<HoldPointContainer>();
            holdPointContainer.HoldPoint = gameDataObject.Prefab.GetChild("Counter/Hold Point").transform;
        }
    }
}