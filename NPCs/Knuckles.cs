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
using Terraria.GameInput;
using AlchemistNPC;
 
namespace AlchemistNPC.NPCs
{
	[AutoloadBossHead]
	class Knuckles : ModNPC
	{
		public override bool Autoload(ref string name)
		{
			return ModLoader.GetMod("AlchemistNPCContentDisabler") == null;
		}
		
		public override void SetDefaults()
		{
			npc.CloneDefaults(NPCID.DungeonGuardian);
			npc.boss = true;
			npc.width = 96;
			npc.height = 76;
			npc.damage = 666666;
			npc.defense = 1;
			npc.lifeMax = 333333;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath2;
			npc.value = 333f;
			npc.knockBackResist = 999f;
			npc.aiStyle = 11;
			aiType = NPCID.DungeonGuardian;
			animationType = NPCID.DungeonGuardian;
			music = MusicID.Boss2;
			bossBag = mod.ItemType("KnucklesBag");
		}
		
		public override void SetStaticDefaults()
		{
		DisplayName.SetDefault("Ugandan Knuckles");
		}
		
		public override void BossHeadRotation(ref float rotation)
        {
            rotation = npc.rotation;
        }
		
		public override void AI()
		{
			npc.buffImmune[mod.BuffType("ArmorDestruction")] = true;
			npc.velocity *= 1.5f;
			npc.defense = 1;
			int damage1 = 200;
			int damage2 = 300;
			int damage3 = 350;
			if (Main.player[(int)Player.FindClosest(npc.position, npc.width, npc.height)].GetModPlayer<AlchemistNPCPlayer>(mod).MemersRiposte)
			{
			damage1 = 100;
			damage2 = 150;
			damage3 = 175;
			}
			Player player = Main.player[(int)Player.FindClosest(npc.position, npc.width, npc.height)];
			if (player.statDefense > 250 || player.endurance > 0.40f || player.statLifeMax2 > 1300)
			{
			damage1 = 666666;
			damage2 = 666666;
			damage3 = 666666;
			}
			if (!Main.expertMode)
			{
				if (npc.life > 166666)
				{
					if (Main.rand.Next(20) == 0)
					{
					Vector2 vel = new Vector2(-1, -1);
					vel *= 8f;
					Projectile.NewProjectile(npc.Center.X, npc.Center.Y, vel.X, vel.Y, 100, damage1, 0, Main.myPlayer);
					Vector2 vel2 = new Vector2(1, 1);
					vel2 *= 8f;
					Projectile.NewProjectile(npc.Center.X, npc.Center.Y, vel2.X, vel2.Y, 100, damage1, 0, Main.myPlayer);
					Vector2 vel3 = new Vector2(1, -1);
					vel3 *= 8f;
					Projectile.NewProjectile(npc.Center.X, npc.Center.Y, vel3.X, vel3.Y, 100, damage1, 0, Main.myPlayer);
					Vector2 vel4 = new Vector2(-1, 1);
					vel4 *= 8f;
					Projectile.NewProjectile(npc.Center.X, npc.Center.Y, vel4.X, vel4.Y, 100, damage1, 0, Main.myPlayer);
					Vector2 vel5 = new Vector2(0, -1);
					vel5 *= 8f;
					Projectile.NewProjectile(npc.Center.X, npc.Center.Y, vel5.X, vel5.Y, 100, damage1, 0, Main.myPlayer);
					Vector2 vel6 = new Vector2(0, 1);
					vel6 *= 8f;
					Projectile.NewProjectile(npc.Center.X, npc.Center.Y, vel6.X, vel6.Y, 100, damage1, 0, Main.myPlayer);
					Vector2 vel7 = new Vector2(1, 0);
					vel7 *= 8f;
					Projectile.NewProjectile(npc.Center.X, npc.Center.Y, vel7.X, vel7.Y, 100, damage1, 0, Main.myPlayer);
					Vector2 vel8 = new Vector2(-1, 0);
					vel8 *= 8f;
					Projectile.NewProjectile(npc.Center.X, npc.Center.Y, vel8.X, vel8.Y, 100, damage1, 0, Main.myPlayer);
					}
				}
				else
				{
				if (Main.rand.Next(25) == 0)
					{
					Vector2 vel = new Vector2(-1, -1);
					vel *= 9f;
					Projectile.NewProjectile(npc.Center.X, npc.Center.Y, vel.X, vel.Y, 449, damage2, 0, Main.myPlayer);
					Vector2 vel2 = new Vector2(1, 1);
					vel2 *= 9f;
					Projectile.NewProjectile(npc.Center.X, npc.Center.Y, vel2.X, vel2.Y, 449, damage2, 0, Main.myPlayer);
					Vector2 vel3 = new Vector2(1, -1);
					vel3 *= 9f;
					Projectile.NewProjectile(npc.Center.X, npc.Center.Y, vel3.X, vel3.Y, 449, damage2, 0, Main.myPlayer);
					Vector2 vel4 = new Vector2(-1, 1);
					vel4 *= 9f;
					Projectile.NewProjectile(npc.Center.X, npc.Center.Y, vel4.X, vel4.Y, 449, damage2, 0, Main.myPlayer);
					Vector2 vel5 = new Vector2(0, -1);
					vel5 *= 9f;
					Projectile.NewProjectile(npc.Center.X, npc.Center.Y, vel5.X, vel5.Y, 449, damage2, 0, Main.myPlayer);
					Vector2 vel6 = new Vector2(0, 1);
					vel6 *= 9f;
					Projectile.NewProjectile(npc.Center.X, npc.Center.Y, vel6.X, vel6.Y, 449, damage2, 0, Main.myPlayer);
					Vector2 vel7 = new Vector2(1, 0);
					vel7 *= 9f;
					Projectile.NewProjectile(npc.Center.X, npc.Center.Y, vel7.X, vel7.Y, 449, damage2, 0, Main.myPlayer);
					Vector2 vel8 = new Vector2(-1, 0);
					vel8 *= 9f;
					Projectile.NewProjectile(npc.Center.X, npc.Center.Y, vel8.X, vel8.Y, 449, damage2, 0, Main.myPlayer);
					}
				if (Main.rand.Next(60) == 0)
					{
					Vector2 vel = new Vector2(-1, -1);
					vel *= 12f;
					Projectile.NewProjectile(npc.Center.X, npc.Center.Y, vel.X, vel.Y, 448, damage2, 0, Main.myPlayer);
					Vector2 vel2 = new Vector2(1, 1);
					vel2 *= 12f;
					Projectile.NewProjectile(npc.Center.X, npc.Center.Y, vel2.X, vel2.Y, 448, damage2, 0, Main.myPlayer);
					Vector2 vel3 = new Vector2(1, -1);
					vel3 *= 12f;
					Projectile.NewProjectile(npc.Center.X, npc.Center.Y, vel3.X, vel3.Y, 448, damage2, 0, Main.myPlayer);
					Vector2 vel4 = new Vector2(-1, 1);
					vel4 *= 12f;
					Projectile.NewProjectile(npc.Center.X, npc.Center.Y, vel4.X, vel4.Y, 448, damage2, 0, Main.myPlayer);
					Vector2 vel5 = new Vector2(0, -1);
					vel5 *= 12f;
					Projectile.NewProjectile(npc.Center.X, npc.Center.Y, vel5.X, vel5.Y, 448, damage2, 0, Main.myPlayer);
					Vector2 vel6 = new Vector2(0, 1);
					vel6 *= 12f;
					Projectile.NewProjectile(npc.Center.X, npc.Center.Y, vel6.X, vel6.Y, 448, damage2, 0, Main.myPlayer);
					Vector2 vel7 = new Vector2(1, 0);
					vel7 *= 12f;
					Projectile.NewProjectile(npc.Center.X, npc.Center.Y, vel7.X, vel7.Y, 448, damage2, 0, Main.myPlayer);
					Vector2 vel8 = new Vector2(-1, 0);
					vel8 *= 12f;
					Projectile.NewProjectile(npc.Center.X, npc.Center.Y, vel8.X, vel8.Y, 448, damage2, 0, Main.myPlayer);
					}
				}
			}
			if (Main.expertMode)
			{
			if (npc.life > 333333)
				{
				if (Main.rand.Next(20) == 0)
					{
					Vector2 vel = new Vector2(-1, -1);
					vel *= 8f;
					Projectile.NewProjectile(npc.Center.X, npc.Center.Y, vel.X, vel.Y, 100, damage1, 0, Main.myPlayer);
					Vector2 vel2 = new Vector2(1, 1);
					vel2 *= 8f;
					Projectile.NewProjectile(npc.Center.X, npc.Center.Y, vel2.X, vel2.Y, 100, damage1, 0, Main.myPlayer);
					Vector2 vel3 = new Vector2(1, -1);
					vel3 *= 8f;
					Projectile.NewProjectile(npc.Center.X, npc.Center.Y, vel3.X, vel3.Y, 100, damage1, 0, Main.myPlayer);
					Vector2 vel4 = new Vector2(-1, 1);
					vel4 *= 8f;
					Projectile.NewProjectile(npc.Center.X, npc.Center.Y, vel4.X, vel4.Y, 100, damage1, 0, Main.myPlayer);
					Vector2 vel5 = new Vector2(0, -1);
					vel5 *= 8f;
					Projectile.NewProjectile(npc.Center.X, npc.Center.Y, vel5.X, vel5.Y, 100, damage1, 0, Main.myPlayer);
					Vector2 vel6 = new Vector2(0, 1);
					vel6 *= 8f;
					Projectile.NewProjectile(npc.Center.X, npc.Center.Y, vel6.X, vel6.Y, 100, damage1, 0, Main.myPlayer);
					Vector2 vel7 = new Vector2(1, 0);
					vel7 *= 8f;
					Projectile.NewProjectile(npc.Center.X, npc.Center.Y, vel7.X, vel7.Y, 100, damage1, 0, Main.myPlayer);
					Vector2 vel8 = new Vector2(-1, 0);
					vel8 *= 8f;
					Projectile.NewProjectile(npc.Center.X, npc.Center.Y, vel8.X, vel8.Y, 100, damage1, 0, Main.myPlayer);
					}
				}
				if (npc.life > 166666 && npc.life < 333333)
				{
					if (Main.rand.Next(25) == 0)
					{
					Vector2 vel = new Vector2(-1, -1);
					vel *= 9f;
					Projectile.NewProjectile(npc.Center.X, npc.Center.Y, vel.X, vel.Y, 449, damage2, 0, Main.myPlayer);
					Vector2 vel2 = new Vector2(1, 1);
					vel2 *= 9f;
					Projectile.NewProjectile(npc.Center.X, npc.Center.Y, vel2.X, vel2.Y, 449, damage2, 0, Main.myPlayer);
					Vector2 vel3 = new Vector2(1, -1);
					vel3 *= 9f;
					Projectile.NewProjectile(npc.Center.X, npc.Center.Y, vel3.X, vel3.Y, 449, damage2, 0, Main.myPlayer);
					Vector2 vel4 = new Vector2(-1, 1);
					vel4 *= 9f;
					Projectile.NewProjectile(npc.Center.X, npc.Center.Y, vel4.X, vel4.Y, 449, damage2, 0, Main.myPlayer);
					Vector2 vel5 = new Vector2(0, -1);
					vel5 *= 9f;
					Projectile.NewProjectile(npc.Center.X, npc.Center.Y, vel5.X, vel5.Y, 449, damage2, 0, Main.myPlayer);
					Vector2 vel6 = new Vector2(0, 1);
					vel6 *= 9f;
					Projectile.NewProjectile(npc.Center.X, npc.Center.Y, vel6.X, vel6.Y, 449, damage2, 0, Main.myPlayer);
					Vector2 vel7 = new Vector2(1, 0);
					vel7 *= 9f;
					Projectile.NewProjectile(npc.Center.X, npc.Center.Y, vel7.X, vel7.Y, 449, damage2, 0, Main.myPlayer);
					Vector2 vel8 = new Vector2(-1, 0);
					vel8 *= 9f;
					Projectile.NewProjectile(npc.Center.X, npc.Center.Y, vel8.X, vel8.Y, 449, damage2, 0, Main.myPlayer);
					}
					if (Main.rand.Next(60) == 0)
					{
					Vector2 vel = new Vector2(-1, -1);
					vel *= 12f;
					Projectile.NewProjectile(npc.Center.X, npc.Center.Y, vel.X, vel.Y, 448, damage2, 0, Main.myPlayer);
					Vector2 vel2 = new Vector2(1, 1);
					vel2 *= 12f;
					Projectile.NewProjectile(npc.Center.X, npc.Center.Y, vel2.X, vel2.Y, 448, damage2, 0, Main.myPlayer);
					Vector2 vel3 = new Vector2(1, -1);
					vel3 *= 12f;
					Projectile.NewProjectile(npc.Center.X, npc.Center.Y, vel3.X, vel3.Y, 448, damage2, 0, Main.myPlayer);
					Vector2 vel4 = new Vector2(-1, 1);
					vel4 *= 12f;
					Projectile.NewProjectile(npc.Center.X, npc.Center.Y, vel4.X, vel4.Y, 448, damage2, 0, Main.myPlayer);
					Vector2 vel5 = new Vector2(0, -1);
					vel5 *= 12f;
					Projectile.NewProjectile(npc.Center.X, npc.Center.Y, vel5.X, vel5.Y, 448, damage2, 0, Main.myPlayer);
					Vector2 vel6 = new Vector2(0, 1);
					vel6 *= 12f;
					Projectile.NewProjectile(npc.Center.X, npc.Center.Y, vel6.X, vel6.Y, 448, damage2, 0, Main.myPlayer);
					Vector2 vel7 = new Vector2(1, 0);
					vel7 *= 12f;
					Projectile.NewProjectile(npc.Center.X, npc.Center.Y, vel7.X, vel7.Y, 448, damage2, 0, Main.myPlayer);
					Vector2 vel8 = new Vector2(-1, 0);
					vel8 *= 12f;
					Projectile.NewProjectile(npc.Center.X, npc.Center.Y, vel8.X, vel8.Y, 448, damage2, 0, Main.myPlayer);
					}
				}
				if (npc.life < 166666)
				{
					if (Main.rand.Next(20) == 0)
					{
					Vector2 vel = new Vector2(-1, -1);
					vel *= 12f;
					Projectile.NewProjectile(npc.Center.X, npc.Center.Y, vel.X, vel.Y, 449, damage3, 0, Main.myPlayer);
					Vector2 vel2 = new Vector2(1, 1);
					vel2 *= 12f;
					Projectile.NewProjectile(npc.Center.X, npc.Center.Y, vel2.X, vel2.Y, 449, damage3, 0, Main.myPlayer);
					Vector2 vel3 = new Vector2(1, -1);
					vel3 *= 12f;
					Projectile.NewProjectile(npc.Center.X, npc.Center.Y, vel3.X, vel3.Y, 449, damage3, 0, Main.myPlayer);
					Vector2 vel4 = new Vector2(-1, 1);
					vel4 *= 12f;
					Projectile.NewProjectile(npc.Center.X, npc.Center.Y, vel4.X, vel4.Y, 449, damage3, 0, Main.myPlayer);
					Vector2 vel5 = new Vector2(0, -1);
					vel5 *= 12f;
					Projectile.NewProjectile(npc.Center.X, npc.Center.Y, vel5.X, vel5.Y, 449, damage3, 0, Main.myPlayer);
					Vector2 vel6 = new Vector2(0, 1);
					vel6 *= 12f;
					Projectile.NewProjectile(npc.Center.X, npc.Center.Y, vel6.X, vel6.Y, 449, damage3, 0, Main.myPlayer);
					Vector2 vel7 = new Vector2(1, 0);
					vel7 *= 12f;
					Projectile.NewProjectile(npc.Center.X, npc.Center.Y, vel7.X, vel7.Y, 449, damage3, 0, Main.myPlayer);
					Vector2 vel8 = new Vector2(-1, 0);
					vel8 *= 12f;
					Projectile.NewProjectile(npc.Center.X, npc.Center.Y, vel8.X, vel8.Y, 449, damage3, 0, Main.myPlayer);
					}
					if (Main.rand.Next(50) == 0)
					{
					Vector2 vel = new Vector2(-1, -1);
					vel *= 14f;
					Projectile.NewProjectile(npc.Center.X, npc.Center.Y, vel.X, vel.Y, 448, damage3, 0, Main.myPlayer);
					Vector2 vel2 = new Vector2(1, 1);
					vel2 *= 14f;
					Projectile.NewProjectile(npc.Center.X, npc.Center.Y, vel2.X, vel2.Y, 448, damage3, 0, Main.myPlayer);
					Vector2 vel3 = new Vector2(1, -1);
					vel3 *= 14f;
					Projectile.NewProjectile(npc.Center.X, npc.Center.Y, vel3.X, vel3.Y, 448, damage3, 0, Main.myPlayer);
					Vector2 vel4 = new Vector2(-1, 1);
					vel4 *= 14f;
					Projectile.NewProjectile(npc.Center.X, npc.Center.Y, vel4.X, vel4.Y, 448, damage3, 0, Main.myPlayer);
					Vector2 vel5 = new Vector2(0, -1);
					vel5 *= 14f;
					Projectile.NewProjectile(npc.Center.X, npc.Center.Y, vel5.X, vel5.Y, 448, damage3, 0, Main.myPlayer);
					Vector2 vel6 = new Vector2(0, 1);
					vel6 *= 14f;
					Projectile.NewProjectile(npc.Center.X, npc.Center.Y, vel6.X, vel6.Y, 448, damage3, 0, Main.myPlayer);
					Vector2 vel7 = new Vector2(1, 0);
					vel7 *= 14f;
					Projectile.NewProjectile(npc.Center.X, npc.Center.Y, vel7.X, vel7.Y, 448, damage3, 0, Main.myPlayer);
					Vector2 vel8 = new Vector2(-1, 0);
					vel8 *= 14f;
					Projectile.NewProjectile(npc.Center.X, npc.Center.Y, vel8.X, vel8.Y, 448, damage3, 0, Main.myPlayer);
					}
				}
			}
		}
		public override void OnHitPlayer(Player target, int damage, bool crit)
		{
		target.AddBuff(mod.BuffType("Uganda"), 1200);
		if (target.statDefense > 250 || target.endurance > 0.40f || target.statLifeMax2 > 1300)
			{
			target.AddBuff(mod.BuffType("TrueUganda"), 3600);
			}
		}
		
		public override void ModifyHitPlayer(Player player, ref int damage, ref bool crit)
		{
			if (player.statDefense > 250 || player.endurance > 0.40f || player.statLifeMax2 > 1300)
			{
			damage = 666666;
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
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("LastTantrum"));
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.PlatinumCoin, 25);
			}
		}
		
		public override void BossLoot(ref string name, ref int potionType)
		{
			potionType = ItemID.SuperHealingPotion;
		}
		
		public override bool StrikeNPC(ref double damage, int defense, ref float knockback, int hitDirection, ref bool crit)	
		{
			if (Main.player[(int)Player.FindClosest(npc.position, npc.width, npc.height)].GetModPlayer<AlchemistNPCPlayer>(mod).MemersRiposte == false)
			{
			damage = 1;
				if (crit)
				{
				damage = 2;
				}
			}
			if (Main.player[(int)Player.FindClosest(npc.position, npc.width, npc.height)].GetModPlayer<AlchemistNPCPlayer>(mod).MemersRiposte)
			{
			damage = 2;
				if (crit)
				{
				damage = 4;
				}
			}
			defense = 1;
		return false;
		}
	}
}