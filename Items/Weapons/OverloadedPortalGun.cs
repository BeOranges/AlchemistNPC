using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;
using System.Linq;

namespace AlchemistNPC.Items.Weapons
{
	public class OverloadedPortalGun : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Rick's Portal Gun (Overloaded)");
			Tooltip.SetDefault("Copy of Rick Sanchez's Portal Gun"
			+"\nUses unstable technologies, making it work more rapidly"
			+"\nOpens portals to the random dangerous dimensions"
			+"\nRequires Energy Capsules as ammo"
			+"\nHope this thing wouldn't cause appearence of SEAL team Ricks");
			
			DisplayName.AddTranslation(GameCulture.Russian, "Портальная пушка Рика (Перегруженная)");
            Tooltip.AddTranslation(GameCulture.Russian, "Копия портальной пушки Рика Санчеза\nИспользует нестабильные технологии, заставляющие её работать быстрее\nОткрывает порталы в различные измерения\nТребует Капсулы с энергией в качестве патронов\nНадеюсь, что она не вызовет появление Рик спецназа");
		}

		public override void SetDefaults()
		{
			item.damage = 125;
			item.ranged = true;
			item.width = 32;
			item.height = 32;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 1;
			item.value = 3000000;
			item.rare = 11;
			item.UseSound = SoundID.Item114;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType("PortalGunProj");
			item.shootSpeed = 16f;
			item.useAmmo = mod.ItemType("EnergyCapsule");
		}
		
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "PortalGun");
			recipe.AddIngredient(null, "ChromaticCrystal", 3);
			recipe.AddIngredient(null, "SunkroveraCrystal", 3);
			recipe.AddIngredient(null, "NyctosythiaCrystal", 3);
			if (ModLoader.GetLoadedMods().Contains("CalamityMod"))
			{
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("UeliaceBar")), 5);
			recipe.AddIngredient((ModLoader.GetMod("CalamityMod").ItemType("Phantoplasm")), 25);
			}
			if (ModLoader.GetLoadedMods().Contains("ThoriumMod"))
			{
			recipe.AddIngredient((ModLoader.GetMod("ThoriumMod").ItemType("OceanEssence")), 3);
			recipe.AddIngredient((ModLoader.GetMod("ThoriumMod").ItemType("DeathEssence")), 3);
			recipe.AddIngredient((ModLoader.GetMod("ThoriumMod").ItemType("InfernoEssence")), 3);
			}
			recipe.AddIngredient(null, "EmagledFragmentation", 100);
			recipe.AddTile(null, "MateriaTransmutator");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
