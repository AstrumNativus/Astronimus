using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace QuodAstrum.NPCs
{
    public class GalacticSlime : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Galactic Slime");
            Main.npcFrameCount[npc.type] = 2;
        }
        public override void SetDefaults()
        {
            npc.width = 33;
            npc.height = 33;
            npc.damage = 10;
            npc.defense = 5;
            npc.lifeMax = 100;
            npc.HitSound = SoundID.NPCHit30;
            npc.DeathSound = SoundID.NPCDeath6;
            npc.value = 10f;
            npc.aiStyle = 1;
            npc.knockBackResist = 0.1f;
            aiType = NPCID.BlueSlime;
            animationType = NPCID.BlueSlime;
        }
        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return spawnInfo.player.ZoneSkyHeight && Main.dayTime ? 50f : 0f;

        }
        public override void FindFrame(int frameHeight)
        {
            npc.frameCounter -= 0.5f;
            npc.frameCounter %= Main.npcFrameCount[npc.type];
            int frame = (int)npc.frameCounter;
            npc.frame.Y = frame * frameHeight;
            npc.spriteDirection = npc.direction;
        }
        public override void NPCLoot()
        {
            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.Gel);
            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.FallenStar);
            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("AstralGel"));
        }
        public override void AI()
        {
            Lighting.AddLight(npc.position, 0.75f, 0.75f, 0.75f);
        }
    }
}