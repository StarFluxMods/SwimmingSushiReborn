using System.Collections.Generic;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using SwimmingSushiReborn.Utilies;
using UnityEngine;

namespace SwimmingSushiReborn.Customs.Dishes
{
    public class DishSashimi : CustomDish
    {
        public override string UniqueNameID => "DishSashimi";
        public override UnlockGroup UnlockGroup => UnlockGroup.Dish;
        public override CardType CardType => CardType.Default;
        public override DishCustomerChange CustomerMultiplier => DishCustomerChange.SmallDecrease;
        public override DishType Type => DishType.Main;
        public override int Difficulty => 1;

        public override List<string> StartingNameSet => new()
        {
            "Sashimi Crazy",
            "Sea-riously Fresh",
            "Fresh Off the Boat",
            "Simply Fin-credible",
            "Sea the Flavor",
        };

        public override HashSet<Item> MinimumIngredients => new()
        {
            GDOReferences.Plate,
            GDOReferences.Salmon,
        };

        public override HashSet<Process> RequiredProcesses => new()
        {
            GDOReferences.Chop
        };

        public override GameObject IconPrefab => Mod.Bundle.LoadAsset<GameObject>("SashimiIcon").AssignMaterialsByNames();

        public override List<Dish.MenuItem> ResultingMenuItems => new()
        {
            new Dish.MenuItem
            {
                Item = GDOReferences.PlatedSashimi,
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
        public override List<(Locale, UnlockInfo)> InfoList => CenteralLang.Unlocks.Sashimi;

        public override Dictionary<Locale, string> Recipe => CenteralLang.Recipes.Sashimi;
    }
}