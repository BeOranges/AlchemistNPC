using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace AlchemistNPC.Items.Placeable
{
    public class MolecularReplicator : ModItem
    {
		public override bool Autoload(ref string name)
		{
		return ModLoader.GetMod("AlchemistNPCContentDisabler") == null;
		}
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Molecular Replicator");
            Tooltip.SetDefault("Restores life of nearby friendly NPCs while placed");
            DisplayName.AddTranslation(GameCulture.Russian, "Молекулярный Репликатор");
            Tooltip.AddTranslation(GameCulture.Russian, "Восстанавливает жизни дружественных НПС когда установлен");
        }
        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 32;
            item.maxStack = 1;
            item.value = 1000000;
            item.rare = 7;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("MolecularReplicator");
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.MechanicalWheelPiece);
			recipe.AddIngredient(ItemID.MechanicalWagonPiece);
            recipe.AddIngredient(ItemID.MechanicalBatteryPiece);
            recipe.AddIngredient(ItemID.MartianConduitPlating, 50);
			recipe.AddIngredient(ItemID.Wire, 100);
            recipe.AddIngredient(ItemID.ShinyStone);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }
}
