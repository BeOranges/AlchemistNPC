using Terraria.ID;
using Terraria;
using System;
using System.Linq;
using System.Diagnostics;
using Microsoft.Xna.Framework;
using Terraria.Localization;
using Terraria.ModLoader;

namespace AlchemistNPC.Items.Equippable
{
	public class SupremeRampageComponents : ModItem
	{
		public override bool Autoload(ref string name)
		{
		return ModLoader.GetMod("AlchemistNPCContentDisabler") == null;
		}
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Supreme Rampage Components");
			Tooltip.SetDefault("Turns Musket Balls into deadly Chloroshard Bullets"
			+ "\nThey work like crazy combination of Chlorophyte and Crystal Dust Bullets"
			+ "\nGives effect of Sniper Scope (15% bonus ranged damage and crit, ability to zoom)"
			+ "\nHide visual to disable Sniper Scope effect"
			+ "\nIncreases armor penetration by 40"
			+ "\nAmmo Reservation Effect"
			+ "\nSpeeds up all arrows"
			+ "\nEmpowers any Electrospheres greatly"
			+ "\n''And the Heavens have opened, and God reached down upon my life, and said upon me:"
			+ "\nRek thigh scrbs, an fk ther sht ahp.''");
			DisplayName.AddTranslation(GameCulture.Russian, "Истинные Компоненты Буйства");
            Tooltip.AddTranslation(GameCulture.Russian, "Превращяет мушкетные пули в смертоносные Хлорофитово-осколочные пули\nОни работают как безумная комбинация Хлорифитовых и Пыле-кристальных пуль\nДаёт эффект Снайперского прицела \n15% бонусного урона и шанса критического удара для дальнего боя\nОтключение видимости выключает эффект Снайперского Прицела\nУвеличивает пробивание брони на 40\nЭффект Экономии Патронов\n''And the Heavens have opened, and God reached down upon my life, and said upon me:\nRek thigh scrbs, an fk ther sht ahp.''");
        }
	
		public override void SetDefaults()
		{
			item.width = 22;
			item.height = 30;
			item.value = 1000000;
			item.rare = 11;
			item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.GetModPlayer<AlchemistNPCPlayer>(mod).Rampage = true;
			if (!hideVisual)
			{
				player.scope = true;
			}
			player.armorPenetration += 40;
			player.magicQuiver = true;
			player.ammoPotion = true;
			player.rangedDamage += 0.15f;
			player.rangedCrit += 15;
			player.GetModPlayer<AlchemistNPCPlayer>(mod).XtraT = true;
		}

		
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "RampageComponents");
			recipe.AddIngredient(ItemID.SharkToothNecklace);
			recipe.AddIngredient(null, "ChromaticCrystal", 3);
			recipe.AddIngredient(null, "SunkroveraCrystal", 3);
			recipe.AddIngredient(null, "NyctosythiaCrystal", 3);
			if (ModLoader.GetLoadedMods().Contains("CalamityMod"))
			{
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("NightmareFuel")), 10);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("EndothermicEnergy")), 10);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("Phantoplasm")), 25);
			}
			if (ModLoader.GetLoadedMods().Contains("ThoriumMod"))
			{
			recipe.AddIngredient((ModLoader.GetMod("ThoriumMod").ItemType("OceanEssence")), 3);
			recipe.AddIngredient((ModLoader.GetMod("ThoriumMod").ItemType("DeathEssence")), 3);
			recipe.AddIngredient((ModLoader.GetMod("ThoriumMod").ItemType("InfernoEssence")), 3);
			}
			if (!ModLoader.GetLoadedMods().Contains("CalamityMod"))
			{
			recipe.AddTile(null, "MateriaTransmutator");
			}
			if (ModLoader.GetLoadedMods().Contains("CalamityMod"))
			{
			recipe.AddTile(null, "MateriaTransmutatorMK2");
			}
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}