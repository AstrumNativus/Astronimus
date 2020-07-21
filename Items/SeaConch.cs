using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace QuodAstrum.Items
{
    public class SeaConch : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sea Conch");
            Tooltip.SetDefault("A conch created for the royalties of the ocean\nSummons the Water Baroness");
        }
        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 30;
            item.maxStack = 20;
            item.value = 0;
            item.rare = ItemRarityID.Expert;
            item.useAnimation = 30;
            item.UseSound = SoundID.Item21;
            item.useTime = 30;
            item.useStyle = 4;
            item.consumable = true;
        }
        public override bool CanUseItem(Player player)
        {
            return !NPC.AnyNPCs(mod.NPCType("Maris"));
        }
        public override bool UseItem(Player player)
        {
            NPC.SpawnOnPlayer(player.whoAmI, mod.NPCType("Maris"));

            return true;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Seashell, 10);
            recipe.AddIngredient(ItemID.Coral, 10);
            recipe.AddIngredient(ItemID.Glowstick, 10);
            recipe.AddIngredient(ItemID.Starfish, 10);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}