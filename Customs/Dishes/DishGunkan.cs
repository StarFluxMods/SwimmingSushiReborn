using System.Collections.Generic;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using SwimmingSushiReborn.Utilies;
using UnityEngine;

namespace SwimmingSushiReborn.Customs.Dishes
{
    public class DishGunkan : CustomDish
    {
        public override string UniqueNameID => "DishGunkan";
        public override UnlockGroup UnlockGroup => UnlockGroup.Dish;
        public override CardType CardType => CardType.Default;
        public override DishCustomerChange CustomerMultiplier => DishCustomerChange.SmallDecrease;
        public override DishType Type => DishType.Main;
        public override int Difficulty => 2;
        public override List<string> StartingNameSet => new()
        {
            "Shell We Begin?",
            "Roe, Roe, Roe Your Sushi",
            "Sail-icious Bites",
            "The Nori You Know",
            "Boatloads of Taste"
        };
        public override HashSet<Item> MinimumIngredients => new()
        {
            GDOReferences.Plate,
            GDOReferences.Rice,
            GDOReferences.Pot,
            GDOReferences.Water,
            GDOReferences.Seaweed,
            GDOReferences.Roe
        };
        public override HashSet<Process> RequiredProcesses => new()
        {
            GDOReferences.Cook
        };
        public override GameObject IconPrefab => Mod.Bundle.LoadAsset<GameObject>("GunkanIcon").AssignMaterialsByNames();
        public override List<Dish.MenuItem> ResultingMenuItems => new()
        {
            new Dish.MenuItem
            {
                Item = GDOReferences.PlatedGunkan,
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
        public override List<(Locale, UnlockInfo)> InfoList => CenteralLang.Unlocks.Gunkan;

        public override Dictionary<Locale, string> Recipe => CenteralLang.Recipes.Gunkan;
    }
}