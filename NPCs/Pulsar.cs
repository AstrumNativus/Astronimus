using QuodAstrum.Items.Weapons;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.IO;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace QuodAstrum.NPCs
{
    public class Pulsar : ModNPC
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Pulsar, the Flashing Brother");
            Main.npcFrameCount[npc.type] = 1;

        }
        public override void SetDefaults()
        {
            npc.aiStyle = 14;
            npc.lifeMax = 75000;
            npc.damage = 250;
            npc.defense = 80;
            npc.knockBackResist = 0f;
            npc.width = 200;
            npc.height = 200;
            npc.value = Item.buyPrice(0, 0, 50, 0);
            music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/Pulsar");
            npc.npcSlots = 1f;
            npc.boss = true;
            npc.lavaImmune = true;
            npc.noGravity = true;
            npc.noTileCollide = true;
            npc.HitSound = SoundID.NPCHit3;
            npc.DeathSound = SoundID.NPCDeath59;
            npc.buffImmune[24] = true;
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
            if (npc.ai[2] >= 150)
            {
                float Speed = 10f;
                Vector2 vector8 = new Vector2(npc.position.X + (npc.width / 2), npc.position.Y + (npc.height / 2));
                int damage = 150;
                int type = ProjectileID.VortexLightning;
                float rotation = (vector8 - P.Center).ToRotation();
                int num54 = Projectile.NewProjectile(vector8.X, vector8.Y, (float)((Math.Cos(rotation) * Speed) * -1), (float)((Math.Sin(rotation) * Speed) * -1), type, damage, 0f, 0);
                npc.ai[2] = 200;
            }
            if (npc.ai[1] >= 200)
            {
                Vector2 vector8 = new Vector2(npc.position.X + (npc.width / 2), npc.position.Y + (npc.height / 2));
                int damage = 150;
                int type = ProjectileID.CultistBossLightningOrb;
                float rotation = (vector8 - P.Center).ToRotation();
                int num54 = Projectile.NewProjectile(vector8.X, vector8.Y, (float)((Math.Cos(rotation) * 0) * -1), (float)((Math.Sin(rotation) * 0) * -1), type, damage, 0f, 0);
                npc.ai[1] = 245;
            }
            if (npc.ai[1] >= 250)
            {
                float Speed = 10f;
                Vector2 vector8 = new Vector2(npc.position.X + (npc.width / 2), npc.position.Y + (npc.height / 2));
                int damage = 150;
                int type = ProjectileID.CultistBossIceMist;
                float rotation = (vector8 - P.Center).ToRotation();
                int num54 = Projectile.NewProjectile(vector8.X, vector8.Y, (float)((Math.Cos(rotation) * Speed) * -1), (float)((Math.Sin(rotation) * Speed) * -1), type, damage, 0f, 0);
                npc.ai[1] = 195;
            }
        }
        public override void NPCLoot()
        {
            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Magnesarias")); 
            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Magnerias"));
            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Magnetaris"));
            if (Main.netMode != NetmodeID.MultiplayerClient && Main.rand.NextBool(10))
            {
                Item.NewItem(npc.getRect(), mod.ItemType("PulsarMusicBox"));
            }
        }
    }
}