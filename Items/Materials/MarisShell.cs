using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace QuodAstrum.Items.Materials
{
    public class MarisShell : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Maris' Shell");
            Tooltip.SetDefault("The Water Baroness' magical Shell");
        }
        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 32;
            item.maxStack = 999;
            item.value = 0;
            item.rare = ItemRarityID.Expert;
        }
    }
}