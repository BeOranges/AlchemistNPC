using System;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.Enums;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ObjectData;
using System.Collections.Generic;

namespace AlchemistNPC.Tiles
{
	public class AlchemistGlobalTiles : GlobalTile
	{
		public override int[] AdjTiles(int type)
		{
			if (type == mod.TileType("MateriaTransmutator"))
			{
				Main.LocalPlayer.adjHoney = true;
				Main.LocalPlayer.adjLava = true;
				Main.LocalPlayer.adjWater = true;
			}
			if (type == mod.TileType("MateriaTransmutatorMK2"))
			{
				Main.LocalPlayer.adjHoney = true;
				Main.LocalPlayer.adjLava = true;
				Main.LocalPlayer.adjWater = true;
			}
			if (type == mod.TileType("SpecCraftPoint"))
			{
				Main.LocalPlayer.adjHoney = true;
				Main.LocalPlayer.adjLava = true;
				Main.LocalPlayer.adjWater = true;
			}
			return base.AdjTiles(type);
		}
		
		public override bool PreDraw(int i, int j, int type, SpriteBatch spriteBatch)
		{
			if (type == mod.TileType("ImmortalityFieldProjector"))
			{
				for (int k = 0; k < 200; k++)
				{
					NPC npc = Main.npc[k];
					{
						if (npc.active && npc.townNPC)
						{
							npc.buffImmune[mod.BuffType("IField")] = false;
							npc.AddBuff(mod.BuffType("IField"), 60);
						}
					}
				}
			}
			return base.PreDraw(i, j, type, spriteBatch);
		}
	}
}