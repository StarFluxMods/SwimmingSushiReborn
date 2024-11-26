using System.Collections.Generic;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using SwimmingSushiReborn.Utilies;
using UnityEngine;

namespace SwimmingSushiReborn.Customs.Dishes
{
    public class DishNigiri : CustomDish
    {
        public override string UniqueNameID => "DishNigiri";
        public override UnlockGroup UnlockGroup => UnlockGroup.Dish;
        public override CardType CardType => CardType.Default;
        public override DishCustomerChange CustomerMultiplier => DishCustomerChange.SmallDecrease;
        public override DishType Type => DishType.Main;
        public override List<string> StartingNameSet => new()
        {
            "Nigiri Me Out",
            "Rice to the Occasion",
            "Slice, Slice Sushi",
            "Oh Snap-per!",
            "Hooked on Sushi"
        };
        public override HashSet<Item> MinimumIngredients => new()
        {
            GDOReferences.Rice,
            GDOReferences.Pot,
            GDOReferences.Water,
            GDOReferences.Salmon
        };
        public override HashSet<Process> RequiredProcesses => new()
        {
            GDOReferences.Cook,
            GDOReferences.Chop
        };
        public override GameObject IconPrefab => Mod.Bundle.LoadAsset<GameObject>("NigiriIcon").AssignMaterialsByNames();
        public override List<Dish.MenuItem> ResultingMenuItems => new()
        {
            new Dish.MenuItem
            {
                Item = GDOReferences.PlatedNigiri,
                Phase = MenuPhase.Main,
                Weight = 1,
                DynamicMenuType = DynamicMenuType.Static,
                DynamicMenuIngredient = null
            }
        };

        public override bool IsAvailableAsLobbyOption => Mod.ENABLE_ADDITIONAL_LOBBY_DISHES;
        
        public override List<(Locale, UnlockInfo)> InfoList => CenteralLang.Unlocks.Nigiri;

        public override Dictionary<Locale, string> Recipe => CenteralLang.Recipes.Nigiri;
    }
}