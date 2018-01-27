using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.Localization;
using AlchemistNPC;

namespace AlchemistNPC.Buffs
{
	public class BigBirdLamp : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Big Bird's Lamp");
			Description.SetDefault("Character is lighting, all damage & crits are increased by 5%, attacks destroys enemy armor.");
			Main.buffNoSave[Type] = true;
			Main.debuff[Type] = false;
			canBeCleared = true;
			Main.buffNoTimeDisplay[Type] = true;
			DisplayName.AddTranslation(GameCulture.Russian, "Лампа Большой Птицы");
			Description.AddTranslation(GameCulture.Russian, "Персонаж светится, весь урон и крит повышаются на 5%, атаки разрушают броню противника."); 
		}
		public override void Update(Player player, ref int buffIndex)
		{
			if (((AlchemistNPCPlayer)player.GetModPlayer(mod, "AlchemistNPCPlayer")).trigger == true)
			{
			Lighting.AddLight((int)((double)player.position.X + (double)(player.width / 2)) / 16, (int)((double)player.position.Y + (double)(player.height / 2)) / 16, 0.8f, 0.95f, 1f);
			}
			else
			{
			}
		}
	}
}
