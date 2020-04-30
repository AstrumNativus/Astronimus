using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace QuodAstrum.Items
{
    public class AstralGel : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Astral Gel");
            Tooltip.SetDefault("The essence of heavenly slimes");
        }
        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 999;
            item.value = 0;
            item.rare = ItemRarityID.Expert;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("AstralGel"), 5);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.FallenStar);
            recipe.AddRecipe();
        }
    }
}