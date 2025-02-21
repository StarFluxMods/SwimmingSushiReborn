﻿using System.Collections.Generic;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using SwimmingSushiReborn.Utilies;
using UnityEngine;

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

        public override GameObject IconPrefab => Mod.Bundle.LoadAsset<GameObject>("FreshRoeIcon").AssignMaterialsByNames();

        public override List<Unlock> HardcodedRequirements => new List<Unlock>
        {
            GDOReferences.DishGunkan
        };

        public override HashSet<Item> BlockProviders => new HashSet<Item>
        {
            GDOReferences.Roe
        };

        public override bool IsAvailableAsLobbyOption => Mod.ENABLE_ADDITIONAL_LOBBY_DISHES;

        public override List<(Locale, UnlockInfo)> InfoList => CenteralLang.Unlocks.FreshRoe;

        public override Dictionary<Locale, string> Recipe => CenteralLang.Recipes.FreshRoe;
    }
}