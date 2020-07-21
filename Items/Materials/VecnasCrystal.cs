using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace QuodAstrum.Items.Materials
{
    public class VecnasCrystal : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Vecna's Crystal");
            Tooltip.SetDefault("The crystal holding the Lich's Soul");
        }
        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 999;
            item.value = 0;
            item.rare = ItemRarityID.Expert;
        }
    }
}