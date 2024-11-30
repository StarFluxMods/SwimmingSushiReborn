using System.Collections.Generic;
using KitchenData;
using KitchenLib.Customs;
using SwimmingSushiReborn.Utilies;

namespace SwimmingSushiReborn.Customs.Dishes
{
    public class DishFreshRoe : CustomDish
    {
        public override string UniqueNameID => "DishFreshRoe";
        public override UnlockGroup UnlockGroup => UnlockGroup.Dish;
        public override CardType CardType => CardType.Default;
        public override DishCustomerChange CustomerMultiplier => DishCustomerChange.SmallDecrease;
        public override DishType Type => DishType.Extra;
        public override int Difficulty => 2;
        
        public override HashSet<Item> MinimumIngredients => new()
        {
            GDOReferences.Salmon,
            GDOReferences.FishKnife
        };
        public override HashSet<Process> RequiredProcesses => new()
        {
            GDOReferences.Chop
        };

        public override List<Unlock> HardcodedRequirements => new List<Unlock>
        {
            GDOReferences.DishSalmonRoll
        };

        public override HashSet<Item> BlockProviders => new HashSet<Item>
        {
            GDOReferences.Roe
        };
        
        public override List<(Locale, UnlockInfo)> InfoList => CenteralLang.Unlocks.FreshRoe;

        public override Dictionary<Locale, string> Recipe => CenteralLang.Recipes.FreshRoe;
    }
}