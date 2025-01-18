using System.Collections.Generic;
using KitchenData;
using KitchenLib.Customs;
using SwimmingSushiReborn.Utilies;

namespace SwimmingSushiReborn.Customs.Dishes
{
    public class RecipeMayonnaise : CustomDish
    {
        public override string UniqueNameID => "RecipeMayonnaise";
        public override DishType Type => DishType.Base;
        public override int Difficulty => 1;

        public override bool IsUnlockable => false;
        
        public override List<(Locale, UnlockInfo)> InfoList => CenteralLang.Unlocks.RecipeMayonnaise;
        public override Dictionary<Locale, string> Recipe => CenteralLang.Recipes.RecipeMayonnaise;
    }
}