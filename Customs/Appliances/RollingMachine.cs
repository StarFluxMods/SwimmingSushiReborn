using System.Collections.Generic;
using System.Reflection;
using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using SwimmingSushiReborn.Utilies;
using UnityEngine;

namespace SwimmingSushiReborn.Customs.Appliances
{
    public class RollingMachine : CustomAppliance
    {
        public override string UniqueNameID => "RollingMachine";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("RollingMachine").AssignMaterialsByNames();

        public override List<Appliance.ApplianceProcesses> Processes => new()
        {
            new Appliance.ApplianceProcesses
            {
                Process = GDOReferences.Roll,
                Speed = 2,
                Validity = ProcessValidity.Generic,
                IsAutomatic = true
            }
        };

        public override List<IApplianceProperty> Properties => new()
        {
            new CItemHolder()
        };

        public override bool IsPurchasable => true;
        public override PriceTier PriceTier => PriceTier.Medium;

        public override ShoppingTags ShoppingTags => ShoppingTags.Basic | ShoppingTags.Cooking | ShoppingTags.Automation;

        public override List<Process> RequiresProcessForShop => new()
        {
            GDOReferences.Roll
        };

        public override List<(Locale, ApplianceInfo)> InfoList => CenteralLang.Appliances.RollingMachine;

        public override void OnRegister(Appliance gameDataObject)
        {
            base.OnRegister(gameDataObject);
            HoldPointContainer holdPointContainer = gameDataObject.Prefab.AddComponent<HoldPointContainer>();
            holdPointContainer.HoldPoint = gameDataObject.Prefab.GetChild("Hold Point").transform;

            ApplianceProcessView applianceProcessView = gameDataObject.Prefab.AddComponent<ApplianceProcessView>();
            FieldInfo _Animator = ReflectionUtils.GetField<ApplianceProcessView>("Animator");
            _Animator.SetValue(applianceProcessView, gameDataObject.Prefab.GetComponent<Animator>());
        }
    }
}