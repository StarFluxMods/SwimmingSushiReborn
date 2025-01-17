using System.Collections.Generic;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using SwimmingSushiReborn.Utilies;
using UnityEngine;

namespace SwimmingSushiReborn.Customs.Dishes
{
    public class SideGinger : CustomDish
    {
        public override string UniqueNameID => "SideGinger";
        public override DishType Type => DishType.Side;
        public override int Difficulty => 1;

        public override List<Dish.MenuItem> ResultingMenuItems => new List<Dish.MenuItem>
        {
            new Dish.MenuItem
            {
                Item = GDOReferences.GingerPortion,
                Phase = MenuPhase.Side,
                Weight = 1,
                DynamicMenuType = DynamicMenuType.Static
            }
        };

        public override HashSet<Item> MinimumIngredients => new()
        {
            GDOReferences.Ginger
        };

        public override HashSet<Process> RequiredProcesses => new()
        {
            GDOReferences.Chop
        };

        public override GameObject IconPrefab => Mod.Bundle.LoadAsset<GameObject>("SideGingerIcon").AssignMaterialsByNames();
        
        public override DishCustomerChange CustomerMultiplier => DishCustomerChange.SmallDecrease;
        public override UnlockGroup UnlockGroup => UnlockGroup.Dish;
        
        public override CardType CardType => CardType.Default;

        public override List<Unlock> HardcodedRequirements => new List<Unlock>
        {
            GDOReferences.DishSalmonRoll
        };

        public override bool IsAvailableAsLobbyOption => Mod.ENABLE_ADDITIONAL_LOBBY_DISHES;
        
        public override List<(Locale, UnlockInfo)> InfoList => CenteralLang.Unlocks.Ginger;
        public override Dictionary<Locale, string> Recipe => CenteralLang.Recipes.Ginger;
    }
}