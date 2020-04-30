using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace QuodAstrum.Items.Weapons
{
    public class StaffOfWhispers : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Staff Of Whispers");
            Tooltip.SetDefault("The Lich's Staff");
        }
        public override void SetDefaults()
        {
            item.damage = 35;
            item.magic = true;                     //this make the item do magic damage
            item.width = 32;
            item.height = 32;
            item.useTime = 15;
            item.useAnimation = 15;
            item.useStyle = 5;        //this is how the item is holded
            item.noMelee = true;
            item.knockBack = 2;
            item.value = 100;
            item.rare = ItemRarityID.Expert;
            item.mana = 5;             //mana use
            item.UseSound = SoundID.Item28;            //this is the sound when you use the item
            item.autoReuse = true;
            item.shoot = ProjectileID.BoneGloveProj;  //this make the item shoot your projectile
            item.shootSpeed = 12f;    //projectile speed when shoot
        }

    }
}