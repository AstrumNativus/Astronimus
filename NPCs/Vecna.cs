using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace QuodAstrum.NPCs
{
    [AutoloadBossHead]
    public class Vecna : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Vecna, The Whispered");

        }
        public override void SetDefaults()
        {
            npc.aiStyle = 10;
            aiType = NPCID.GiantCursedSkull;
            npc.lifeMax = 8000;
            npc.damage = 60;
            npc.defense = 25;
            npc.knockBackResist = 0f;
            npc.width = 100;
            npc.height = 155;
            npc.value = Item.buyPrice(0, 0, 50, 0);
            Main.npcFrameCount[npc.type] = 4;
            npc.npcSlots = 1f;
            npc.boss = true;
            npc.lavaImmune = true;
            npc.noGravity = true;
            npc.noTileCollide = true;
            npc.HitSound = SoundID.NPCHit2;
            npc.DeathSound = SoundID.NPCDeath10;
            npc.buffImmune[BuffID.Confused] = true;
            music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/Vecna");

        }
       
        public override void ScaleExpertStats(int numPlayers, float bossLifeScale)
        {
            npc.lifeMax = (int)(npc.lifeMax * 0.625f * bossLifeScale);
            npc.damage = (int)(npc.damage * 0.6f);
        }
        int frameHeight = 118;
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
        npc.ai[0]++;
            Player P = Main.player[npc.target];
            if (npc.target < 0 || npc.target == 255 || Main.player[npc.target].dead || !Main.player[npc.target].active)
            {
                npc.TargetClosest(true);
            }
            npc.netUpdate = true;

            npc.ai[1]++;
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
            npc.ai[1] += 0;
        }
        public override void NPCLoot()
        {
            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.GoldenKey, 10);
            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.Bone, 50);
            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("StaffOfWhispers"), 1);
        }
    }
}