using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;
using AlchemistNPC.Tiles;
 
namespace AlchemistNPC.Items
{
     public class UnderworldTeleportationPotion : ModItem
    {
        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Underworld Teleporter Potion");
			Tooltip.SetDefault("Teleports you to Underworld to leftest or rightest Obsidian Tower"
			+"\nSide depends of used mouse button"
			+"\nWould be useful to drink Obsidian Skin potion before drinking that");
			DisplayName.AddTranslation(GameCulture.Russian, "Телепортёр в Ад");
			Tooltip.AddTranslation(GameCulture.Russian, "Телепортирует вас в Ад к крайней Обсидиановой башне\nСторона зависит от нажатой клавиши мыши\nБудет полезно выпить зелье Обсидиановой кожи до того, как пить это"); 
		}    
		public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.RecallPotion);
            item.maxStack = 99;
            item.consumable = true;
            return;
        }
		
		public override bool UseItem(Player player)
		{
			return true;
		}
		
		private static void HandleHellTeleport(Player player, bool syncData = false)
		{
			Vector2 prePos = player.position;
			Vector2 pos = prePos;
			for (int x = 0; x < Main.tile.GetLength(0); ++x)
			{
				for (int y = 0; y < Main.tile.GetLength(1); ++y)
				{
					if (Main.tile[x, y] == null) continue;
					if (Main.tile[x, y].type != 75) continue;
					pos = new Vector2((x-3) * 16, (y+2) * 16);
					break;
				}
			}
			if (pos != prePos)
			{
				RunTeleport(player, new Vector2(pos.X, pos.Y), syncData, false);
			}
			else return;
		}
		
		private static void HandleHellTeleportLeft(Player player, bool syncData = false)
		{
			Vector2 prePos = player.position;
			Vector2 pos = prePos;
			for (int x = 8400; x > 0; --x)
			{
				for (int y = 0; y < Main.tile.GetLength(1); ++y)
				{
					if (Main.tile[x, y] == null) continue;
					if (Main.tile[x, y].type != 75) continue;
					pos = new Vector2((x+3) * 16, (y+2) * 16);
					break;
				}
			}
			if (pos != prePos)
			{
				RunTeleport(player, new Vector2(pos.X, pos.Y), syncData, false);
			}
			else return;
		}
		
		public override bool AltFunctionUse(Player player)
		{
			return true;
		}

		public override bool CanUseItem(Player player)
		{
			if (player.altFunctionUse == 2)
			{
				HandleHellTeleport(player);
			}
			else
			{
				HandleHellTeleportLeft(player);
			}
			return base.CanUseItem(player);
		}
		
		public override bool CanRightClick()
        {            
            return true;
        }

        public override void RightClick(Player player)
        {
            HandleHellTeleport(player);
        }
		
		private static void RunTeleport(Player player, Vector2 pos, bool syncData = false, bool convertFromTiles = false)
		{
			bool postImmune = player.immune;
			int postImmunteTime = player.immuneTime;

			if (convertFromTiles)
				pos = new Vector2(pos.X * 16 + 8 - player.width / 2, pos.Y * 16 - player.height);

			LeaveDust(player);

			//Kill hooks
			player.grappling[0] = -1;
			player.grapCount = 0;
			for (int index = 0; index < 1000; ++index)
			{
				if (Main.projectile[index].active && Main.projectile[index].owner == player.whoAmI && Main.projectile[index].aiStyle == 7)
					Main.projectile[index].Kill();
			}

			player.Teleport(pos, 2, 0);
			player.velocity = Vector2.Zero;
			player.immune = postImmune;
			player.immuneTime = postImmunteTime;

			LeaveDust(player);

			if (Main.netMode != 2)
				return;

			if (syncData)
			{
				RemoteClient.CheckSection(player.whoAmI, player.position, 1);
				NetMessage.SendData(65, -1, -1, null, 0, (float)player.whoAmI, pos.X, pos.Y, 3, 0, 0);
			}
		}

		private static void LeaveDust(Player player)
		{
			//Leave dust
			for (int index = 0; index < 70; ++index)
				Main.dust[Dust.NewDust(player.position, player.width, player.height, 15, player.velocity.X * 0.2f, player.velocity.Y * 0.2f, 150, Color.Cyan, 1.2f)].velocity *= 0.5f;
			Main.TeleportEffect(player.getRect(), 1);
			Main.TeleportEffect(player.getRect(), 3);
		}
    }
}
