using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using ReLogic.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using Terraria.Audio;
using Terraria.DataStructures;
using Terraria.Enums;
using Terraria.GameContent;
using Terraria.GameContent.Achievements;
using Terraria.GameContent.Events;
using Terraria.GameContent.Tile_Entities;
using Terraria.GameContent.UI;
using Terraria.GameInput;
using Terraria.Graphics.Capture;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.IO;
using Terraria.Localization;
using Terraria.ObjectData;
using Terraria.Social;
using Terraria.UI;
using Terraria.UI.Chat;
using Terraria.UI.Gamepad;
using Terraria.Utilities;
using Terraria.World.Generation;
using Terraria;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using AlchemistNPC;
using AlchemistNPC.NPCs;
 
namespace AlchemistNPC.NPCs
{
	[AutoloadBossHead]
	class BillCipher : ModNPC
	{
		public override bool Autoload(ref string name)
		{
			return ModLoader.GetMod("AlchemistNPCContentDisabler") == null;
		}
		
		public static int introduction = 0;
		public static int counter = 0;
		public static int counter2 = 0;
		public override void SetDefaults()
		{
			npc.CloneDefaults(4);
			npc.boss = true;
			npc.width = 82;
			npc.height = 70;
			npc.damage = 1000;
			npc.defense = 20;
			npc.lifeMax = 333333;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath2;
			npc.value = 333f;
			npc.knockBackResist = -1;
			npc.aiStyle = 5;
			aiType = 9;
			music = MusicID.Boss2;
			bossBag = mod.ItemType("BillCipherBag");
		}
		
		public override void SetStaticDefaults()
		{
		DisplayName.SetDefault("Bill Cipher");
		Main.npcFrameCount[npc.type] = 6;
		}
		
		public override void BossHeadRotation(ref float rotation)
        {
            rotation = 0;
        }
		
		public override void AI()
		{
			Main.dayTime = false;
			Main.monolithType = 3;
			Main.time = 0.0;
			if (npc.velocity.X < 0)
			{
				npc.rotation = 1.25f;
				npc.spriteDirection = -1;
			}
			else
			{
				npc.rotation = -1.25f;
				npc.spriteDirection = 1;
			}
			Player player = Main.player[(int)Player.FindClosest(npc.position, npc.width, npc.height)];
			float TPX = npc.position.X + npc.width * 0.5f - player.Center.X;
            float TPY = npc.position.Y + npc.height * 0.5f - player.Center.Y;
            float distance = (float)Math.Sqrt(TPX * TPX + TPY * TPY);
			if (distance > 2500f)
			{
				Main.NewText("Don't think that you can hide from me, mortal!", 10, 255, 10);
				switch(Main.rand.Next(2))
				{
					case 0:
					npc.Center = player.Center - new Vector2(350, 100);
					break;
					case 1:
					npc.Center = player.Center - new Vector2(-350, -100);
					break;
				}
			}
			if (ModLoader.GetLoadedMods().Contains("ThoriumMod"))
				{
				player.buffImmune[ModLoader.GetMod("ThoriumMod").BuffType("AbyssalShell")] = true;
				}
			npc.buffImmune[mod.BuffType("ArmorDestruction")] = true;
			npc.buffImmune[mod.BuffType("Twilight")] = true;
			npc.buffImmune[mod.BuffType("Electrocute")] = true;
			npc.buffImmune[mod.BuffType("Patience")] = true;
			int damage1 = 150;
			int damage2 = 125;
			int damage3 = 200;
			if (npc.life > npc.lifeMax/2 && !player.dead && !npc.GetGlobalNPC<ModGlobalNPC>(mod).intermedia1)
			{
				introduction++;
				if (introduction > 300)
				{
					if (counter2 >= 5)
					{
						counter2 = 0;
						Vector2 delta = player.Center - npc.Center;
						float magnitude = (float)Math.Sqrt(delta.X * delta.X + delta.Y * delta.Y);
						if (magnitude > 0)
						{
							delta *= (5f / magnitude);
						}
						else
						{
							delta = new Vector2(0f, 5f);
						}
						delta *= 6f;
						Projectile.NewProjectile(npc.Center.X, npc.Center.Y, delta.X, delta.Y, mod.ProjectileType("DeadlyLaser"), 800, 0, Main.myPlayer);
					}
					if (counter >= 20)
					{
						counter = 0;
						Vector2 delta = player.Center - npc.Center;
						float magnitude = (float)Math.Sqrt(delta.X * delta.X + delta.Y * delta.Y);
						if (magnitude > 0)
						{
							delta *= 5f / magnitude;
						}
						else
						{
							delta = new Vector2(0f, 5f);
						}
						delta *= 2f;
						Vector2 delta2 = delta.RotatedByRandom(MathHelper.ToRadians(15));
						Vector2 delta3 = delta.RotatedByRandom(MathHelper.ToRadians(15));
						Vector2 delta4 = delta.RotatedByRandom(MathHelper.ToRadians(35));
						Vector2 delta5 = delta.RotatedByRandom(MathHelper.ToRadians(35));
						Vector2 delta6 = delta.RotatedByRandom(MathHelper.ToRadians(50));
						Vector2 delta7 = delta.RotatedByRandom(MathHelper.ToRadians(50));
						Projectile.NewProjectile(npc.Center.X, npc.Center.Y, delta.X, delta.Y, 100, damage1, 0, Main.myPlayer);
						Projectile.NewProjectile(npc.Center.X, npc.Center.Y, delta2.X, delta2.Y, 100, damage1, 0, Main.myPlayer);
						Projectile.NewProjectile(npc.Center.X, npc.Center.Y, delta3.X, delta3.Y, 100, damage1, 0, Main.myPlayer);
						Projectile.NewProjectile(npc.Center.X, npc.Center.Y, delta4.X, delta3.Y, 100, damage1, 0, Main.myPlayer);
						Projectile.NewProjectile(npc.Center.X, npc.Center.Y, delta5.X, delta3.Y, 100, damage1, 0, Main.myPlayer);
						Projectile.NewProjectile(npc.Center.X, npc.Center.Y, delta6.X, delta3.Y, 100, damage1, 0, Main.myPlayer);
						Projectile.NewProjectile(npc.Center.X, npc.Center.Y, delta7.X, delta3.Y, 100, damage1, 0, Main.myPlayer);
					}
					counter++;
					counter2++;
				}
			}
			if (npc.life < npc.lifeMax/2 && npc.life > npc.lifeMax/10 && !player.dead && !npc.GetGlobalNPC<ModGlobalNPC>(mod).intermedia2)
			{
				player.AddBuff((mod.BuffType("Madness")), 2);
				if (counter >= 15)
				{
					counter = 0;
					Vector2 delta = player.Center - npc.Center;
					float magnitude = (float)Math.Sqrt(delta.X * delta.X + delta.Y * delta.Y);
					if (magnitude > 0)
					{
						delta *= (5f / magnitude);
					}
					else
					{
						delta = new Vector2(0f, 5f);
					}
					delta *= 2.5f;
					Vector2 delta2 = delta.RotatedByRandom(MathHelper.ToRadians(20));
					Vector2 delta3 = delta.RotatedByRandom(MathHelper.ToRadians(20));
					Vector2 delta4 = delta.RotatedByRandom(MathHelper.ToRadians(15));
					Vector2 delta5 = delta.RotatedByRandom(MathHelper.ToRadians(15));
					Vector2 delta6 = delta.RotatedByRandom(MathHelper.ToRadians(10));
					Vector2 delta7 = delta.RotatedByRandom(MathHelper.ToRadians(10));
					Projectile.NewProjectile(npc.Center.X, npc.Center.Y, delta.X, delta.Y, mod.ProjectileType("DeadlyLaser"), 800, 0, Main.myPlayer);
					Projectile.NewProjectile(npc.Center.X, npc.Center.Y, delta2.X, delta2.Y, 100, damage2, 0, Main.myPlayer);
					Projectile.NewProjectile(npc.Center.X, npc.Center.Y, delta3.X, delta3.Y, 100, damage2, 0, Main.myPlayer);
					Projectile.NewProjectile(npc.Center.X, npc.Center.Y, delta4.X, delta4.Y, 100, damage2, 0, Main.myPlayer);
					Projectile.NewProjectile(npc.Center.X, npc.Center.Y, delta5.X, delta5.Y, 100, damage2, 0, Main.myPlayer);
					Projectile.NewProjectile(npc.Center.X, npc.Center.Y, delta6.X, delta6.Y, 100, damage2, 0, Main.myPlayer);
					Projectile.NewProjectile(npc.Center.X, npc.Center.Y, delta7.X, delta7.Y, 100, damage2, 0, Main.myPlayer);
				}
				counter++;
			}
			if (npc.life < npc.lifeMax/10 && !player.dead)
			{
				player.AddBuff((mod.BuffType("Madness")), 2);
				if (counter2 >= 15)
				{
					counter2 = 0;
					Vector2 delta = player.Center - npc.Center;
					float magnitude = (float)Math.Sqrt(delta.X * delta.X + delta.Y * delta.Y);
					if (magnitude > 0)
					{
						delta *= (5f / magnitude);
					}
					else
					{
						delta = new Vector2(0f, 5f);
					}
					delta *= 5f;
					Vector2 delta2 = delta.RotatedByRandom(MathHelper.ToRadians(10));
					Vector2 delta3 = delta.RotatedByRandom(MathHelper.ToRadians(10));
					Vector2 delta4 = delta.RotatedByRandom(MathHelper.ToRadians(20));
					Vector2 delta5 = delta.RotatedByRandom(MathHelper.ToRadians(20));
					Vector2 delta6 = delta.RotatedByRandom(MathHelper.ToRadians(35));
					Vector2 delta7 = delta.RotatedByRandom(MathHelper.ToRadians(35));
					Projectile.NewProjectile(npc.Center.X, npc.Center.Y, delta.X, delta.Y, 348, damage3, 0, Main.myPlayer);
					Projectile.NewProjectile(npc.Center.X, npc.Center.Y, delta2.X, delta2.Y, 348, damage3, 0, Main.myPlayer);
					Projectile.NewProjectile(npc.Center.X, npc.Center.Y, delta3.X, delta3.Y, 348, damage3, 0, Main.myPlayer);
					Projectile.NewProjectile(npc.Center.X, npc.Center.Y, delta4.X, delta4.Y, 348, damage3, 0, Main.myPlayer);
					Projectile.NewProjectile(npc.Center.X, npc.Center.Y, delta5.X, delta5.Y, 348, damage3, 0, Main.myPlayer);
					Projectile.NewProjectile(npc.Center.X, npc.Center.Y, delta6.X, delta6.Y, 348, damage3, 0, Main.myPlayer);
					Projectile.NewProjectile(npc.Center.X, npc.Center.Y, delta7.X, delta7.Y, 348, damage3, 0, Main.myPlayer);
				}
				counter2++;
			}
			if (ModLoader.GetLoadedMods().Contains("CalamityMod"))
			{
				if (CalamityModRevengeance)
				{
					CalamityMod.CalamityPlayer CalamityPlayer = player.GetModPlayer<CalamityMod.CalamityPlayer>(Calamity);
					CalamityPlayer.stress = 0;
					CalamityPlayer.adrenaline = 0;
				}
			}
		}
		
		public bool CalamityModRevengeance
		{
        get { return CalamityMod.CalamityWorld.revenge; }
        }
		
		private readonly Mod Calamity = ModLoader.GetMod("CalamityMod");
		
		const int Frame_P11 = 0;
		const int Frame_P12 = 1;
		const int Frame_P13 = 2;
		const int Frame_P21 = 3;
		const int Frame_P22 = 4;
		const int Frame_P23 = 5;
		
		public override void FindFrame(int frameHeight)
		{
			if (!npc.GetGlobalNPC<ModGlobalNPC>(mod).phase2)
			{
				npc.frameCounter++;
				if (npc.frameCounter < 100)
				{
					npc.frame.Y = Frame_P11 * frameHeight;
				}
				else if (npc.frameCounter < 115)
				{
					npc.frame.Y = Frame_P12 * frameHeight;
				}
				else if (npc.frameCounter < 120)
				{
					npc.frame.Y = Frame_P13 * frameHeight;
				}
				else if (npc.frameCounter < 125)
				{
					npc.frame.Y = Frame_P12 * frameHeight;
				}
				else
				{
					npc.frameCounter = 0;
				}
			}
			if (npc.GetGlobalNPC<ModGlobalNPC>(mod).phase2)
			{
				if (npc.frameCounter < 100)
				{
					npc.frame.Y = Frame_P21 * frameHeight;
				}
				else if (npc.frameCounter < 115)
				{
					npc.frame.Y = Frame_P22 * frameHeight;
				}
				else if (npc.frameCounter < 120)
				{
					npc.frame.Y = Frame_P23 * frameHeight;
				}
				else if (npc.frameCounter < 125)
				{
					npc.frame.Y = Frame_P22 * frameHeight;
				}
				else
				{
					npc.frameCounter = 0;
				}
			}
		}
		
		public override void ModifyHitByProjectile(Projectile projectile, ref int damage, ref float knockback, ref bool crit, ref int	hitDirection)	
		{
			if (projectile.type == mod.ProjectileType("QuantumDestabilizer"))
			{
			damage *= 5;
			}
		}
		
		public override void NPCLoot()
		{
			if (Main.expertMode)
			{
				npc.DropBossBags();
			}
			else
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("WrathOfTheCelestial"));
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.PlatinumCoin, 50);
			}
		}
		
		public override void BossLoot(ref string name, ref int potionType)
		{
			potionType = ItemID.SuperHealingPotion;
		}
		
		public override bool StrikeNPC(ref double damage, int defense, ref float knockback, int hitDirection, ref bool crit)	
		{
			Player player = Main.player[(int)Player.FindClosest(npc.position, npc.width, npc.height)];
			if (npc.life > npc.lifeMax/10)
			{
			damage /= 10;
			}
			if (npc.life < npc.lifeMax/10)
			{
			damage /= 15;
			}
			if (player.HeldItem.type == mod.ItemType("LastTantrum"))
			{
			damage /= 300;
			}
		return false;
		}
	}
}