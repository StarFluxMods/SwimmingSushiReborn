using System.Collections.Generic;
using KitchenData;
using KitchenLib.Customs;
using SwimmingSushi.Utilies;

namespace SwimmingSushiReborn.Customs.Dishes
{
    public class DishSalmonRoll : CustomDish
    {
        public override string UniqueNameID => "DishSalmonRoll";
        public override UnlockGroup UnlockGroup => UnlockGroup.Dish;
        public override CardType CardType => CardType.Default;
        public override DishCustomerChange CustomerMultiplier => DishCustomerChange.SmallDecrease;
        public override DishType Type => DishType.Base;
        public override List<string> StartingNameSet => new() { };
		public override HashSet<Item> MinimumIngredients => new()
		{
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
			GDOReferences.Knead
		};
		// public override GameObject IconPrefab => Mod.Bundle.LoadAsset<GameObject>("Sushi_Icon").AssignMaterialsByNames();
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
    }
}