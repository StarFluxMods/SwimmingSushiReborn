using System.Collections.Generic;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using SwimmingSushiReborn.Utilies;
using UnityEngine;

namespace SwimmingSushiReborn.Customs.Dishes
{
    public class DishCrabRoll : CustomDish
    {
        public override string UniqueNameID => "DishCrabRoll";
        public override UnlockGroup UnlockGroup => UnlockGroup.Dish;
        public override CardType CardType => CardType.Default;
        public override DishCustomerChange CustomerMultiplier => DishCustomerChange.SmallDecrease;
        public override DishType Type => DishType.Base;
        public override int Difficulty => 3;

        public override List<string> StartingNameSet => new()
        {
            "Crabby But Happy",
            "Shell Yeah!",
            "Claws for Celebration",
            "Catch Me If You Crab",
            "The Reel Crabby Deal",
        };

        public override List<Dish> AlsoAddRecipes => new List<Dish>
        {
            GDOReferences.RecipeMayonnaise
        };

        public override HashSet<Item> MinimumIngredients => new()
        {
            GDOReferences.Plate,
            GDOReferences.Rice,
            GDOReferences.Nori,
            GDOReferences.Pot,
            GDOReferences.Water,
            GDOReferences.Egg,
            GDOReferences.Oil,
            GDOReferences.CrabRaw
        };

        public override HashSet<Process> RequiredProcesses => new()
        {
            GDOReferences.Cook,
            GDOReferences.Chop,
            GDOReferences.Knead,
            GDOReferences.Roll
        };

        public override GameObject IconPrefab => Mod.Bundle.LoadAsset<GameObject>("CrabRollIcon").AssignMaterialsByNames();
        
        public override List<Unlock> HardcodedRequirements => new List<Unlock>
        {
            GDOReferences.DishSalmonRoll
        };

        public override List<Dish.MenuItem> ResultingMenuItems => new()
        {
            new Dish.MenuItem
            {
                Item = GDOReferences.PlatedCrabRoll,
                Phase = MenuPhase.Main,
                Weight = 1,
                DynamicMenuType = DynamicMenuType.Static,
                DynamicMenuIngredient = null
            }
        };

        public override bool IsAvailableAsLobbyOption => Mod.ENABLE_ADDITIONAL_LOBBY_DISHES;
        public override List<(Locale, UnlockInfo)> InfoList => CenteralLang.Unlocks.CrabRoll;

        public override Dictionary<Locale, string> Recipe => CenteralLang.Recipes.CrabRoll;
    }
}