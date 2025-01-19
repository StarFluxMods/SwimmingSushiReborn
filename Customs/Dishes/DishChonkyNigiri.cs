using System.Collections.Generic;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using SwimmingSushiReborn.Utilies;
using UnityEngine;

namespace SwimmingSushiReborn.Customs.Dishes
{
    public class DishChonkyNigiri : CustomDish
    {
        public override string UniqueNameID => "DishChonkyNigiri";
        public override UnlockGroup UnlockGroup => UnlockGroup.Dish;
        public override CardType CardType => CardType.Default;
        public override DishCustomerChange CustomerMultiplier => DishCustomerChange.SmallDecrease;
        public override DishType Type => DishType.Main;
        public override int Difficulty => 2;

        public override List<string> StartingNameSet => new()
        {
            "Chunk It Up!",
            "Sushi with a Side of Chonk",
            "Chonk You Very Much",
            "So Chonk, So Right",
            "Big Fish, Bigger Bites",
        };

        public override HashSet<Item> MinimumIngredients => new()
        {
            GDOReferences.Plate,
            GDOReferences.Rice,
            GDOReferences.Pot,
            GDOReferences.Water,
            GDOReferences.Salmon
        };

        public override HashSet<Process> RequiredProcesses => new()
        {
            GDOReferences.Cook,
            GDOReferences.Chop,
            GDOReferences.Roll
        };

        public override GameObject IconPrefab => Mod.Bundle.LoadAsset<GameObject>("ChonkyNigiriIcon").AssignMaterialsByNames();

        public override List<Dish.MenuItem> ResultingMenuItems => new()
        {
            new Dish.MenuItem
            {
                Item = GDOReferences.PlatedChonkyNigiri,
                Phase = MenuPhase.Main,
                Weight = 1,
                DynamicMenuType = DynamicMenuType.Static,
                DynamicMenuIngredient = null
            }
        };

        public override List<Unlock> HardcodedRequirements => new List<Unlock>
        {
            GDOReferences.DishSalmonRoll,
            GDOReferences.DishNigiri
        };

        public override bool IsAvailableAsLobbyOption => Mod.ENABLE_ADDITIONAL_LOBBY_DISHES;

        public override List<(Locale, UnlockInfo)> InfoList => CenteralLang.Unlocks.ChonkyNigiri;

        public override Dictionary<Locale, string> Recipe => CenteralLang.Recipes.ChonkyNigiri;
    }
}