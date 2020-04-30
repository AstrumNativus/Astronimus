using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace QuodAstrum.Items.NPCs
{
    public class EyeOfVecna : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Eye of Vecna");

        }
        public override void SetDefaults()
        {
            npc.aiStyle = 5;
            aiType = NPCID.EaterofSouls;
            npc.lifeMax = 3600;
            npc.damage = 30;
            npc.defense = 16;
            npc.knockBackResist = 0f;
            npc.width = 96;
            npc.height = 96;
            npc.value = Item.buyPrice(0, 0, 50, 0);
            animationType = NPCID.SkeletronHead;
            Main.npcFrameCount[npc.type] = 1;
            npc.npcSlots = 0.5f;
            npc.boss = false;
            npc.lavaImmune = true;
            npc.noGravity = true;
            npc.noTileCollide = true;
            npc.HitSound = SoundID.NPCHit1;
            npc.buffImmune[24] = false;
        }
       
        public override void ScaleExpertStats(int numPlayers, float bossLifeScale)
        {
            npc.lifeMax = (int)(npc.lifeMax * 0.625f * bossLifeScale);
            npc.damage = (int)(npc.damage * 0.6f);
            npc.defense = (int)(npc.defense * 0.5f);
        }
        public override void AI()
        {
            npc.ai[0]++;
            Player P = Main.player[npc.target];
            if (npc.target < 0 || npc.target == 255 || Main.player[npc.target].dead || !Main.player[npc.target].active)
            {
                npc.TargetClosest(true);
            }
            npc.netUpdate = true;
            
            if (npc.ai[0] % 600 == 3)
            {
                NPC.NewNPC((int)npc.position.X, (int)npc.position.Y, NPCID.DarkCaster);
                NPC.NewNPC((int)npc.position.X, (int)npc.position.Y, NPCID.BoneThrowingSkeleton);
            }
            npc.ai[1] += 0;
        }

    }
}