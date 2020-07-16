using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace QuodAstrum.NPCs
{
    public class HellsGuardian : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Hell's Guardian");
        }
        public override void SetDefaults()
        {
            npc.width = 200;
            npc.height = 200;
            npc.damage = 999999;
            npc.defense = 30;
            npc.lifeMax = 500000000;
            npc.HitSound = SoundID.NPCHit21;
            npc.DeathSound = SoundID.NPCDeath51;
            npc.value = 10f;
            npc.aiStyle = 11;
            aiType = NPCID.DungeonGuardian;
            npc.knockBackResist = 0.1f;
            npc.lavaImmune = true;
            npc.noGravity = true;
            npc.noTileCollide = true;
        }
        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return spawnInfo.player.ZoneUnderworldHeight && !AstrumWorld.downedSkele ? 100f : 0f;

        }

    }
}