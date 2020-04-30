using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace QuodAstrum.Items
{
    public class NativusSand : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Nativus Sand");
            Tooltip.SetDefault("Sand beyond sand");
        }
        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 32;
            item.maxStack = 999;
            item.value = 0;
            item.rare = ItemRarityID.Expert;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("NativusSand"), 1);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(ItemID.SandstorminaBottle);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("NativusSand"), 1);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(ItemID.FlyingCarpet);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.SandBlock, 100);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(this);
            recipe.AddRecipe();

        }
    }
}