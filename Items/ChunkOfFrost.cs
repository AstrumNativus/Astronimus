using Microsoft.Xna.Framework;
using System.IO;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace QuodAstrum.Items
{
    public class ChunkOfFrost : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Chunk Of Frost");
            Tooltip.SetDefault("An ancient piece of ice\nSummons the Frost Wyrm");
        }
        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 30;
            item.maxStack = 20;
            item.value = 0;
            item.rare = ItemRarityID.Cyan;
            item.useAnimation = 30;
            item.useTime = 30;
            item.useStyle = 4;
            item.UseSound = SoundID.Item30;
            item.consumable = true;
        }
        public override bool CanUseItem(Player player)
        {
            if (player.ZoneSnow)
            {
                return !NPC.AnyNPCs(mod.NPCType("FrostWyrmHead"));
            }
            return false;
        }
        public override bool UseItem(Player player)
        {
            NPC.SpawnOnPlayer(player.whoAmI, mod.NPCType("FrostWyrmHead"));
            Main.PlaySound(25, (int)player.position.X, (int)player.position.Y, 0);

            return true;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.IceBlock, 40);
            recipe.AddIngredient(ItemID.MeteoriteBar, 10);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}