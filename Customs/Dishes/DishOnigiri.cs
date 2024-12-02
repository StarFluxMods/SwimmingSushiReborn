using System.Collections.Generic;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using SwimmingSushiReborn.Utilies;
using UnityEngine;

namespace SwimmingSushiReborn.Customs.Dishes
{
    public class DishOnigiri : CustomDish
    {
        public override string UniqueNameID => "DishOnigiri";
        public override UnlockGroup UnlockGroup => UnlockGroup.Dish;
        public override CardType CardType => CardType.Default;
        public override DishCustomerChange CustomerMultiplier => DishCustomerChange.SmallDecrease;
        public override DishType Type => DishType.Main;
        public override int Difficulty => 2;

        public override List<string> StartingNameSet => new()
        {
            "Tri Me!",
            "It's Onigiri-licious",
            "O-nice to Meet You!",
            "Shape of Rice",
            "Grab and Go-rice"
        };

        public override HashSet<Item> MinimumIngredients => new()
        {
            GDOReferences.Plate,
            GDOReferences.Rice,
            GDOReferences.Pot,
            GDOReferences.Water,
            GDOReferences.Seaweed
        };

        public override HashSet<Process> RequiredProcesses => new()
        {
            GDOReferences.Cook,
            GDOReferences.Knead
        };

        public override GameObject IconPrefab => Mod.Bundle.LoadAsset<GameObject>("OnigiriIcon").AssignMaterialsByNames();

        public override List<Dish.MenuItem> ResultingMenuItems => new()
        {
            new Dish.MenuItem
            {
                Item = GDOReferences.PlatedOnigiri,
                Phase = MenuPhase.Main,
                Weight = 1,
                DynamicMenuType = DynamicMenuType.Static,
                DynamicMenuIngredient = null
            }
        };

        public override List<Unlock> HardcodedRequirements => new List<Unlock>
        {
            GDOReferences.DishSalmonRoll
        };

        public override bool IsAvailableAsLobbyOption => Mod.ENABLE_ADDITIONAL_LOBBY_DISHES;
        public override List<(Locale, UnlockInfo)> InfoList => CenteralLang.Unlocks.Onigiri;

        public override Dictionary<Locale, string> Recipe => CenteralLang.Recipes.Onigiri;
    }
}