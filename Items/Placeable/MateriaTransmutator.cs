using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace AlchemistNPC.Items.Placeable
{
	public class MateriaTransmutator : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Same functionality as most of crafting stations in one"
			+"\nAll crafting stations included:"
			+"\nWorkbench, Sawmill, Tinkerers Workshop, Table & Chair, Bookcase"
			+"\nSky Mill, Ice Machine, Honey Dispenser, Demon Altar"
			+"\nCrystal Ball, Any Hardmode Anvil/Forge, Autohammer and Ancient Manipulator");
			DisplayName.AddTranslation(GameCulture.Russian, "Преобразователь Материи");
			Tooltip.AddTranslation(GameCulture.Russian, "Выполняет функции большей части станций крафта в одной\nВсе включённые станции крафта:\nВерстак, Лесопилка, Мастерская Инженера, Стол и стул, Книжный шкаф\nНебесная Мельница, Раздатчик Мёда, Ледяная Машина, Любой Алтарь\nКристальный шар, Любая наковальня/печка, Автомолот и Древний Манипулятор"); 
		}

		public override void SetDefaults()
		{
			item.width = 32;
			item.height = 32;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.value = 1000000;
			item.createTile = mod.TileType("MateriaTransmutator");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.WorkBench);
			recipe.AddIngredient(ItemID.Sawmill);
			recipe.AddIngredient(ItemID.TinkerersWorkshop);
			recipe.AddIngredient(ItemID.AlchemyTable);
			recipe.AddIngredient(ItemID.Bookcase);
			recipe.AddIngredient(ItemID.SkyMill);
			recipe.AddIngredient(ItemID.IceMachine);
			recipe.AddIngredient(ItemID.HoneyDispenser);
			recipe.AddIngredient(null, "ArtificialAltar");
			recipe.AddIngredient(ItemID.CrystalBall);
			recipe.AddRecipeGroup("AlchemistNPC:AnyAnvil");
			recipe.AddRecipeGroup("AlchemistNPC:AnyForge");
			recipe.AddIngredient(ItemID.Autohammer);
			recipe.AddIngredient(ItemID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}