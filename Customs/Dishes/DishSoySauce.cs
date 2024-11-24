using System.Collections.Generic;
using KitchenData;
using KitchenLib.Customs;
using SwimmingSushiReborn.Utilies;

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
            }
        };

        public override HashSet<Item> MinimumIngredients => new()
        {
            GDOReferences.CondimentSoySauce
        };

        public override DishCustomerChange CustomerMultiplier => DishCustomerChange.SmallDecrease;
        public override UnlockGroup UnlockGroup => UnlockGroup.Dish;
        public override CardType CardType => CardType.Default;
        public override List<Unlock> HardcodedRequirements => new List<Unlock>
        {
            GDOReferences.DishSalmonRoll
        };
        public override List<(Locale, UnlockInfo)> InfoList => new List<(Locale, UnlockInfo)>
        {
            (Locale.English,
                new UnlockInfo
                {
                    Name = "Soy Sauce",
                    FlavourText = "A salty splash of perfection.",
                })
        };

        public override Dictionary<Locale, string> Recipe => new Dictionary<Locale, string>
        {
            {Locale.English, "Customers may order Soy Sauce while eating."},
        };
    }
}