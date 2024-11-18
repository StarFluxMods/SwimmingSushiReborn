using System.Collections.Generic;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;

namespace SwimmingSushiReborn.Customs.Generic
{
    public abstract class GenericProvider : CustomAppliance
    {
        public abstract string ProvidedItemName { get; }
        public abstract Item ProvidedItem { get; }
        
        public override List<IApplianceProperty> Properties => new()
        {
            KitchenPropertiesUtils.GetUnlimitedCItemProvider(ProvidedItem.ID)
        };
        public override bool SellOnlyAsDuplicate => true;
        public override bool IsPurchasable => true;
        public override PriceTier PriceTier => PriceTier.Medium;
        public override ShoppingTags ShoppingTags => ShoppingTags.Cooking | ShoppingTags.Misc;
        public override List<(Locale, ApplianceInfo)> InfoList => new()
        {
            (Locale.English, new ApplianceInfo
            {
                Name = ProvidedItemName,
                Description = "Provides " + ProvidedItemName,
                
            })
        };
    }
}