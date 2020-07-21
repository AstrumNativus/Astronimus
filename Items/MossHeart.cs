using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace QuodAstrum.Items
{
    public class MossHeart : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Moss Heart");
            Tooltip.SetDefault("The heart of the Gardenmetal\nSummons Plantera");
        }
        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 30;
            item.maxStack = 20;
            item.value = 0;
            item.rare = ItemRarityID.Expert;
            item.useAnimation = 30;
            item.UseSound = SoundID.Item69;
            item.useTime = 30;
            item.useStyle = 4;
            item.consumable = true;
        }
        public override bool CanUseItem(Player player)
        {
            return !NPC.AnyNPCs(NPCID.Plantera);
        }
        public override bool UseItem(Player player)
        {
            NPC.SpawnOnPlayer(player.whoAmI, NPCID.Plantera);
            Main.PlaySound(15, (int)player.position.X, (int)player.position.Y, 0);
            return true;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.ChlorophyteBar, 10);
            recipe.AddIngredient(ItemID.SoulofFright, 10);
            recipe.AddIngredient(ItemID.SoulofSight, 10);
            recipe.AddIngredient(ItemID.SoulofMight, 10);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}