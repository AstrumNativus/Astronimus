using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace QuodAstrum.Items
{
    public class HornyDevil : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Devil Horn");
            Tooltip.SetDefault("A horn obtained from killing a fiend");
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