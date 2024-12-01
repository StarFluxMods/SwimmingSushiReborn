using System.Collections.Generic;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using SwimmingSushiReborn.Utilies;
using UnityEngine;

namespace SwimmingSushiReborn.Customs.Dishes
{
    public class DishSoySauce : CustomDish
    {
        public override string UniqueNameID => "DishSoySauce";
        public override DishType Type => DishType.Extra;
        public override int Difficulty => 1;
        public override HashSet<Dish.IngredientUnlock> ExtraOrderUnlocks => new()
        {
            new Dish.IngredientUnlock
            {
                Ingredient = GDOReferences.CondimentSoySauce,
                MenuItem = GDOReferences.PlatedSalmonRoll
            },
            new Dish.IngredientUnlock
            {
                Ingredient = GDOReferences.CondimentSoySauce,
                MenuItem = GDOReferences.PlatedNigiri
            },
            new Dish.IngredientUnlock
            {
                Ingredient = GDOReferences.CondimentSoySauce,
                MenuItem = GDOReferences.PlatedOnigiri
            }
        };

        public override HashSet<Item> MinimumIngredients => new()
        {
            GDOReferences.CondimentSoySauce
        };
        public override GameObject IconPrefab => Mod.Bundle.LoadAsset<GameObject>("SoySauceIcon").AssignMaterialsByNames();

        public override DishCustomerChange CustomerMultiplier => DishCustomerChange.SmallDecrease;
        public override UnlockGroup UnlockGroup => UnlockGroup.Dish;
        public override CardType CardType => CardType.Default;
        public override List<Unlock> HardcodedRequirements => new List<Unlock>
        {
            GDOReferences.DishSalmonRoll
        };
        public override bool IsAvailableAsLobbyOption => Mod.ENABLE_ADDITIONAL_LOBBY_DISHES;
        public override List<(Locale, UnlockInfo)> InfoList => CenteralLang.Unlocks.SoySauce;

        public override Dictionary<Locale, string> Recipe => CenteralLang.Recipes.SoySauce;
    }
}