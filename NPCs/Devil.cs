using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace QuodAstrum.NPCs
{
    public class Devil : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Devil");
            Main.npcFrameCount[npc.type] = 4;
        }
        public override void SetDefaults()
        {
            npc.width = 98;
            npc.height = 68;
            npc.damage = 50;
            npc.defense = 30;
            npc.lifeMax = 300;
            npc.HitSound = SoundID.NPCHit21;
            npc.DeathSound = SoundID.NPCDeath51;
            npc.value = 10f;
            npc.aiStyle = 2;
            npc.knockBackResist = 0.1f;
            npc.lavaImmune = true;
            npc.noGravity = true;
        }
        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return spawnInfo.player.ZoneUnderworldHeight && Main.dayTime && Main.hardMode ? 0.5f : 0f;

        }
        public override void NPCLoot()
        {
            if (Main.netMode != NetmodeID.MultiplayerClient && Main.rand.NextBool(10)){
                Item.NewItem(npc.getRect(), mod.ItemType("HornyDevil"));
            }
        }
        int frameHeight = 68;
        public override void AI()
        {
            Lighting.AddLight(npc.position, 0.75f, 0.75f, 0.75f);
            if (npc.frameCounter++ > 2)
            {
                npc.frameCounter = 0;
                npc.frame.Y = npc.frame.Y + frameHeight;
            }
            if (npc.frame.Y >= frameHeight * 4)
            {
                npc.frame.Y = 0;
                return;
            }
        }
    }
}