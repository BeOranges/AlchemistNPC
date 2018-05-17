using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;
 
namespace AlchemistNPC.NPCs
{
	[AutoloadHead]
	public class Explorer : ModNPC
	{
		public static bool C11 = false;
		public static bool C12 = false;
		public static bool C13 = false;
		public static bool C14 = false;
		public static bool C15 = false;
		public static bool C21 = false;
		public static bool C22 = false;
		public static bool C23 = false;
		public static bool C24 = false;
		public static bool C25 = false;
		public static bool C26 = false;
		public static bool C31 = false;
		public static bool C32 = false;
		public static bool C33 = false;
		public static bool C34 = false;
		public static bool C35 = false;
		public static bool C41 = false;
		public static bool C42 = false;
		public static bool C43 = false;
		public static bool C44 = false;
		public static bool C45 = false;
		public static bool C51 = false;
		public static bool C52 = false;
		public static bool C53 = false;
		public static bool C54 = false;
		public static bool C55 = false;
		
		public override string Texture
		{
			get
			{
				return "AlchemistNPC/NPCs/Explorer";
			}
		}

		public override void ResetEffects()
		{
		C11 = false;
		C12 = false;
		C13 = false;
		C14 = false;
		C15 = false;
		C21 = false;
		C22 = false;
		C23 = false;
		C24 = false;
		C25 = false;
		C26 = false;
		C31 = false;
		C32 = false;
		C33 = false;
		C34 = false;
		C35 = false;
		C41 = false;
		C42 = false;
		C43 = false;
		C44 = false;
		C45 = false;
		C51 = false;
		C52 = false;
		C53 = false;
		C54 = false;
		C55 = false;
		}
		
		public override bool Autoload(ref string name)
		{
			name = "Explorer";
			return mod.Properties.Autoload;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Explorer");
			DisplayName.AddTranslation(GameCulture.Russian, "Исследовательница");
            Main.npcFrameCount[npc.type] = 23;   
			NPCID.Sets.AttackFrameCount[npc.type] = 4;
			NPCID.Sets.DangerDetectRange[npc.type] = 500;
			NPCID.Sets.AttackType[npc.type] = 1;
			NPCID.Sets.AttackTime[npc.type] = 20;
			NPCID.Sets.AttackAverageChance[npc.type] = 30;
			NPCID.Sets.HatOffsetY[npc.type] = -4;
		
		ModTranslation text = mod.CreateTranslation("Elizabeth");
		text.SetDefault("Elizabeth");
		text.AddTranslation(GameCulture.Russian, "Элизавета");
		mod.AddTranslation(text);
		text = mod.CreateTranslation("Dora");
		text.SetDefault("Dora");
		text.AddTranslation(GameCulture.Russian, "Даша");
		mod.AddTranslation(text);
		text = mod.CreateTranslation("Create1");
		text.SetDefault("Create #1");
		text.AddTranslation(GameCulture.Russian, "Создать №1");
		mod.AddTranslation(text);
		text = mod.CreateTranslation("Create2");
		text.SetDefault("Create #2");
		text.AddTranslation(GameCulture.Russian, "Создать №2");
		mod.AddTranslation(text);
		text = mod.CreateTranslation("Create3");
		text.SetDefault("Create #3");
		text.AddTranslation(GameCulture.Russian, "Создать №3");
		mod.AddTranslation(text);
		text = mod.CreateTranslation("Create4");
		text.SetDefault("Create #4");
		text.AddTranslation(GameCulture.Russian, "Создать №4");
		mod.AddTranslation(text);
		text = mod.CreateTranslation("Create5");
		text.SetDefault("Create #5");
		text.AddTranslation(GameCulture.Russian, "Создать №5");
		mod.AddTranslation(text);
		text = mod.CreateTranslation("EntryE1");
		text.SetDefault("So, were my notes any useful for you?");
		text.AddTranslation(GameCulture.Russian, "Так, мои записки были хоть сколько-нибудь полезны для тебя?");
		mod.AddTranslation(text);
		text = mod.CreateTranslation("EntryE2");
		text.SetDefault("I have some knowledge about special materials, which can help you.");
		text.AddTranslation(GameCulture.Russian, "Я владею некоторыми знаниями об особых материалах, которые могут помочь тебе.");
		mod.AddTranslation(text);
		text = mod.CreateTranslation("EntryE3");
		text.SetDefault("You want to try Blade with power of Determination? Just make Extractor and get some Soul Essences and Hate Vials.");
		text.AddTranslation(GameCulture.Russian, "Ты хочешь попробовать Меч с сидой Решимости? Просто сделай Экстрактов и добудь немного Эссенций Душ и Пробирок с Ненавистью.");
		mod.AddTranslation(text);
		text = mod.CreateTranslation("EntryE4");
		text.SetDefault("''There's a legendary yoyo known as the Sasscade.''... I am pretty sure you heard about that before. But I know, how you can gather it.");
		text.AddTranslation(GameCulture.Russian, "''Существует Легендарное Йо-йо, известное как Сасскад.''... Я уверена, что ты слышал об этом раньше. Но я знаю, как ты можешь заполучить его.");
		mod.AddTranslation(text);
		text = mod.CreateTranslation("EntryE5");
		text.SetDefault("If you want to take part in my researches, then grab my notes and check if you can help. All results will belong to you.");
		text.AddTranslation(GameCulture.Russian, "Если хочешь принять участие в моих исследованиях, тогда возьми мои записи и посмотри, если сможешь мне помочь. Все результаты достанутся тебе.");
		mod.AddTranslation(text);
		text = mod.CreateTranslation("EntryE6");
		text.SetDefault("Lucklly, I get my Interdimensional Casket with me, so I can make potions, which were invented by me.");
		text.AddTranslation(GameCulture.Russian, "Хорошо, что я забрала Межизмеренческую Шкатулку с собой, так что я могу делать изобретённые мной зелья.");
		mod.AddTranslation(text);
		text = mod.CreateTranslation("EntryE7");
		text.SetDefault("Emagled Fragmentations are pretty interesting... You can use them for crafting some special accessories and equipment or just can make Celestial Fragments.");
		text.AddTranslation(GameCulture.Russian, "Небесные обломки довольно интересны... Ты можешь использовать их для крафта специальных аксессуаров и снаряжения или всего лишь для изготовления Небесных Фрагментов.");
		mod.AddTranslation(text);
		text = mod.CreateTranslation("EntryE8");
		text.SetDefault("If you already found Otherworldly Amulet, then you can make ");
		text.AddTranslation(GameCulture.Russian, "Если ты уже нашёл Амулет Иного Мира, то тогда сможешь сделать так, чтобы ");
		mod.AddTranslation(text);
		text = mod.CreateTranslation("EntryE9");
		text.SetDefault(" to sell Celestial Fragments.");
		text.AddTranslation(GameCulture.Russian, "продавала Небесные Фрагменты.");
		mod.AddTranslation(text);
		}

		public override void SetDefaults()
		{
			npc.townNPC = true;
            npc.friendly = true;
            npc.width = 18;
            npc.height = 40;
            npc.aiStyle = 7;
            npc.damage = 10;
            npc.defense = 500;
            npc.lifeMax = 500;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
            npc.knockBackResist = 0.5f;
			animationType = NPCID.Mechanic;
		}
		
		public override bool CanTownNPCSpawn(int numTownNPCs, int money)
		{
			return false;
		}
 
 
        public override string TownNPCName()
        {
            string Elizabeth = Language.GetTextValue("Mods.AlchemistNPC.Elizabeth");
			string Dora = Language.GetTextValue("Mods.AlchemistNPC.Dora");
			switch (WorldGen.genRand.Next(1))
            {
                case 0:
                    return Elizabeth;
                default:
                    return Dora;
            }
        }
 
		public override void TownNPCAttackStrength(ref int damage, ref float knockback)
		{
			damage = 100;
			knockback = 16f;
		}

		public override void TownNPCAttackCooldown(ref int cooldown, ref int randExtraCooldown)
		{
			cooldown = 15;
			randExtraCooldown = 5;
		}

		public override void TownNPCAttackProj(ref int projType, ref int attackDelay)
		{
			projType = mod.ProjectileType("Nyx");
			attackDelay = 5;
		}

		public override void TownNPCAttackProjSpeed(ref float multiplier, ref float gravityCorrection, ref float randomOffset)
		{
			multiplier = 32f;
		}
 
		public override void DrawTownAttackGun(ref float scale, ref int item, ref int closeness) //Allows you to customize how this town NPC's weapon is drawn when this NPC is shooting (this NPC must have an attack type of 1). Scale is a multiplier for the item's drawing size, item is the ID of the item to be drawn, and closeness is how close the item should be drawn to the NPC.
		{
			scale = 1f;
			closeness = 15;
			item = mod.ItemType("Nyx");
		}
 
 
        public override string GetChat()
        {                                           //npc chat
        string Entry1 = Language.GetTextValue("Mods.AlchemistNPC.EntryE1");
		string Entry2 = Language.GetTextValue("Mods.AlchemistNPC.EntryE2");
		string Entry3 = Language.GetTextValue("Mods.AlchemistNPC.EntryE3");
		string Entry4 = Language.GetTextValue("Mods.AlchemistNPC.EntryE4");
		string Entry5 = Language.GetTextValue("Mods.AlchemistNPC.EntryE5");
		string Entry6 = Language.GetTextValue("Mods.AlchemistNPC.EntryE6");
		string Entry7 = Language.GetTextValue("Mods.AlchemistNPC.EntryE7");
		string Entry8 = Language.GetTextValue("Mods.AlchemistNPC.EntryE8");
		string Entry9 = Language.GetTextValue("Mods.AlchemistNPC.EntryE9");
		int Operator = NPC.FindFirstNPC(mod.NPCType("Operator"));
			if (Operator >= 0 && Main.rand.Next(4) == 0)
			{
				return Entry8 + Main.npc[Operator].GivenName + Entry9;
			}
            switch (Main.rand.Next(7))
            {
                case 0:                                     
				return Entry1;
                case 1:
				return Entry2;
                case 2:                                                      
				return Entry3;
                case 3:
				return Entry4;
                case 4:                                     
				return Entry5;
                case 5:
				return Entry6;
                default:
				return Entry7;
            }
        }
 
        public override void SetChatButtons(ref string button, ref string button2)
        {
			string Create1 = Language.GetTextValue("Mods.AlchemistNPC.Create1");
			string Create2 = Language.GetTextValue("Mods.AlchemistNPC.Create2");
			string Create3 = Language.GetTextValue("Mods.AlchemistNPC.Create3");
			string Create4 = Language.GetTextValue("Mods.AlchemistNPC.Create4");
			string Create5 = Language.GetTextValue("Mods.AlchemistNPC.Create5");
            button = Language.GetTextValue("LegacyInterface.28");
			for (int k = 0; k < 255; k++)
			{
				Player player = Main.player[k];
				if (player.active)
				{
					for (int j = 0; j < player.inventory.Length; j++)
					{
						if (player.inventory[j].type == 3389)
						{
							C11 = true;
						}
						if (player.inventory[j].type == mod.ItemType("AlchemicalBundle"))
						{
							C12 = true;
						}
						if (player.inventory[j].type == 1326)
						{
							C13 = true;
						}
						if (player.inventory[j].type == 3366)
						{
							C14 = true;
						}
						if (player.inventory[j].type == mod.ItemType("ResearchNote1"))
						{
							C15 = true;
						}
						if (player.inventory[j].type == 495)
						{
							C21 = true;
						}
						if (player.inventory[j].type == 3541)
						{
							C22 = true;
						}
						if (player.inventory[j].type == 493)
						{
							C23 = true;
						}
						if (player.inventory[j].type == 1611)
						{
							C24 = true;
						}
						if (player.inventory[j].type == 2890)
						{
							C25 = true;
						}
						if (player.inventory[j].type == mod.ItemType("ResearchNote2"))
						{
							C26 = true;
						}
						if (player.inventory[j].type == 2882)
						{
							C31 = true;
						}
						if (player.inventory[j].type == 1295)
						{
							C32 = true;
						}
						if (player.inventory[j].type == mod.ItemType("AlchemicalBundle"))
						{
							C33 = true;
						}
						if (player.inventory[j].type == 1858)
						{
							C34 = true;
						}
						if (player.inventory[j].type == mod.ItemType("ResearchNote3"))
						{
							C35 = true;
						}
						if (player.inventory[j].type == mod.ItemType("AlchemicalBundle"))
						{
							C41 = true;
						}
						if (player.inventory[j].type == 1363)
						{
							C42 = true;
						}
						if (player.inventory[j].type == mod.ItemType("HateVial"))
						{
							C43 = true;
						}
						if (player.inventory[j].type == mod.ItemType("RainbowFlask"))
						{
							C44 = true;
						}
						if (player.inventory[j].type == mod.ItemType("ResearchNote4"))
						{
							C45 = true;
						}
						if (player.inventory[j].type == 1156)
						{
							C51 = true;
						}
						if (player.inventory[j].type == mod.ItemType("AlchemicalBundle"))
						{
							C52 = true;
						}
						if (player.inventory[j].type == mod.ItemType("RainbowFlask"))
						{
							C53 = true;
						}
						if (player.inventory[j].type == 900)
						{
							C54 = true;
						}
						if (player.inventory[j].type == mod.ItemType("ResearchNote5"))
						{
							C55 = true;
						}
					}
				}
			}
			if (C11 && C12 && C13 && C14 && C15)
			{
			button2 = Create1;
			}
			if (C21 && C22 && C23 && C24 && C25 && C26)
			{
			button2 = Create2;
			}
			if (C31 && C32 && C33 && C34 && C35)
			{
			button2 = Create3;
			}
			if (C41 && C42 && C43 && C44 && C45)
			{
			button2 = Create4;
			}
			if (C51 && C52 && C53 && C54 && C55)
			{
			button2 = Create5;
			}
        }
 
        public override void OnChatButtonClicked(bool firstButton, ref bool shop)
        {
            if (firstButton)
            {
                shop = true;
            }
		else
		{
			if (C11 && C12 && C13 && C14 && C15)
				{
					Player player = Main.player[Main.myPlayer];
					player.QuickSpawnItem(mod.ItemType("Sasscade"));
					shop = false;
					if (Main.player[Main.myPlayer].HasItem(3389))
					{
						Item[] inventory = Main.player[Main.myPlayer].inventory;
						for (int k = 0; k < inventory.Length; k++)
						{
							if (inventory[k].type == 3389)
							{
								inventory[k].stack--;
							}
							if (inventory[k].type == mod.ItemType("AlchemicalBundle"))
							{
								inventory[k].stack--;
							}
							if (inventory[k].type == 1326)
							{
								inventory[k].stack--;
							}
							if (inventory[k].type == 3366)
							{
								inventory[k].stack--;
							}
							if (inventory[k].type == mod.ItemType("ResearchNote1"))
							{
								inventory[k].stack--;
							}
						}
					}
				}
			if (C21 && C22 && C23 && C24 && C25 && C26)
				{
					Player player = Main.player[Main.myPlayer];
					player.QuickSpawnItem(mod.ItemType("MagicWand"));
					shop = false;
					if (Main.player[Main.myPlayer].HasItem(495))
					{
						Item[] inventory = Main.player[Main.myPlayer].inventory;
						for (int k = 0; k < inventory.Length; k++)
						{
							if (inventory[k].type == 495)
							{
								inventory[k].stack--;
							}
							if (inventory[k].type == 3541)
							{
								inventory[k].stack--;
							}
							if (inventory[k].type == 493)
							{
								inventory[k].stack--;
							}
							if (inventory[k].type == 1611)
							{
								inventory[k].stack--;
							}
							if (inventory[k].type == 2890)
							{
								inventory[k].stack--;
							}
							if (inventory[k].type == mod.ItemType("ResearchNote2"))
							{
								inventory[k].stack--;
							}
						}
					}
				}
				if (C31 && C32 && C33 && C34 && C35)
				{
					Player player = Main.player[Main.myPlayer];
					player.QuickSpawnItem(mod.ItemType("QuantumDestabilizer"));
					shop = false;
					if (Main.player[Main.myPlayer].HasItem(2882))
					{
						Item[] inventory = Main.player[Main.myPlayer].inventory;
						for (int k = 0; k < inventory.Length; k++)
						{
							if (inventory[k].type == 2882)
							{
								inventory[k].stack--;
							}
							if (inventory[k].type == 1295)
							{
								inventory[k].stack--;
							}
							if (inventory[k].type == mod.ItemType("AlchemicalBundle"))
							{
								inventory[k].stack--;
							}
							if (inventory[k].type == 1858)
							{
								inventory[k].stack--;
							}
							if (inventory[k].type == mod.ItemType("ResearchNote3"))
							{
								inventory[k].stack--;
							}
						}
					}
				}
				if (C41 && C42 && C43 && C44 && C45)
				{
					Player player = Main.player[Main.myPlayer];
					player.QuickSpawnItem(mod.ItemType("EyeOfJudgement"));
					shop = false;
					if (Main.player[Main.myPlayer].HasItem(1363))
					{
						Item[] inventory = Main.player[Main.myPlayer].inventory;
						for (int k = 0; k < inventory.Length; k++)
						{
							if (inventory[k].type == mod.ItemType("AlchemicalBundle"))
							{
								inventory[k].stack--;
							}
							if (inventory[k].type == 1363)
							{
								inventory[k].stack--;
							}
							if (inventory[k].type == mod.ItemType("HateVial"))
							{
								inventory[k].stack--;
							}
							if (inventory[k].type == mod.ItemType("RainbowFlask"))
							{
								inventory[k].stack--;
							}
							if (inventory[k].type == mod.ItemType("ResearchNote4"))
							{
								inventory[k].stack--;
							}
						}
					}
				}
				if (C51 && C52 && C53 && C54 && C55)
				{
					Player player = Main.player[Main.myPlayer];
					player.QuickSpawnItem(mod.ItemType("PandoraPF422"));
					shop = false;
					if (Main.player[Main.myPlayer].HasItem(1156))
					{
						Item[] inventory = Main.player[Main.myPlayer].inventory;
						for (int k = 0; k < inventory.Length; k++)
						{
							if (inventory[k].type == 1156)
							{
								inventory[k].stack--;
							}
							if (inventory[k].type == mod.ItemType("RainbowFlask"))
							{
								inventory[k].stack--;
							}
							if (inventory[k].type == mod.ItemType("AlchemicalBundle"))
							{
								inventory[k].stack--;
							}
							if (inventory[k].type == 900)
							{
								inventory[k].stack--;
							}
							if (inventory[k].type == mod.ItemType("ResearchNote5"))
							{
								inventory[k].stack--;
							}
						}
					}
				}
			}
		}
 
        public override void SetupShop(Chest shop, ref int nextSlot)
        {
		shop.item[nextSlot].SetDefaults (ModLoader.GetMod("AlchemistNPC").ItemType("ExplorersBrew"));
		shop.item[nextSlot].shopCustomPrice = 250000;
        nextSlot++;
		shop.item[nextSlot].SetDefaults(ModLoader.GetMod("AlchemistNPC").ItemType("ChromaticCrystal"));
		shop.item[nextSlot].shopCustomPrice = 500000;
		nextSlot++;
		shop.item[nextSlot].SetDefaults(ModLoader.GetMod("AlchemistNPC").ItemType("NyctosythiaCrystal"));
		shop.item[nextSlot].shopCustomPrice = 500000;
		nextSlot++;	
		shop.item[nextSlot].SetDefaults(ModLoader.GetMod("AlchemistNPC").ItemType("SunkroveraCrystal"));
		shop.item[nextSlot].shopCustomPrice = 500000;
		nextSlot++;	
		shop.item[nextSlot].SetDefaults (ModLoader.GetMod("AlchemistNPC").ItemType("ResearchNote1"));
        nextSlot++;
		shop.item[nextSlot].SetDefaults (ModLoader.GetMod("AlchemistNPC").ItemType("ResearchNote2"));
        nextSlot++;
		shop.item[nextSlot].SetDefaults (ModLoader.GetMod("AlchemistNPC").ItemType("ResearchNote3"));
        nextSlot++;
		shop.item[nextSlot].SetDefaults (ModLoader.GetMod("AlchemistNPC").ItemType("ResearchNote4"));
        nextSlot++;
		shop.item[nextSlot].SetDefaults (ModLoader.GetMod("AlchemistNPC").ItemType("ResearchNote5"));
        nextSlot++;
		for (int k = 0; k < 255; k++)
				{
					Player player = Main.player[k];
					if (player.active)
					{
						for (int j = 0; j < player.inventory.Length; j++)
						{
							if (player.inventory[j].type == mod.ItemType("QuantumDestabilizer"))
							{
							shop.item[nextSlot].SetDefaults (ModLoader.GetMod("AlchemistNPC").ItemType("EnergyCell"));
							nextSlot++;
							}
						}
					}
				}
		}
	}
}
