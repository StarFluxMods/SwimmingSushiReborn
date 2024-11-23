using System.Collections.Generic;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using SwimmingSushiReborn.Utilies;
using UnityEngine;

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
			GDOReferences.Roll
		};
		public override GameObject IconPrefab => Mod.Bundle.LoadAsset<GameObject>("PlaceholderSushiIcon").AssignMaterialsByNames();
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
		public override List<(Locale, UnlockInfo)> InfoList => new List<(Locale, UnlockInfo)>
		{
				(Locale.English,
				new UnlockInfo
				{
					Name = "Salmon Roll",
					FlavourText = "Do the salmon roll",
				})
		};

		public override Dictionary<Locale, string> Recipe => new Dictionary<Locale, string>
		{
			{Locale.English, "Combine Rice and Water and Cook. Portion onto a Nori sheet, and add chopped Salmon and Avocado, Roll, Chop, and Portion."}
		};
	}
}