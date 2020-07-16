using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace QuodAstrum.Items
{
    public class CygmaStar : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Cygma Star");
            Tooltip.SetDefault("Are you ready?");
        }
        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 30;
            item.maxStack = 1;
            item.value = 0;
            item.rare = ItemRarityID.LightPurple;
            item.useAnimation = 30;
            item.useTime = 30;
            item.useStyle = 4;
            item.UseSound = SoundID.Item123;
            item.consumable = false;
        }
        public override bool CanUseItem(Player player)
        {
            if (AstrumWorld.downedEye && AstrumWorld.downedKS && AstrumWorld.downedEvil && AstrumWorld.downedQB && AstrumWorld.downedSkele)
            {
                return !NPC.AnyNPCs(mod.NPCType("CygmaH"));
                Main.NewText("Do you know what you're getting yourself into?", 123, 10, 168);
            }
            Main.NewText("Finish cleaning up, then we'll talk", 123, 10, 168);
            return false;
        }
        public override bool UseItem(Player player)
        {
            NPC.SpawnOnPlayer(player.whoAmI, mod.NPCType("CygmaH"));
            return true;
        }
    }
}