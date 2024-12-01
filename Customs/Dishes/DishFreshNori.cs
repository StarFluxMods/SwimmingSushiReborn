using System.Collections.Generic;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using SwimmingSushiReborn.Utilies;
using UnityEngine;

namespace SwimmingSushiReborn.Customs.Dishes
{
    public class DishFreshNori : CustomDish
    {
        public override string UniqueNameID => "DishFreshNori";
        public override UnlockGroup UnlockGroup => UnlockGroup.Dish;
        public override CardType CardType => CardType.Default;
        public override DishCustomerChange CustomerMultiplier => DishCustomerChange.SmallDecrease;
        public override DishType Type => DishType.Extra;
        public override int Difficulty => 2;
        
        public override HashSet<Item> MinimumIngredients => new()
        {
            GDOReferences.Seaweed
        };
        public override HashSet<Process> RequiredProcesses => new()
        {
            GDOReferences.Cook
        };
        public override GameObject IconPrefab => Mod.Bundle.LoadAsset<GameObject>("FreshNoriIcon").AssignMaterialsByNames();

        public override List<Unlock> HardcodedRequirements => new List<Unlock>
        {
            GDOReferences.DishSalmonRoll
        };

        public override HashSet<Item> BlockProviders => new HashSet<Item>
        {
            GDOReferences.Nori
        };
        public override bool IsAvailableAsLobbyOption => Mod.ENABLE_ADDITIONAL_LOBBY_DISHES;
        
        public override List<(Locale, UnlockInfo)> InfoList => CenteralLang.Unlocks.FreshNori;

        public override Dictionary<Locale, string> Recipe => CenteralLang.Recipes.FreshNori;
    }
}