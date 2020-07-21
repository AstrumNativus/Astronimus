using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace QuodAstrum.Items.Materials
{
    public class CygmaCrystal : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Cygma's Scales");
            Tooltip.SetDefault("The Scales torn from the Daughter");
        }
        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 999;
            item.value = 0;
            item.rare = ItemRarityID.Purple;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("CygmaCrystal"), 25);
            recipe.AddTile(TileID.DemonAltar);
            recipe.SetResult(mod.ItemType("StarlightCleaver"), 1);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("CygmaCrystal"), 25);
            recipe.AddTile(TileID.DemonAltar);
            recipe.SetResult(mod.ItemType("StarlightHellFire"), 1);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("CygmaCrystal"), 25);
            recipe.AddTile(TileID.DemonAltar);
            recipe.SetResult(mod.ItemType("StaffoftheStarlightEmissary"), 1);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("CygmaCrystal"), 25);
            recipe.AddTile(TileID.DemonAltar);
            recipe.SetResult(mod.ItemType("StarlightLyre"), 1);
            recipe.AddRecipe();
        }
    }
}