using Terraria;
using Terraria.ModLoader;
using Terraria.Localization;

namespace AlchemistNPC.Items.Armor
{
	[AutoloadEquip(EquipType.Body)]
	public class PinkGuyBody : ModItem
	{
		public override bool Autoload(ref string name)
		{
		return ModLoader.GetMod("AlchemistNPCContentDisabler") == null;
		}
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Pink Guy's Suit");
			DisplayName.AddTranslation(GameCulture.Russian, "Комбинезон Розового Парня"); 
			Tooltip.SetDefault("Forged from the darkest of materials. Only the best of the bests can wear it.");
			Tooltip.AddTranslation(GameCulture.Russian, "Скован из темнейших материалов. Лишь лучшие из лучших могут носить его."); 
		}

		public override void SetDefaults()
		{
			item.width = 28;
			item.height = 24;
			item.value = 1650000;
			item.rare = -11;
			item.vanity = true;
		}
	}
}