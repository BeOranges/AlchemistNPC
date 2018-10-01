using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace AlchemistNPC.NPCs
{
	public class ModGlobalNPC : GlobalNPC
	{
		public bool rainbowdust = false;
		public bool electrocute = false;
		public bool corrosion = false;
		public bool twilight = false;
		public bool justitiapale = false;
		public bool N1 = false;
		public bool N2 = false;
		public bool N3 = false;
		public bool N4 = false;
		public bool N5 = false;
		public bool N6 = false;
		public bool N7 = false;
		public bool N8 = false;
		public bool N9 = false;
		public static int npcNow;

		public override bool PreAI(NPC npc)
		{
			npcNow = npc.whoAmI;
			return true;
		}

		public bool i1 = false;
		public bool i2 = false;
		public bool i3 = false;
		public int bc = 0;
		public int bc2 = 0;
		public bool start = false;
		public bool intermission1 = false;
		public bool stop1 = false;
		public bool intermission2 = false;
		public bool stop2 = false;
		public bool phase2 = false;
		public bool phase3 = false;
		
		public override bool InstancePerEntity
		{
			get
			{
				return true;
			}
		}

		public override void ModifyHitByItem(NPC npc, Player player, Item item, ref int damage, ref float knockback, ref bool crit)
		{
			if (npc.FindBuffIndex(mod.BuffType("CurseOfLight")) > -1)
			{
				damage += damage / 5;
			}
			if (npc.FindBuffIndex(mod.BuffType("SymbolOfPain")) > -1)
			{
				damage += damage/4;
			}
			if (player.HasBuff(mod.BuffType("ExecutionersEyes")))
			{
				damage += (damage/20)*3;
			}
		}

		public override void ModifyHitByProjectile(NPC npc, Projectile projectile, ref int damage, ref float knockback, ref bool crit, ref int hitDirection)
		{
			if (npc.FindBuffIndex(mod.BuffType("CurseOfLight")) > -1)
			{
				damage += damage / 5;
			}
			if (npc.FindBuffIndex(mod.BuffType("SymbolOfPain")) > -1)
			{
				damage += damage/4;
			}
			Player player = Main.player[(int)Player.FindClosest(npc.position, npc.width, npc.height)];
			if (player.HasBuff(mod.BuffType("LaserBattery")) && projectile.type == 433)
			{
				projectile.ranged = true;
				if (Main.rand.Next(4) == 0)
				{
					crit = true;
				}
			}
			if (player.HasBuff(mod.BuffType("ExecutionersEyes")))
			{
				damage += (damage/20)*3;
			}
		}

		public override void ModifyHitPlayer(NPC npc, Player target, ref int damage, ref bool crit)
		{
			if (npc.FindBuffIndex(mod.BuffType("CurseOfLight")) > -1 && Main.rand.Next(4) == 0)
			{
				damage /= 2;
			}
			if (npc.FindBuffIndex(mod.BuffType("SymbolOfPain")) > -1)
			{
				damage -= damage/4;
			}
		}

		public override void SetupShop(int type, Chest shop, ref int nextSlot)
		{
			if (ModLoader.GetLoadedMods().Contains("Tremor"))
			{
				if (type == ModLoader.GetMod("Tremor").NPCType("Lady Moon"))
				{
					shop.item[nextSlot].SetDefaults(ModLoader.GetMod("Tremor").ItemType("DarkMass"));
					shop.item[nextSlot].shopCustomPrice = 7500;
					nextSlot++;
					shop.item[nextSlot].SetDefaults(ModLoader.GetMod("Tremor").ItemType("CarbonSteel"));
					shop.item[nextSlot].shopCustomPrice = 10000;
					nextSlot++;
					shop.item[nextSlot].SetDefaults(ModLoader.GetMod("Tremor").ItemType("Doomstone"));
					shop.item[nextSlot].shopCustomPrice = 25000;
					nextSlot++;
					shop.item[nextSlot].SetDefaults(ModLoader.GetMod("Tremor").ItemType("NightmareBar"));
					shop.item[nextSlot].shopCustomPrice = 25000;
					nextSlot++;
					shop.item[nextSlot].SetDefaults(ModLoader.GetMod("Tremor").ItemType("VoidBar"));
					shop.item[nextSlot].shopCustomPrice = 50000;
					nextSlot++;
					shop.item[nextSlot].SetDefaults(ModLoader.GetMod("Tremor").ItemType("AngryShard"));
					shop.item[nextSlot].shopCustomPrice = 50000;
					nextSlot++;
					shop.item[nextSlot].SetDefaults(ModLoader.GetMod("Tremor").ItemType("Phantaplasm"));
					shop.item[nextSlot].shopCustomPrice = 50000;
					nextSlot++;
					shop.item[nextSlot].SetDefaults(ModLoader.GetMod("Tremor").ItemType("ClusterShard"));
					shop.item[nextSlot].shopCustomPrice = 50000;
					nextSlot++;
					shop.item[nextSlot].SetDefaults(ModLoader.GetMod("Tremor").ItemType("DragonCapsule"));
					shop.item[nextSlot].shopCustomPrice = 50000;
					nextSlot++;
					shop.item[nextSlot].SetDefaults(ModLoader.GetMod("Tremor").ItemType("HuskofDusk"));
					shop.item[nextSlot].shopCustomPrice = 100000;
					nextSlot++;
					shop.item[nextSlot].SetDefaults(ModLoader.GetMod("Tremor").ItemType("NightCore"));
					shop.item[nextSlot].shopCustomPrice = 100000;
					nextSlot++;
					shop.item[nextSlot].SetDefaults(ModLoader.GetMod("Tremor").ItemType("GoldenClaw"));
					shop.item[nextSlot].shopCustomPrice = 100000;
					nextSlot++;
					shop.item[nextSlot].SetDefaults(ModLoader.GetMod("Tremor").ItemType("StoneDice"));
					shop.item[nextSlot].shopCustomPrice = 100000;
					nextSlot++;
					shop.item[nextSlot].SetDefaults(ModLoader.GetMod("Tremor").ItemType("ConcentratedEther"));
					shop.item[nextSlot].shopCustomPrice = 100000;
					nextSlot++;
					shop.item[nextSlot].SetDefaults(ModLoader.GetMod("Tremor").ItemType("Squorb"));
					shop.item[nextSlot].shopCustomPrice = 250000;
					nextSlot++;
					shop.item[nextSlot].SetDefaults(ModLoader.GetMod("Tremor").ItemType("ToothofAbraxas"));
					shop.item[nextSlot].shopCustomPrice = 250000;
					nextSlot++;
					shop.item[nextSlot].SetDefaults(ModLoader.GetMod("Tremor").ItemType("CosmicFuel"));
					shop.item[nextSlot].shopCustomPrice = 1000000;
					nextSlot++;
					shop.item[nextSlot].SetDefaults(ModLoader.GetMod("Tremor").ItemType("EyeofOblivion"));
					shop.item[nextSlot].shopCustomPrice = 3000000;
					nextSlot++;
				}
			}
		}

		public override void SetDefaults(NPC npc)
		{
			if (npc.type == NPCID.Steampunker || npc.type == NPCID.Wizard || npc.type == NPCID.Guide || npc.type == NPCID.Nurse || npc.type == NPCID.Demolitionist || npc.type == NPCID.Merchant || npc.type == NPCID.DyeTrader || npc.type == NPCID.Dryad || npc.type == NPCID.DD2Bartender || npc.type == NPCID.ArmsDealer || npc.type == NPCID.Stylist || npc.type == NPCID.Painter || npc.type == NPCID.Angler || npc.type == NPCID.GoblinTinkerer || npc.type == NPCID.WitchDoctor || npc.type == NPCID.Clothier || npc.type == NPCID.Mechanic || npc.type == NPCID.PartyGirl || npc.type == NPCID.TaxCollector || npc.type == NPCID.Truffle || npc.type == NPCID.Pirate || npc.type == NPCID.Cyborg || npc.type == NPCID.SantaClaus)
			{
				if (NPC.downedMoonlord)
				{
					npc.lifeMax = 500;
				}
			}
			if (npc.type == mod.NPCType("Alchemist") || npc.type == mod.NPCType("Brewer") || npc.type == mod.NPCType("Young Brewer") || npc.type == mod.NPCType("Jeweler") || npc.type == mod.NPCType("Architect"))
			{
				if (NPC.downedMoonlord)
				{
					npc.lifeMax = 500;
				}
			}
			if (ModLoader.GetLoadedMods().Contains("MaterialTraderNpc"))
			{
				if (npc.type == (ModLoader.GetMod("MaterialTraderNpc").NPCType("Jungle Trader")) || npc.type == (ModLoader.GetMod("MaterialTraderNpc").NPCType("Cavern Trader")) || npc.type == (ModLoader.GetMod("MaterialTraderNpc").NPCType("Cool Guy")) || npc.type == (ModLoader.GetMod("MaterialTraderNpc").NPCType("Desert Trader")) || npc.type == (ModLoader.GetMod("MaterialTraderNpc").NPCType("Dungeon Trader")) || npc.type == (ModLoader.GetMod("MaterialTraderNpc").NPCType("Evil Trader")) || npc.type == (ModLoader.GetMod("MaterialTraderNpc").NPCType("Hell Trader")) || npc.type == (ModLoader.GetMod("MaterialTraderNpc").NPCType("Holy Trader")) || npc.type == (ModLoader.GetMod("MaterialTraderNpc").NPCType("Ocean Trader")) || npc.type == (ModLoader.GetMod("MaterialTraderNpc").NPCType("Sky Trader")) || npc.type == (ModLoader.GetMod("MaterialTraderNpc").NPCType("Winter Trader")))
				{
					if (NPC.downedMoonlord)
					{
						npc.lifeMax = 500;
					}
				}
			}
			if (npc.type == NPCID.Unicorn)
			{
				Main.npcCatchable[npc.type] = true;
				npc.catchItem = (short)mod.ItemType("CaughtUnicorn");
			}
			if (npc.type == mod.NPCType("Alchemist"))
			{
				Main.npcCatchable[npc.type] = true;
				npc.catchItem = (short)mod.ItemType("AlchemistHorcrux");
			}
			if (npc.type == mod.NPCType("Brewer"))
			{
				Main.npcCatchable[npc.type] = true;
				npc.catchItem = (short)mod.ItemType("BrewerHorcrux");
			}
			if (npc.type == mod.NPCType("Architect"))
			{
				Main.npcCatchable[npc.type] = true;
				npc.catchItem = (short)mod.ItemType("ArchitectHorcrux");
			}
			if (npc.type == mod.NPCType("Jeweler"))
			{
				Main.npcCatchable[npc.type] = true;
				npc.catchItem = (short)mod.ItemType("JewelerHorcrux");
			}
			if (npc.type == mod.NPCType("Operator"))
			{
				Main.npcCatchable[npc.type] = true;
				npc.catchItem = (short)mod.ItemType("APMC");
			}
			if (npc.type == mod.NPCType("OtherworldlyPortal"))
			{
				Main.npcCatchable[npc.type] = true;
				npc.catchItem = (short)mod.ItemType("NotesBook");
			}
			if (npc.type == mod.NPCType("Explorer"))
			{
				Main.npcCatchable[npc.type] = true;
				npc.catchItem = (short)mod.ItemType("RealityPiercer");
			}
		}

		public override void TownNPCAttackStrength(NPC npc, ref int damage, ref float knockback)
		{
			if (npc.type == NPCID.Steampunker || npc.type == NPCID.Wizard || npc.type == NPCID.Guide || npc.type == NPCID.Nurse || npc.type == NPCID.Demolitionist || npc.type == NPCID.Merchant || npc.type == NPCID.DyeTrader || npc.type == NPCID.Dryad || npc.type == NPCID.DD2Bartender || npc.type == NPCID.ArmsDealer || npc.type == NPCID.Stylist || npc.type == NPCID.Painter || npc.type == NPCID.Angler || npc.type == NPCID.GoblinTinkerer || npc.type == NPCID.WitchDoctor || npc.type == NPCID.Clothier || npc.type == NPCID.Mechanic || npc.type == NPCID.PartyGirl || npc.type == NPCID.TaxCollector || npc.type == NPCID.Truffle || npc.type == NPCID.Pirate || npc.type == NPCID.Cyborg || npc.type == NPCID.SantaClaus)
			{
				if (Main.hardMode && !NPC.downedMoonlord)
				{
					damage += 20;
				}
				if (NPC.downedMoonlord)
				{
					damage = 100;
				}
			}
		}

		public override void TownNPCAttackCooldown(NPC npc, ref int cooldown, ref int randExtraCooldown)
		{
			if (npc.type == NPCID.Steampunker)
			{
				if (NPC.downedMoonlord)
				{
					cooldown = 4;
					randExtraCooldown = 4;
				}
			}
			if (npc.type == NPCID.Steampunker)
			{
				if (NPC.downedMoonlord)
				{
					cooldown = 3;
					randExtraCooldown = 3;
				}
			}
			if (npc.type == NPCID.Guide)
			{
				if (NPC.downedMoonlord)
				{
					cooldown = 3;
				}
			}
		}

		public override void TownNPCAttackProj(NPC npc, ref int projType, ref int attackDelay)
		{
			if (npc.type == NPCID.ArmsDealer)
			{
				if (NPC.downedMoonlord)
				{
					attackDelay = 4;
					projType = ProjectileID.MoonlordBullet;
				}
			}
			if (npc.type == NPCID.Steampunker)
			{
				if (NPC.downedMoonlord)
				{
					attackDelay = 3;
					projType = ProjectileID.MoonlordBullet;
				}
			}
			if (npc.type == NPCID.Cyborg)
			{
				if (NPC.downedMoonlord)
				{
					attackDelay = 3;
					projType = ProjectileID.RocketSnowmanI;
				}
			}
			if (npc.type == NPCID.Wizard)
			{
				if (NPC.downedMoonlord)
				{
					projType = ProjectileID.CursedFlameFriendly;
				}
			}
			if (npc.type == NPCID.Guide)
			{
				if (NPC.downedMoonlord)
				{
					projType = ProjectileID.MoonlordArrow;
				}
			}
		}

		public override void DrawTownAttackGun(NPC npc, ref float scale, ref int item, ref int closeness)
		{
			if (npc.type == NPCID.ArmsDealer)
			{
				if (NPC.downedMoonlord)
				{
					item = ItemID.Megashark;
				}
			}
			if (npc.type == NPCID.Steampunker)
			{
				if (NPC.downedMoonlord)
				{
					scale = 1f;
					closeness = 4;
					item = ItemID.SDMG;
				}
			}
		}

		public override void BuffTownNPC(ref float damageMult, ref int defense)
		{
			if (Main.hardMode && !NPC.downedMoonlord)
			{
				defense += 30;
			}
			if (NPC.downedMoonlord)
			{
				defense += 80;
			}
		}

		public override void ResetEffects(NPC npc)
		{
			corrosion = false;
			rainbowdust = false;
			electrocute = false;
			twilight = false;
			justitiapale = false;
			N1 = false;
			N2 = false;
			N3 = false;
			N4 = false;
			N5 = false;
			N6 = false;
			N7 = false;
			N8 = false;
			N9 = false;
		}

		public override void UpdateLifeRegen(NPC npc, ref int damage)
		{
			if (corrosion)
			{
				npc.lifeRegen -= 1000;
				if (damage < 99)
				{
					damage = 100;
				}
			}
			if (justitiapale)
			{
				npc.lifeRegen -= 2000;
				if (damage < 199)
				{
					damage = 200;
				}
			}
			if (electrocute)
			{
				npc.lifeRegen -= 1500;
				if (damage < 149)
				{
					damage = 150;
				}
			}
			if (twilight)
			{
				npc.lifeRegen -= 5000;
				if (damage < 499)
				{
					damage = 500;
				}
			}
		}

		public override void DrawEffects(NPC npc, ref Color drawColor)
		{
			if (corrosion)
			{
				if (Main.rand.Next(4) < 3)
				{
					int dust = Dust.NewDust(npc.position - new Vector2(2f, 2f), npc.width + 4, npc.height + 4, mod.DustType("RainbowDust"), npc.velocity.X * 0.4f, npc.velocity.Y * 0.4f, 100, default(Color), 3.5f);
					Main.dust[dust].noGravity = true;
					Main.dust[dust].velocity *= 1.8f;
					Main.dust[dust].velocity.Y -= 0.5f;
					if (Main.rand.Next(4) == 0)
					{
						Main.dust[dust].noGravity = false;
						Main.dust[dust].scale *= 0.5f;
					}
				}
				Lighting.AddLight(npc.position, 1f, 1f, 1f);
			}
			if (npc.FindBuffIndex(mod.BuffType("ArmorDestruction")) >= 0)
			{
				if (Main.rand.Next(4) < 3)
				{
					int dust = Dust.NewDust(npc.position - new Vector2(2f, 2f), npc.width + 4, npc.height + 4, mod.DustType("BastScroll"), npc.velocity.X * 0.4f, npc.velocity.Y * 0.4f, 100, default(Color), 3.5f);
					Main.dust[dust].noGravity = true;
					Main.dust[dust].velocity *= 1.8f;
					Main.dust[dust].velocity.Y -= 0.5f;
					if (Main.rand.Next(4) == 0)
					{
						Main.dust[dust].noGravity = false;
						Main.dust[dust].scale *= 0.5f;
					}
				}
				Lighting.AddLight(npc.position, 1f, 1f, 1f);
			}
			if (npc.FindBuffIndex(mod.BuffType("CurseOfLight")) >= 0)
			{
				npc.color = new Color(255, 255, 255, 100);
				Lighting.AddLight(npc.position, 1f, 1f, 1f);
			}
			if (npc.FindBuffIndex(mod.BuffType("SymbolOfPain")) >= 0)
			{
				npc.color = new Color(255, 10, 10, 100);
				Lighting.AddLight(npc.position, 1f, 1f, 1f);
			}
			if (justitiapale)
			{
				if (Main.rand.Next(4) < 3)
				{
					int dust = Dust.NewDust(npc.position - new Vector2(2f, 2f), npc.width + 4, npc.height + 4, mod.DustType("JustitiaPale"), npc.velocity.X * 0.4f, npc.velocity.Y * 0.4f, 100, default(Color), 3.5f);
					Main.dust[dust].noGravity = true;
					Main.dust[dust].velocity *= 1.8f;
					Main.dust[dust].velocity.Y -= 0.5f;
					if (Main.rand.Next(4) == 0)
					{
						Main.dust[dust].noGravity = false;
						Main.dust[dust].scale *= 0.5f;
					}
				}
			}
			if (electrocute)
			{
				if (Main.rand.Next(4) < 3)
				{
					int dust = Dust.NewDust(npc.position - new Vector2(2f, 2f), npc.width + 4, npc.height + 4, mod.DustType("Electrocute"), npc.velocity.X * 0.4f, npc.velocity.Y * 0.4f, 100, default(Color), 3.5f);
					Main.dust[dust].noGravity = true;
					Main.dust[dust].velocity *= 1.8f;
					Main.dust[dust].velocity.Y -= 0.5f;
					if (Main.rand.Next(8) == 0)
					{
						Main.dust[dust].noGravity = true;
						Main.dust[dust].scale *= 0.8f;
					}
				}
			}
			if (twilight)
			{
				if (Main.rand.Next(4) < 3)
				{
					int dust = Dust.NewDust(npc.position - new Vector2(2f, 2f), npc.width + 4, npc.height + 4, mod.DustType("JustitiaPale"), npc.velocity.X * 0.4f, npc.velocity.Y * 0.4f, 100, default(Color), 3.5f);
					Main.dust[dust].noGravity = true;
					Main.dust[dust].velocity *= 1.8f;
					Main.dust[dust].velocity.Y -= 0.5f;
					if (Main.rand.Next(4) == 0)
					{
						Main.dust[dust].noGravity = false;
						Main.dust[dust].scale *= 0.5f;
					}
				}
			}
		}
		
		public override bool PreNPCLoot(NPC npc)
		{
			string barrierWeek = Language.GetTextValue("Mods.AlchemistNPC.barrierWeek");
			string Eclipse = Language.GetTextValue("Mods.AlchemistNPC.Eclipse");
			if (npc.type == NPCID.MoonLordCore)
			{
				if (!NPC.downedMoonlord)
				{
					Main.NewText(barrierWeek, 255, 255, 255);
					Main.NewText(Eclipse, 255, 50, 50);
				}
			}
			if (npc.type == NPCID.EyeofCthulhu)
			{
				if (!NPC.downedBoss1)
				{
					if (Main.netMode == 0)
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("AlchemistCharmTier1"));
					}
					if (Main.netMode == 1)
					{
						for (int i = 0; i < 200; i++)
						{
							if (Main.player[i].active)
							{
								Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("AlchemistCharmTier1"));
							}
						}

					}
				}
			}
			if (Main.expertMode && Config.CoinsDrop)
			{
				if (ModLoader.GetLoadedMods().Contains("SpiritMod"))
				{
					if (npc.type == (ModLoader.GetMod("SpiritMod").NPCType("Infernon")))
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ReversivityCoinTier2"), Main.rand.Next(6, 9));
					}
				}
				if (npc.type == NPCID.DD2DarkMageT1 || npc.type == NPCID.DD2DarkMageT3)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ReversivityCoinTier1"), Main.rand.Next(12, 15));
				}
				if (npc.type == NPCID.DD2OgreT2 || npc.type == NPCID.DD2OgreT3)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ReversivityCoinTier3"), Main.rand.Next(3, 6));
				}
				if (npc.type == NPCID.DD2Betsy)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ReversivityCoinTier4"), Main.rand.Next(3, 6));
				}
			}
			return true;
		}

		public override void NPCLoot(NPC npc)
		{
			if (npc.lifeMax >= 75000 && npc.boss && NPC.downedMoonlord && Main.rand.Next(20) == 0)
				{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("WailOfBanshee"));
				}
			if (npc.lifeMax >= 75000 && npc.boss && NPC.downedMoonlord && Main.rand.Next(20) == 0)
				{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ExecutionersEyes"));
				}
			if (npc.lifeMax >= 75000 && npc.boss && NPC.downedMoonlord && Main.rand.Next(20) == 0)
				{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("SymbolOfPain"));
				}
			if (npc.lifeMax >= 75000 && npc.boss && NPC.downedMoonlord && Main.rand.Next(20) == 0)
				{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("MeteorSwarm"));
				}
			if (npc.lifeMax >= 75000 && npc.boss && NPC.downedMoonlord && Main.rand.Next(20) == 0)
				{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("CloakOfFear"));
				}
			if (npc.type == NPCID.WallofFlesh)
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("LuckCharm"));
			}
			if (ModLoader.GetLoadedMods().Contains("CalamityMod"))
			{
				if (Main.player[(int)Player.FindClosest(npc.position, npc.width, npc.height)].HasBuff(mod.BuffType("CalamityComb")) && npc.type == (ModLoader.GetMod("CalamityMod").NPCType("DevourerofGodsHeadS")) && CalamityModRevengeance)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModLoader.GetMod("CalamityMod").ItemType("Fabsol"));
				}
			}
			if (Main.rand.Next(15000) == 0)
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("HolyAvenger"), 1, false, 81);
			}
			if (Main.player[(int)Player.FindClosest(npc.position, npc.width, npc.height)].GetModPlayer<AlchemistNPCPlayer>(mod).Extractor && npc.boss == true && npc.lifeMax >= 50000 && (Main.rand.Next(3) == 0))
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("SoulEssence"));
			}
			if (Main.player[(int)Player.FindClosest(npc.position, npc.width, npc.height)].GetModPlayer<AlchemistNPCPlayer>(mod).Extractor && npc.boss == true && npc.lifeMax >= 55000 && (Main.rand.Next(10) == 0))
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("HateVial"));
			}
			if (npc.type == NPCID.MoonLordCore && Main.player[(int)Player.FindClosest(npc.position, npc.width, npc.height)].GetModPlayer<AlchemistNPCPlayer>(mod).PGSWear)
			{
				if (Main.rand.Next(2) == 0)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("KnucklesUgandaDoll"));
				}
			}
			if (npc.type == mod.NPCType("Operator"))
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("APMC"));
			}
			if (npc.type == NPCID.DungeonGuardian)
			{
				if (!Main.expertMode)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("EmagledFragmentation"), Main.rand.Next(20, 30));
					if (Main.rand.Next(10) == 0)
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("OtherworldlyAmulet"));
					}
				}
				if (Main.expertMode)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("EmagledFragmentation"), Main.rand.Next(40, 50));
					if (Main.rand.Next(5) == 0)
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("OtherworldlyAmulet"));
					}
				}
			}
			if (npc.type == NPCID.EyeofCthulhu && Config.TornNotesDrop)
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("TornNote1"));
			}
			if (npc.type == NPCID.BrainofCthulhu && Config.TornNotesDrop)
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("TornNote2"));
			}
			if (npc.type == NPCID.EaterofWorldsHead && !NPC.AnyNPCs(NPCID.EaterofWorldsTail) && Config.TornNotesDrop)
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("TornNote2"));
			}
			if (npc.type == NPCID.EaterofWorldsTail && !NPC.AnyNPCs(NPCID.EaterofWorldsHead) && Config.TornNotesDrop)
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("TornNote2"));
			}
			if (npc.type == NPCID.SkeletronHead && Config.TornNotesDrop)
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("TornNote3"));
			}
			if (npc.type == NPCID.SkeletronPrime && Config.TornNotesDrop)
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("TornNote4"));
			}
			if (npc.type == NPCID.Spazmatism && !NPC.AnyNPCs(NPCID.Retinazer) && Config.TornNotesDrop)
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("TornNote5"));
			}
			if (npc.type == NPCID.Retinazer && !NPC.AnyNPCs(NPCID.Spazmatism) && Config.TornNotesDrop)
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("TornNote5"));
			}
			if (npc.type == NPCID.TheDestroyer && Config.TornNotesDrop)
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("TornNote6"));
			}
			if (npc.type == NPCID.Plantera && Config.TornNotesDrop)
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("TornNote7"));
			}
			if (npc.type == NPCID.Golem && Config.TornNotesDrop)
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("TornNote8"));
			}
			if (npc.type == NPCID.Golem)
			{
				if (Main.rand.Next(10) == 0)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Fuaran"));
				}
			}
			if (npc.type == NPCID.MoonLordCore && Config.TornNotesDrop)
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("TornNote9"));
			}
			if (Main.expertMode && Config.CoinsDrop)
			{
				if (npc.type == NPCID.KingSlime)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ReversivityCoinTier1"), Main.rand.Next(1, 3));
				}
				if (npc.type == NPCID.EyeofCthulhu)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ReversivityCoinTier1"), Main.rand.Next(3, 6));
				}
				if (npc.type == NPCID.BrainofCthulhu)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ReversivityCoinTier1"), Main.rand.Next(6, 9));
				}
				if (npc.type == NPCID.EaterofWorldsHead && !NPC.AnyNPCs(NPCID.EaterofWorldsTail))
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ReversivityCoinTier1"), Main.rand.Next(6, 9));
				}
				if (npc.type == NPCID.EaterofWorldsTail && !NPC.AnyNPCs(NPCID.EaterofWorldsHead))
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ReversivityCoinTier1"), Main.rand.Next(6, 9));
				}
				if (npc.type == NPCID.QueenBee)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ReversivityCoinTier1"), Main.rand.Next(9, 12));
				}
				if (npc.type == NPCID.SkeletronHead)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ReversivityCoinTier1"), Main.rand.Next(12, 15));
				}
				if (npc.type == NPCID.WallofFlesh)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ReversivityCoinTier2"), Main.rand.Next(1, 3));
				}
				if (npc.type == NPCID.SkeletronPrime)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ReversivityCoinTier3"), Main.rand.Next(1, 3));
				}
				if (npc.type == NPCID.Spazmatism && !NPC.AnyNPCs(NPCID.Retinazer))
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ReversivityCoinTier3"), Main.rand.Next(1, 3));
				}
				if (npc.type == NPCID.Retinazer && !NPC.AnyNPCs(NPCID.Spazmatism))
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ReversivityCoinTier3"), Main.rand.Next(1, 3));
				}
				if (npc.type == NPCID.TheDestroyer)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ReversivityCoinTier3"), Main.rand.Next(1, 3));
				}
				if (npc.type == NPCID.Plantera)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ReversivityCoinTier3"), Main.rand.Next(3, 6));
				}
				if (npc.type == NPCID.Golem)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ReversivityCoinTier4"), Main.rand.Next(1, 3));
				}
				if (npc.type == NPCID.DukeFishron)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ReversivityCoinTier4"), Main.rand.Next(3, 6));
				}
				if (npc.type == NPCID.CultistBoss)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ReversivityCoinTier4"), Main.rand.Next(3, 6));
				}
				if (npc.type == NPCID.MoonLordCore)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ReversivityCoinTier4"), Main.rand.Next(6, 9));
				}
				if (ModLoader.GetLoadedMods().Contains("CalamityMod"))
				{
					if (npc.type == (ModLoader.GetMod("CalamityMod").NPCType("DesertScourgeHead")))
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ReversivityCoinTier1"), Main.rand.Next(1, 3));
					}
					if (npc.type == (ModLoader.GetMod("CalamityMod").NPCType("CrabulonIdle")))
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ReversivityCoinTier1"), Main.rand.Next(3, 6));
					}
					if (npc.type == (ModLoader.GetMod("CalamityMod").NPCType("HiveMindP2")))
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ReversivityCoinTier1"), Main.rand.Next(6, 9));
					}
					if (npc.type == (ModLoader.GetMod("CalamityMod").NPCType("PerforatorHive")))
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ReversivityCoinTier1"), Main.rand.Next(6, 9));
					}
					if (npc.type == (ModLoader.GetMod("CalamityMod").NPCType("SlimeGodCore")))
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ReversivityCoinTier2"), Main.rand.Next(1, 3));
					}
					if (npc.type == (ModLoader.GetMod("CalamityMod").NPCType("Cryogen")))
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ReversivityCoinTier2"), Main.rand.Next(6, 9));
					}
					if (npc.type == (ModLoader.GetMod("CalamityMod").NPCType("BrimstoneElemental")))
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ReversivityCoinTier3"), Main.rand.Next(3, 6));
					}
					if (npc.type == (ModLoader.GetMod("CalamityMod").NPCType("AquaticScourgeHead")))
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ReversivityCoinTier3"), Main.rand.Next(3, 6));
					}
					if (npc.type == (ModLoader.GetMod("CalamityMod").NPCType("SoulSeeker")))
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ReversivityCoinTier3"), Main.rand.Next(1, 2));
					}
					if (npc.type == (ModLoader.GetMod("CalamityMod").NPCType("Leviathan")))
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ReversivityCoinTier3"), Main.rand.Next(6, 9));
					}
					if (npc.type == (ModLoader.GetMod("CalamityMod").NPCType("Astrageldon")))
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ReversivityCoinTier3"), Main.rand.Next(6, 9));
					}
					if (npc.type == (ModLoader.GetMod("CalamityMod").NPCType("PlaguebringerGoliath")))
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ReversivityCoinTier4"), Main.rand.Next(3, 6));
					}
					if (npc.type == (ModLoader.GetMod("CalamityMod").NPCType("ScavangerBody")))
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ReversivityCoinTier4"), Main.rand.Next(3, 6));
					}
					if (npc.type == (ModLoader.GetMod("CalamityMod").NPCType("ProfanedGuardianBoss")))
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ReversivityCoinTier4"), Main.rand.Next(3, 6));
					}
					if (npc.type == (ModLoader.GetMod("CalamityMod").NPCType("ProfanedGuardianBoss2")))
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ReversivityCoinTier4"), Main.rand.Next(3, 6));
					}
					if (npc.type == (ModLoader.GetMod("CalamityMod").NPCType("ProfanedGuardianBoss3")))
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ReversivityCoinTier5"), Main.rand.Next(3, 6));
					}
					if (npc.type == (ModLoader.GetMod("CalamityMod").NPCType("Providence")))
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ReversivityCoinTier5"), Main.rand.Next(9, 12));
					}
					if (npc.type == (ModLoader.GetMod("CalamityMod").NPCType("Polterghast")))
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ReversivityCoinTier6"), Main.rand.Next(1, 3));
					}
					if (npc.type == (ModLoader.GetMod("CalamityMod").NPCType("DevourerofGodsHeadS")))
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ReversivityCoinTier6"), Main.rand.Next(3, 6));
					}
					if (npc.type == (ModLoader.GetMod("CalamityMod").NPCType("Bumblefuck")))
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ReversivityCoinTier6"), Main.rand.Next(3, 6));
					}
					if (npc.type == (ModLoader.GetMod("CalamityMod").NPCType("Yharon")))
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ReversivityCoinTier6"), Main.rand.Next(12, 15));
					}
					if (npc.type == (ModLoader.GetMod("CalamityMod").NPCType("SupremeCalamitas")))
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ReversivityCoinTier6"), 66);
					}
				}
				if (ModLoader.GetLoadedMods().Contains("ThoriumMod"))
				{
					if (npc.type == (ModLoader.GetMod("ThoriumMod").NPCType("TheGrandThunderBirdv2")))
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ReversivityCoinTier1"), Main.rand.Next(1, 2));
					}
					if (npc.type == (ModLoader.GetMod("ThoriumMod").NPCType("QueenJelly")))
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ReversivityCoinTier1"), Main.rand.Next(3, 6));
					}
					if (npc.type == (ModLoader.GetMod("ThoriumMod").NPCType("Viscount")))
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ReversivityCoinTier1"), Main.rand.Next(5, 7));
					}
					if (npc.type == (ModLoader.GetMod("ThoriumMod").NPCType("GraniteEnergyStorm")))
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ReversivityCoinTier1"), Main.rand.Next(6, 9));
					}
					if (npc.type == (ModLoader.GetMod("ThoriumMod").NPCType("TheBuriedWarrior")))
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ReversivityCoinTier1"), Main.rand.Next(6, 9));
					}
					if (npc.type == (ModLoader.GetMod("ThoriumMod").NPCType("ThePrimeScouter")))
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ReversivityCoinTier1"), Main.rand.Next(6, 9));
					}
					if (npc.type == (ModLoader.GetMod("ThoriumMod").NPCType("BoreanStriderPopped")))
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ReversivityCoinTier2"), Main.rand.Next(1, 3));
					}
					if (npc.type == (ModLoader.GetMod("ThoriumMod").NPCType("FallenDeathBeholder2")))
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ReversivityCoinTier2"), Main.rand.Next(3, 6));
					}
					if (npc.type == (ModLoader.GetMod("ThoriumMod").NPCType("LichHeadless")))
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ReversivityCoinTier3"), Main.rand.Next(3, 6));
					}
					if (npc.type == (ModLoader.GetMod("ThoriumMod").NPCType("AbyssionReleased")))
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ReversivityCoinTier4"), Main.rand.Next(3, 6));
					}
					if (npc.type == (ModLoader.GetMod("ThoriumMod").NPCType("RealityBreaker")))
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ReversivityCoinTier4"), 33);
					}
				}
				if (ModLoader.GetLoadedMods().Contains("SacredTools"))
				{
					if (npc.type == (ModLoader.GetMod("SacredTools").NPCType("FlamePump2")))
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ReversivityCoinTier1"), Main.rand.Next(4, 6));
					}
					if (npc.type == (ModLoader.GetMod("SacredTools").NPCType("Jensen")))
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ReversivityCoinTier1"), Main.rand.Next(6, 9));
					}
					if (npc.type == (ModLoader.GetMod("SacredTools").NPCType("Raynare")))
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ReversivityCoinTier3"), Main.rand.Next(3, 6));
					}
					if (npc.type == (ModLoader.GetMod("SacredTools").NPCType("Abaddon")))
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ReversivityCoinTier4"), Main.rand.Next(3, 6));
					}
					if (npc.type == (ModLoader.GetMod("SacredTools").NPCType("AraghurHead")))
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ReversivityCoinTier4"), Main.rand.Next(6, 9));
					}
					if (npc.type == (ModLoader.GetMod("SacredTools").NPCType("NovaLunarian")))
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ReversivityCoinTier5"), Main.rand.Next(3, 6));
					}
					if (npc.type == (ModLoader.GetMod("SacredTools").NPCType("ChallengerBoss")))
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ReversivityCoinTier5"), Main.rand.Next(6, 9));
					}
				}
				if (ModLoader.GetLoadedMods().Contains("SpiritMod"))
				{
					if (npc.type == (ModLoader.GetMod("SpiritMod").NPCType("Scarabeus")))
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ReversivityCoinTier1"), Main.rand.Next(2, 3));
					}
					if (npc.type == (ModLoader.GetMod("SpiritMod").NPCType("ReachBoss")))
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ReversivityCoinTier1"), Main.rand.Next(6, 9));
					}
					if (npc.type == (ModLoader.GetMod("SpiritMod").NPCType("AncientFlyer")))
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ReversivityCoinTier1"), Main.rand.Next(9, 12));
					}
					if (npc.type == (ModLoader.GetMod("SpiritMod").NPCType("SteamRaiderHead")))
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ReversivityCoinTier2"), Main.rand.Next(3, 6));
					}
					if (npc.type == (ModLoader.GetMod("SpiritMod").NPCType("Dusking")))
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ReversivityCoinTier3"), Main.rand.Next(3, 6));
					}
					if (npc.type == (ModLoader.GetMod("SpiritMod").NPCType("SpiritCore")))
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ReversivityCoinTier3"), Main.rand.Next(3, 6));
					}
					if (npc.type == (ModLoader.GetMod("SpiritMod").NPCType("IlluminantMaster")))
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ReversivityCoinTier3"), Main.rand.Next(6, 9));
					}
					if (npc.type == (ModLoader.GetMod("SpiritMod").NPCType("Atlas")))
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ReversivityCoinTier4"), Main.rand.Next(6, 9));
					}
					if (npc.type == (ModLoader.GetMod("SpiritMod").NPCType("Overseer")))
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ReversivityCoinTier4"), 50);
					}
				}
				if (ModLoader.GetLoadedMods().Contains("Laugicality"))
				{
					if (npc.type == (ModLoader.GetMod("Laugicality").NPCType("DuneSharkron")))
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ReversivityCoinTier1"), Main.rand.Next(2, 3));
					}
					if (npc.type == (ModLoader.GetMod("Laugicality").NPCType("Hypothema")))
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ReversivityCoinTier1"), Main.rand.Next(6, 9));
					}
					if (npc.type == (ModLoader.GetMod("Laugicality").NPCType("Ragnar")))
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ReversivityCoinTier1"), Main.rand.Next(9, 12));
					}
					if (npc.type == (ModLoader.GetMod("Laugicality").NPCType("AnDio3")))
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ReversivityCoinTier2"), Main.rand.Next(4, 6));
					}
					if (npc.type == (ModLoader.GetMod("Laugicality").NPCType("Slybertron")))
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ReversivityCoinTier3"), Main.rand.Next(6, 9));
					}
					if (npc.type == (ModLoader.GetMod("Laugicality").NPCType("TheAnnihilator")))
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ReversivityCoinTier3"), Main.rand.Next(6, 9));
					}
					if (npc.type == (ModLoader.GetMod("Laugicality").NPCType("SteamTrain")))
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ReversivityCoinTier3"), Main.rand.Next(6, 9));
					}
					if (npc.type == (ModLoader.GetMod("Laugicality").NPCType("Etheria")))
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ReversivityCoinTier4"), 33);
					}
				}
			}
		}
		
		public bool CalamityModRevengeance
		{
        get { return CalamityMod.CalamityWorld.revenge; }
        }
		
		private readonly Mod Calamity = ModLoader.GetMod("CalamityMod");
		
		public override void AI(NPC npc)
		{
			Player player = Main.player[(int)Player.FindClosest(npc.position, npc.width, npc.height)];
			if (npc.type == mod.NPCType("Knuckles"))
			{
				if (!start)
				{
					npc.position.Y = player.position.Y - 300;
					npc.position.X = player.position.X;
					start = true;
				}
			}
			if (npc.type == mod.NPCType("BillCipher"))
			{
				if (npc.life == npc.lifeMax && !start && player.name != "Bill")
				{
					npc.position.Y = player.position.Y - 300;
					npc.position.X = player.position.X;
					if (player.name == "Dipper" || player.name == "Mabel" || player.name == "Stanford" || player.name == "Stanlee" || player.name == "Stan")
					{
						Main.NewText("WHAT? You again? I was already defeated with your help! What else do you want from me?", 10, 255, 10);	
					}
					else
					{
						Main.NewText("You dared summon me? This is going to be fun!", 10, 255, 10);	
					}
					start = true;
				}
				if (npc.life <= npc.lifeMax*0.6f && !i1)
				{
					Main.NewText("Hey, catch this!", 10, 255, 10);
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("VoodooDoll"));
					i1 = true;
				}
				if (npc.life <= npc.lifeMax*0.4f && !i2)
				{
					Main.NewText("Hey, catch this!", 10, 255, 10);
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ScreamingHead"));
					i2 = true;
				}
				if (npc.life <= npc.lifeMax*0.2f && !i3)
				{
					Main.NewText("Hey, catch this!", 10, 255, 10);
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("CursedMirror"));
					i3 = true;
				}
				if (npc.life <= (npc.lifeMax - npc.lifeMax/4) && !intermission1 && !stop1)
				{
					Main.NewText("Hey you! Yes, you! I am asking the one who is controlling this ''puppet''!", 30, 255, 30);
					Main.NewText("Do you really think that you would be able to defeat me? That's hilarious!", 30, 255, 30);
					npc.dontTakeDamage = true;
					intermission1 = true;
				}
				if (intermission1 && !stop1)
				{
					npc.velocity.X = 0f;
					npc.velocity.Y = 0f;
					bc++;
					if (bc >= 300)
					{
						npc.life += 50000;
						npc.HealEffect(50000, true);
						npc.dontTakeDamage = false;
						stop1 = true;
						intermission1 = false;
					}
				}
				if (npc.life <= npc.lifeMax/2 && !phase2)
				{
					Main.NewText("Enough playing around, now you are gonna die!", 150, 100, 30);
					Main.NewText("Madness is unleashed!", 150, 100, 30);
					phase2 = true;
					for (int index1 = 0; index1 < 30; ++index1)
					{
					float X = npc.Center.X + Main.rand.Next(-2500, 2500);
					float Y = npc.Center.Y + Main.rand.Next(-2500, 2500);
					Projectile.NewProjectile(X, Y, 0f, 0f, mod.ProjectileType("Madness"), 200, 0, Main.myPlayer);
					}
				}
				if (npc.life <= npc.lifeMax/4 && !intermission2 && !stop2)
				{
					Main.NewText("You are starting to annoy me, worm!", 210, 50, 20);
					Main.NewText("Don't start thinking you're safe behind that screen...", 210, 50, 20);
					Main.NewText("I will come to your dreams and will turn them into the horrible nightmare!", 210, 50, 10);
					npc.dontTakeDamage = true;
					intermission2 = true;
				}
				if (intermission2 && !stop2)
				{
					npc.velocity.X = 0f;
					npc.velocity.Y = 0f;
					bc2++;
					if (bc2 >= 300)
					{
						npc.life += 50000;
						npc.HealEffect(50000, true);
						npc.dontTakeDamage = false;
						stop2 = true;
						intermission2 = false;
					}
				}
				if (npc.life <= npc.lifeMax*0.15f && !phase3)
				{
					Main.NewText("I will not get defeated again!", 255, 0, 0);
					Main.NewText("Prepare to suffer!", 255, 0, 0);
					phase3 = true;
				}
			}
		}
	}
}
