using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace QuodAstrum.NPCs
{
    //[AutoloadBossHead]
    public class Maris : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Maris, Baroness of the Seas");

        }
        public override void SetDefaults()
        {
            npc.aiStyle = -1;
            npc.lifeMax = 3000;
            npc.damage = 15;
            npc.defense = 10;
            npc.knockBackResist = 0f;
            npc.width = 148;
            npc.height = 170;
            npc.value = Item.buyPrice(0, 0, 50, 0);
            npc.npcSlots = 1f;
            npc.boss = true;
            npc.lavaImmune = true;
            npc.noGravity = false;
            npc.noTileCollide = false;
            npc.HitSound = SoundID.Item9;
            npc.DeathSound = SoundID.NPCDeath59;
            npc.buffImmune[BuffID.Confused] = true;
            music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/Maris");
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
            npc.netUpdate = true;

            npc.ai[1]++;
            if (npc.ai[0] % 600 == 3)
            {
                NPC.NewNPC((int)npc.position.X, (int)npc.position.Y, NPCID.Sharkron);
                NPC.NewNPC((int)npc.position.X, (int)npc.position.Y, NPCID.Sharkron2);
                Vector2 vector8 = new Vector2(npc.position.X + (npc.width / 2), npc.position.Y + (npc.height / 2));
                int damage = 25;
                int type = ProjectileID.Bubble;
                float rotation = (vector8 - P.Center).ToRotation();
                int num54 = Projectile.NewProjectile(vector8.X, vector8.Y, (float)((Math.Cos(rotation) * 0) * -1), (float)((Math.Sin(rotation) * 0) * -1), type, damage, 0f, 0);
            }
        }
        public override void NPCLoot()
        {
            //Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.DirtBlock, 10);
        }
    }
}