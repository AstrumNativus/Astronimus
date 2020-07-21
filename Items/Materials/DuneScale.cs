using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace QuodAstrum.Items.Materials
{
    public class DuneScale : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dune Scale");
            Tooltip.SetDefault("Fossilized Scales of Sand");
        }
        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 24;
            item.maxStack = 999;
            item.value = 5;
            item.rare = ItemRarityID.Orange;
        }
    }
}