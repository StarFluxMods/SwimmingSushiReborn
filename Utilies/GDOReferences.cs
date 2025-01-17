using IngredientLib.Ingredient.Items;
using KitchenData;
using KitchenLib.References;
using KitchenLib.Utils;
using SwimmingSushiReborn.Customs.Appliances;
using SwimmingSushiReborn.Customs.Decor;
using SwimmingSushiReborn.Customs.Dishes;
using SwimmingSushiReborn.Customs.ItemGroups;
using SwimmingSushiReborn.Customs.Items;
using SwimmingSushiReborn.Customs.PlayerCosmetics;
using SwimmingSushiReborn.Customs.Processes;

namespace SwimmingSushiReborn.Utilies
{
    public static class GDOReferences
    {
        #region IngredientLib

        #region Item

        public static Item Avocado => (Item)GDOUtils.GetCustomGameDataObject<Avocado>().GameDataObject;
        public static Item ChoppedAvocado => (Item)GDOUtils.GetCustomGameDataObject<ChoppedAvocado>().GameDataObject;

        #endregion

        #endregion


        #region Vanilla

        #region Process

        public static Process Cook => (Process)GDOUtils.GetExistingGDO(ProcessReferences.Cook);
        public static Process Chop => (Process)GDOUtils.GetExistingGDO(ProcessReferences.Chop);
        public static Process Knead => (Process)GDOUtils.GetExistingGDO(ProcessReferences.Knead);
        public static Process Clean => (Process)GDOUtils.GetExistingGDO(ProcessReferences.Clean);

        #endregion

        #region Item

        public static Item SeaweedCooked => (Item)GDOUtils.GetExistingGDO(ItemReferences.SeaweedCooked);
        public static Item Seaweed => (Item)GDOUtils.GetExistingGDO(ItemReferences.Seaweed);
        public static Item Pot => (Item)GDOUtils.GetExistingGDO(ItemReferences.Pot);
        public static Item Rice => (Item)GDOUtils.GetExistingGDO(ItemReferences.Rice);
        public static Item Water => (Item)GDOUtils.GetExistingGDO(ItemReferences.Water);
        public static Item Plate => (Item)GDOUtils.GetExistingGDO(ItemReferences.Plate);
        public static Item PlateDirty => (Item)GDOUtils.GetExistingGDO(ItemReferences.PlateDirty);
        public static Item CondimentSoySauce => (Item)GDOUtils.GetExistingGDO(ItemReferences.CondimentSoySauce);

        #endregion

        #region Appliance

        public static Appliance Countertop => (Appliance)GDOUtils.GetExistingGDO(ApplianceReferences.Countertop);
        public static Appliance WallpaperApplicator => (Appliance)GDOUtils.GetExistingGDO(ApplianceReferences.WallpaperApplicator);
        public static Appliance FlooringApplicator => (Appliance)GDOUtils.GetExistingGDO(ApplianceReferences.FlooringApplicator);

        #endregion

        #endregion

        #region Process

        public static Process Roll => (Process)GDOUtils.GetCustomGameDataObject<Roll>().GameDataObject;

        #endregion

        #region PlayerCosmetic

        public static PlayerCosmetic JapaneseBandana => (PlayerCosmetic)GDOUtils.GetCustomGameDataObject<JapaneseBandana>().GameDataObject;
        public static PlayerCosmetic NigiriCostume => (PlayerCosmetic)GDOUtils.GetCustomGameDataObject<NigiriCostume>().GameDataObject;

        #endregion

        #region Item

        public static Item BurntRicePot => (Item)GDOUtils.GetCustomGameDataObject<BurntRicePot>().GameDataObject;
        public static Item ChoppedSalmonRoll => (Item)GDOUtils.GetCustomGameDataObject<ChoppedSalmonRoll>().GameDataObject;
        public static Item CookedRice => (Item)GDOUtils.GetCustomGameDataObject<CookedRice>().GameDataObject;
        public static Item CookedRicePot => (Item)GDOUtils.GetCustomGameDataObject<CookedRicePot>().GameDataObject;
        public static Item FishKnife => (Item)GDOUtils.GetCustomGameDataObject<FishKnife>().GameDataObject;
        public static Item PortionedSalmonRoll => (Item)GDOUtils.GetCustomGameDataObject<PortionedSalmonRoll>().GameDataObject;
        public static Item RiceBall => (Item)GDOUtils.GetCustomGameDataObject<RiceBall>().GameDataObject;
        public static Item Ginger => (Item)GDOUtils.GetCustomGameDataObject<Ginger>().GameDataObject;
        public static Item GingerPortion => (Item)GDOUtils.GetCustomGameDataObject<GingerPortion>().GameDataObject;
        public static Item Roe => (Item)GDOUtils.GetCustomGameDataObject<Roe>().GameDataObject;
        public static Item RolledSalmon => (Item)GDOUtils.GetCustomGameDataObject<RolledSalmon>().GameDataObject;
        public static Item Salmon => (Item)GDOUtils.GetCustomGameDataObject<Salmon>().GameDataObject;
        public static Item SalmonFillet => (Item)GDOUtils.GetCustomGameDataObject<SalmonFillet>().GameDataObject;
        public static Item SalmonWithRoe => (Item)GDOUtils.GetCustomGameDataObject<SalmonWithRoe>().GameDataObject;
        public static Item Sashimi => (Item)GDOUtils.GetCustomGameDataObject<Sashimi>().GameDataObject;

        #endregion

        #region ItemGroup

        public static ItemGroup ChonkyNigiri => (ItemGroup)GDOUtils.GetCustomGameDataObject<ChonkyNigiri>().GameDataObject;
        public static ItemGroup Gunkan => (ItemGroup)GDOUtils.GetCustomGameDataObject<Gunkan>().GameDataObject;
        public static ItemGroup Nigiri => (ItemGroup)GDOUtils.GetCustomGameDataObject<Nigiri>().GameDataObject;
        public static ItemGroup Nori => (ItemGroup)GDOUtils.GetCustomGameDataObject<Nori>().GameDataObject;
        public static ItemGroup Onigiri => (ItemGroup)GDOUtils.GetCustomGameDataObject<Onigiri>().GameDataObject;
        public static ItemGroup PlatedChonkyNigiri => (ItemGroup)GDOUtils.GetCustomGameDataObject<PlatedChonkyNigiri>().GameDataObject;
        public static ItemGroup PlatedGunkan => (ItemGroup)GDOUtils.GetCustomGameDataObject<PlatedGunkan>().GameDataObject;
        public static ItemGroup PlatedNigiri => (ItemGroup)GDOUtils.GetCustomGameDataObject<PlatedNigiri>().GameDataObject;
        public static ItemGroup PlatedOnigiri => (ItemGroup)GDOUtils.GetCustomGameDataObject<PlatedOnigiri>().GameDataObject;
        public static ItemGroup PlatedSalmonRoll => (ItemGroup)GDOUtils.GetCustomGameDataObject<PlatedSalmonRoll>().GameDataObject;
        public static ItemGroup PlatedSashimi => (ItemGroup)GDOUtils.GetCustomGameDataObject<PlatedSashimi>().GameDataObject;
        public static ItemGroup RicePot => (ItemGroup)GDOUtils.GetCustomGameDataObject<RicePot>().GameDataObject;
        public static ItemGroup RiceSheet => (ItemGroup)GDOUtils.GetCustomGameDataObject<RiceSheet>().GameDataObject;
        public static ItemGroup UnrolledSalmon => (ItemGroup)GDOUtils.GetCustomGameDataObject<UnrolledSalmon>().GameDataObject;

        #endregion

        #region Dish

        public static Dish DishChonkyNigiri => (Dish)GDOUtils.GetCustomGameDataObject<DishChonkyNigiri>().GameDataObject;
        public static Dish DishFreshNori => (Dish)GDOUtils.GetCustomGameDataObject<DishFreshNori>().GameDataObject;
        public static Dish DishFreshRoe => (Dish)GDOUtils.GetCustomGameDataObject<DishFreshRoe>().GameDataObject;
        public static Dish DishGunkan => (Dish)GDOUtils.GetCustomGameDataObject<DishGunkan>().GameDataObject;
        public static Dish DishNigiri => (Dish)GDOUtils.GetCustomGameDataObject<DishNigiri>().GameDataObject;
        public static Dish DishOnigiri => (Dish)GDOUtils.GetCustomGameDataObject<DishOnigiri>().GameDataObject;
        public static Dish DishSalmonRoll => (Dish)GDOUtils.GetCustomGameDataObject<DishSalmonRoll>().GameDataObject;
        public static Dish DishSashimi => (Dish)GDOUtils.GetCustomGameDataObject<DishSashimi>().GameDataObject;
        public static Dish DishSoySauce => (Dish)GDOUtils.GetCustomGameDataObject<DishSoySauce>().GameDataObject;

        #endregion

        #region Decor

        public static Decor SandFloor => (Decor)GDOUtils.GetCustomGameDataObject<SandFloor>().GameDataObject;
        public static Decor WallpaperBubbles => (Decor)GDOUtils.GetCustomGameDataObject<WallpaperBubbles>().GameDataObject;
        public static Decor WallpaperSeaweed => (Decor)GDOUtils.GetCustomGameDataObject<WallpaperSeaweed>().GameDataObject;

        #endregion

        #region Appliance

        public static Appliance FishDisplayBoard => (Appliance)GDOUtils.GetCustomGameDataObject<FishDisplayBoard>().GameDataObject;
        public static Appliance FishKnifeProvider => (Appliance)GDOUtils.GetCustomGameDataObject<FishKnifeProvider>().GameDataObject;
        public static Appliance FishTank => (Appliance)GDOUtils.GetCustomGameDataObject<FishTank>().GameDataObject;
        public static Appliance HangingLamp => (Appliance)GDOUtils.GetCustomGameDataObject<HangingLamp>().GameDataObject;
        public static Appliance NoriProvider => (Appliance)GDOUtils.GetCustomGameDataObject<NoriProvider>().GameDataObject;
        public static Appliance RoeProvider => (Appliance)GDOUtils.GetCustomGameDataObject<RoeProvider>().GameDataObject;
        public static Appliance RollingMachine => (Appliance)GDOUtils.GetCustomGameDataObject<RollingMachine>().GameDataObject;
        public static Appliance SalmonProvider => (Appliance)GDOUtils.GetCustomGameDataObject<SalmonProvider>().GameDataObject;
        public static Appliance SushiNeonSign => (Appliance)GDOUtils.GetCustomGameDataObject<SushiNeonSign>().GameDataObject;
        public static Appliance SushiTextNeonSign => (Appliance)GDOUtils.GetCustomGameDataObject<SushiTextNeonSign>().GameDataObject;

        #endregion
    }
}