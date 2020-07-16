using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace QuodAstrum.NPCs
{
    public class HandOfVecna : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Hand Of Vecna");

        }
        public override void SetDefaults()
        {
            npc.aiStyle = 14;
            aiType = NPCID.CaveBat;
            npc.lifeMax = 3000;
            npc.damage = 25;
            npc.defense = 2;
            npc.knockBackResist = 0f;
            npc.width = 96;
            npc.height = 96;
            npc.value = Item.buyPrice(0, 0, 50, 0);
            Main.npcFrameCount[npc.type] = 4;
            npc.npcSlots = 0.5f;
            npc.boss = false;
            npc.lavaImmune = true;
            npc.noGravity = true;
            npc.noTileCollide = true;
            npc.HitSound = SoundID.NPCHit2;
            npc.buffImmune[BuffID.Confused] = true;
        }
       
        public override void ScaleExpertStats(int numPlayers, float bossLifeScale)
        {
            npc.lifeMax = (int)(npc.lifeMax * 0.625f * bossLifeScale);
            npc.damage = (int)(npc.damage * 0.6f);
        }
        public override void AI()
        {
            npc.ai[0]++;
            Player P = Main.player[npc.target];
            if (npc.target < 0 || npc.target == 255 || Main.player[npc.target].dead || !Main.player[npc.target].active)
            {
                npc.TargetClosest(true);
            }
            int frameHeight = 78;

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
            npc.netUpdate = true;
            if (npc.ai[1] >= 230)
            {
                
                NPC.NewNPC((int)npc.position.X, (int)npc.position.Y, NPCID.DarkCaster);
                NPC.NewNPC((int)npc.position.X, (int)npc.position.Y, NPCID.BoneThrowingSkeleton);
            }
            npc.ai[1] += 0;



        }
    }
}