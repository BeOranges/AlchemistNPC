using System;
using System.Linq;
using Terraria;
using Terraria.ModLoader;
using AlchemistNPC.NPCs;
using Terraria.Localization;

namespace AlchemistNPC.Buffs
{
	public class GuarantCrit : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Guaranteed Crit");
			Description.SetDefault("Your next attack would be critical");
			Main.persistentBuff[Type] = true;
			canBeCleared = true;
			DisplayName.AddTranslation(GameCulture.Russian, "Гарантированный Крит");
			Description.AddTranslation(GameCulture.Russian, "Ваша следующая атаку будет гарантированным критом");
            DisplayName.AddTranslation(GameCulture.Chinese, "暴击预定");
            Description.AddTranslation(GameCulture.Chinese, "下一次攻击必定暴击");
        }
		
		public override void Update(Player player, ref int buffIndex)
		{
			player.meleeCrit += 100;
			player.rangedCrit += 100;
			player.magicCrit += 100;
			player.thrownCrit += 100;
			player.AddBuff(mod.BuffType("GuarantCrit"), 2);
			if (((AlchemistNPCPlayer)player.GetModPlayer(mod, "AlchemistNPCPlayer")).GC == false)
			{
				player.DelBuff(buffIndex);
				buffIndex--;
			}
			if (ModLoader.GetMod("ThoriumMod") != null)
				{
				ThoriumBoosts(player);
				}
			if (ModLoader.GetMod("Redemption") != null)
				{
				RedemptionBoost(player);
				}
			if (ModLoader.GetMod("CalamityMod") != null)
				{
				CalamityBoost(player);
				}
		}
		
		private void CalamityBoost(Player player)
        {
			CalamityMod.Items.CalamityCustomThrowingDamage.CalamityCustomThrowingDamagePlayer CalamityPlayer = player.GetModPlayer<CalamityMod.Items.CalamityCustomThrowingDamage.CalamityCustomThrowingDamagePlayer>(Calamity);
            CalamityPlayer.throwingCrit += 100;
        }
		private readonly Mod Calamity = ModLoader.GetMod("CalamityMod");
		
		private void RedemptionBoost(Player player)
        {
			Redemption.Items.DruidDamageClass.DruidDamagePlayer RedemptionPlayer = player.GetModPlayer<Redemption.Items.DruidDamageClass.DruidDamagePlayer>(Redemption);
            RedemptionPlayer.druidCrit += 100;
        }
		private readonly Mod Redemption = ModLoader.GetMod("Redemption");
		
		private void ThoriumBoosts(Player player)
        {
            ThoriumMod.ThoriumPlayer ThoriumPlayer = player.GetModPlayer<ThoriumMod.ThoriumPlayer>(Thorium);
            ThoriumPlayer.symphonicCrit += 100;
            ThoriumPlayer.radiantCrit += 100;
        }
		private readonly Mod Thorium = ModLoader.GetMod("ThoriumMod");
	}
}
