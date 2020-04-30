using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace QuodAstrum.Items.NPCs
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
            animationType = NPCID.SkeletronHead;
            Main.npcFrameCount[npc.type] = 1;
            npc.npcSlots = 0.5f;
            npc.boss = false;
            npc.lavaImmune = true;
            npc.noGravity = true;
            npc.noTileCollide = true;
            npc.HitSound = SoundID.NPCHit2;
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
            if (npc.ai[1] >= 230)
            {
                float Speed = 10f;
                Vector2 vector8 = new Vector2(npc.position.X + (npc.width / 2), npc.position.Y + (npc.height / 2));
                int damage = 50;
                int type = ProjectileID.LostSoulHostile;
                Main.PlaySound(SoundID.Item21, (int)npc.position.X, (int)npc.position.Y);
                float rotation = (vector8 - P.Center).ToRotation();
                int num54 = Projectile.NewProjectile(vector8.X, vector8.Y, (float)((Math.Cos(rotation) * Speed) * -1), (float)((Math.Sin(rotation) * Speed) * -1), type, damage, 0f, 0);
                npc.ai[1] = 0;
            }




        }
    }
}