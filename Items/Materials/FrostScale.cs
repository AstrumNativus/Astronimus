using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace QuodAstrum.Items.Materials
{
    public class FrostScale : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Frost Scale");
            Tooltip.SetDefault("Ancient Scales of Ice");
        }
        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 24;
            item.maxStack = 999;
            item.value = 5;
            item.rare = ItemRarityID.Cyan;
        }
    }
}