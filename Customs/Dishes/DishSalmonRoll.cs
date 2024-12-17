using System.Collections.Generic;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using SwimmingSushiReborn.Utilies;
using UnityEngine;

namespace SwimmingSushiReborn.Customs.Dishes
{
    public class DishSalmonRoll : CustomDish
    {
        public override string UniqueNameID => "DishSalmonRoll";
        public override UnlockGroup UnlockGroup => UnlockGroup.Dish;
        public override CardType CardType => CardType.Default;
        public override DishCustomerChange CustomerMultiplier => DishCustomerChange.SmallDecrease;
        public override DishType Type => DishType.Base;
        public override int Difficulty => 3;

        public override List<string> StartingNameSet => new()
        {
            "Roll With It",
            "Rice Rice Baby",
            "Salmon You Love Me",
            "I Roll, You Roll",
            "Salmon to Talk About"
        };

        public override HashSet<Item> MinimumIngredients => new()
        {
            GDOReferences.Plate,
            GDOReferences.Rice,
            GDOReferences.Nori,
            GDOReferences.Pot,
            GDOReferences.Water,
            GDOReferences.Avocado,
            GDOReferences.Salmon
        };

        public override HashSet<Process> RequiredProcesses => new()
        {
            GDOReferences.Cook,
            GDOReferences.Chop,
            GDOReferences.Knead,
            GDOReferences.Roll
        };

        public override GameObject IconPrefab => Mod.Bundle.LoadAsset<GameObject>("SalmonRollIcon").AssignMaterialsByNames();

        public override List<Dish.MenuItem> ResultingMenuItems => new()
        {
            new Dish.MenuItem
            {
                Item = GDOReferences.PlatedSalmonRoll,
                Phase = MenuPhase.Main,
                Weight = 1,
                DynamicMenuType = DynamicMenuType.Static,
                DynamicMenuIngredient = null
            }
        };

        public override bool IsAvailableAsLobbyOption => true;
        public override List<(Locale, UnlockInfo)> InfoList => CenteralLang.Unlocks.SalmonRoll;

        public override Dictionary<Locale, string> Recipe => CenteralLang.Recipes.SalmonRoll;
    }
}