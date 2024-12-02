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
    public class FishKnifeProvider : CustomAppliance
    {
        public override string UniqueNameID => "FishKnifeProvider";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("FishKnifeProvider").AssignMaterialsByNames();

        public override List<IApplianceProperty> Properties => new()
        {
            KitchenPropertiesUtils.GetCItemProvider(GDOReferences.FishKnife.ID, 1, 1, false, false, false, false, false, false, false)
        };

        public override bool SellOnlyAsDuplicate => true;
        public override bool IsPurchasable => true;
        public override PriceTier PriceTier => PriceTier.Medium;
        public override ShoppingTags ShoppingTags => ShoppingTags.Cooking | ShoppingTags.Misc;

        public override void OnRegister(Appliance gameDataObject)
        {
            base.OnRegister(gameDataObject);

            LimitedItemSourceView limitedItemSourceView = gameDataObject.Prefab.AddComponent<LimitedItemSourceView>();
            FieldInfo _Items = ReflectionUtils.GetField<LimitedItemSourceView>("Items");
            _Items.SetValue(limitedItemSourceView, new List<GameObject>
            {
                gameDataObject.Prefab.GetChild("FishKnife")
            });
        }

        public override List<(Locale, ApplianceInfo)> InfoList => CenteralLang.Appliances.FishKnifeProvider;
    }
}