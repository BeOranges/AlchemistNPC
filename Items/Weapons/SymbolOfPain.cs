using Microsoft.Xna.Framework;
using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace AlchemistNPC.Items.Weapons
{
	public class SymbolOfPain : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Scroll ''Symbol of Pain''");
			Tooltip.SetDefault("One-use item"
			+"\nContains the spell ''Symbol of Pain''"
			+"\nWhile used, all enemies on the screen would be heavily weakened for 1 minute"
			+"\nMakes you deal 25% more damage to affected enemies (not lowered by any caps)"
			+"\nAlso makes them deal 1/4 less damage"
			+"\nExhausts player for 1 minute, making him unable to use magic");
			DisplayName.AddTranslation(GameCulture.Russian, "Свиток ''Символа Боли''");
            Tooltip.AddTranslation(GameCulture.Russian, "Одноразовый предмет\nЭтот свиток содержит заклинание ''Символа Боли''\nПрименение ослабляет всех противников на экране\nПоражённые противники получают на 25% больше урона и наносят на 1/4 меньше урона\nИстощает игрока на 1 минуту, не позволяя ему использовать магию");
        }

		public override void SetDefaults()
		{
			item.consumable = true;
			item.maxStack = 99;
			item.width = 32;
			item.height = 32;
			item.useTime = 60;
			item.useAnimation = 60;
			item.useStyle = 2;
			item.noMelee = true;
			item.rare = 11;
			item.mana = 300;
			item.autoReuse = false;
			item.shoot = mod.ProjectileType("SymbolOfPain");
			item.value = Item.sellPrice(1, 0, 0, 0);
			item.UseSound = SoundID.NPCDeath59;
			item.mana = 200;
		}

		public bool CalamityModRevengeance
		{
        get { return CalamityMod.CalamityWorld.revenge; }
        }
		
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			Vector2 vel1 = new Vector2(-0, 0);
			vel1 *= 0f;
			Projectile.NewProjectile(player.position.X, player.position.Y, vel1.X, vel1.Y, mod.ProjectileType("SymbolOfPainVision"), item.damage, 0, Main.myPlayer);
			Projectile.NewProjectile(player.position.X, player.position.Y, vel1.X, vel1.Y, mod.ProjectileType("SymbolOfPain"), item.damage, 0, Main.myPlayer);
			if (ModLoader.GetLoadedMods().Contains("CalamityMod"))
			{
				if (CalamityModRevengeance)
				{
				player.AddBuff(mod.BuffType("Exhausted"), 1800); 
				}
				else
				{
				player.AddBuff(mod.BuffType("Exhausted"), 3600); 	
				}
			}
			if (!ModLoader.GetLoadedMods().Contains("CalamityMod"))
			{
				player.AddBuff(mod.BuffType("Exhausted"), 3600); 
			}
			return false;
		}
		public override bool CanUseItem(Player player)
		{
			if (!player.HasBuff(mod.BuffType("Exhausted")) && !player.HasBuff(mod.BuffType("ExecutionersEyes")) && !player.HasBuff(mod.BuffType("CloakOfFear")))
			{
				return true;
			}
			return false;
		}
	}
}
