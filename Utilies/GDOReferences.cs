using IngredientLib.Ingredient.Items;
using KitchenData;
using KitchenLib.References;
using KitchenLib.Utils;
using SwimmingSushi.Customs.Appliances;
using SwimmingSushi.Customs.ItemGroups;
using SwimmingSushi.Customs.Items;

namespace SwimmingSushiReborn.Utilies
{
    public static class GDOReferences
    {
        #region IngredientLib

        #region Items

        public static Item Avocado => (Item)GDOUtils.GetCustomGameDataObject<Avocado>().GameDataObject;
        public static Item ChoppedAvocado => (Item)GDOUtils.GetCustomGameDataObject<ChoppedAvocado>().GameDataObject;

        #endregion

        #endregion
        

        #region Vanilla
        
        #region Processes
        
        public static Process Cook => (Process)GDOUtils.GetExistingGDO(ProcessReferences.Cook);
        public static Process Chop => (Process)GDOUtils.GetExistingGDO(ProcessReferences.Chop);
        public static Process Knead => (Process)GDOUtils.GetExistingGDO(ProcessReferences.Knead);
        
        #endregion

        #region Items
        
        public static Item SeaweedCooked => (Item)GDOUtils.GetExistingGDO(ItemReferences.SeaweedCooked);
        public static Item Seaweed => (Item)GDOUtils.GetExistingGDO(ItemReferences.Seaweed);
        public static Item Pot => (Item)GDOUtils.GetExistingGDO(ItemReferences.Pot);
        public static Item Rice => (Item)GDOUtils.GetExistingGDO(ItemReferences.Rice);
        public static Item Water => (Item)GDOUtils.GetExistingGDO(ItemReferences.Water);
        public static Item Plate => (Item)GDOUtils.GetExistingGDO(ItemReferences.Plate);
        public static Item PlateDirty => (Item)GDOUtils.GetExistingGDO(ItemReferences.PlateDirty);
        
        #endregion
        
        #endregion

        
        #region Appliances

        public static Appliance NoriProvider => (Appliance)GDOUtils.GetCustomGameDataObject<NoriProvider>().GameDataObject;
        public static Appliance SalmonProvider => (Appliance)GDOUtils.GetCustomGameDataObject<SalmonProvider>().GameDataObject;

        #endregion
        
        #region ItemGroups
        
        public static ItemGroup Nori => (ItemGroup)GDOUtils.GetCustomGameDataObject<Nori>().GameDataObject;
        public static ItemGroup RicePot => (ItemGroup)GDOUtils.GetCustomGameDataObject<RicePot>().GameDataObject;
        public static ItemGroup RiceSheet => (ItemGroup)GDOUtils.GetCustomGameDataObject<RiceSheet>().GameDataObject;
        public static ItemGroup UnrolledSalmon => (ItemGroup)GDOUtils.GetCustomGameDataObject<UnrolledSalmon>().GameDataObject;
        public static ItemGroup PlatedSalmonRoll => (ItemGroup)GDOUtils.GetCustomGameDataObject<PlatedSalmonRoll>().GameDataObject;

        #endregion

        #region Items

        public static Item ChoppedSalmonRoll => (Item)GDOUtils.GetCustomGameDataObject<ChoppedSalmonRoll>().GameDataObject;
        public static Item CookedRice => (Item)GDOUtils.GetCustomGameDataObject<CookedRice>().GameDataObject;
        public static Item CookedRicePot => (Item)GDOUtils.GetCustomGameDataObject<CookedRicePot>().GameDataObject;
        public static Item PortionedSalmonRoll => (Item)GDOUtils.GetCustomGameDataObject<PortionedSalmonRoll>().GameDataObject;
        public static Item RolledSalmon => (Item)GDOUtils.GetCustomGameDataObject<RolledSalmon>().GameDataObject;
        public static Item Salmon => (Item)GDOUtils.GetCustomGameDataObject<Salmon>().GameDataObject;
        public static Item SalmonFillet => (Item)GDOUtils.GetCustomGameDataObject<SalmonFillet>().GameDataObject;

        #endregion
        
    }
}