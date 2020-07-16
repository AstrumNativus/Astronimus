using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace QuodAstrum.Items
{
    public class AngelDust : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Angel Dust");
            Tooltip.SetDefault("Dust obtained by killing a celestial \n Warning: not suitable for consumption");
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
            recipe.AddIngredient(mod.ItemType("HornyDevil"), 5);
            recipe.AddIngredient(mod.ItemType("AngelDust"), 5);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(ItemID.FallenStar);
            recipe.AddRecipe();
        }
    }
}