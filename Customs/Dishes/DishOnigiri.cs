using System.Collections.Generic;
using KitchenData;
using KitchenLib.Customs;
using SwimmingSushiReborn.Utilies;

namespace SwimmingSushiReborn.Customs.Dishes
{
    public class DishOnigiri : CustomDish
    {
        public override string UniqueNameID => "DishOnigiri";
        public override UnlockGroup UnlockGroup => UnlockGroup.Dish;
        public override CardType CardType => CardType.Default;
        public override DishCustomerChange CustomerMultiplier => DishCustomerChange.SmallDecrease;
        public override DishType Type => DishType.Main;
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
            GDOReferences.Rice,
            GDOReferences.Pot,
            GDOReferences.Water,
            GDOReferences.Seaweed
        };
        public override HashSet<Process> RequiredProcesses => new()
        {
            GDOReferences.Cook
        };
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

        public override bool IsAvailableAsLobbyOption => true;
        public override List<(Locale, UnlockInfo)> InfoList => CenteralLang.Unlocks.Onigiri;

        public override Dictionary<Locale, string> Recipe => CenteralLang.Recipes.Onigiri;
    }
}