using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace QuodAstrum.Items.Materials
{
    public class TerrumsCore : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Terrum's Core");
            Tooltip.SetDefault("The Core of the Earthen Guardian");
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