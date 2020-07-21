using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace QuodAstrum.Items.Weapons
{
    public class DuneFrostPistol : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dune Frost Pistol");
            Tooltip.SetDefault("The gun of blazing heat and freezing cold");
        }
        public override void SetDefaults()
        {
            item.damage = 20;
            item.ranged = true;                     //this make the item do magic damage
            item.width = 32;
            item.height = 32;
            item.crit = 10;
            item.useTime = 15;
            item.useAnimation = 15;
            item.useStyle = ItemUseStyleID.HoldingOut;        //this is how the item is holded
            item.noMelee = true;
            item.knockBack = 5;
            item.value = 1;
            item.rare = ItemRarityID.Quest;           //mana use
            item.UseSound = SoundID.Item41;            //this is the sound when you use the item
            item.autoReuse = true;
            item.useAmmo = AmmoID.Bullet;
            item.shoot = mod.ProjectileType("DuneFrostBullet");  //this make the item shoot your projectile
            item.shootSpeed = 12f;    //projectile speed when shoot
        }
        public override bool ConsumeAmmo(Player player)
        {
            return Main.rand.NextFloat() >= .25f;
        }
        public override void AddRecipes()
        {                                        //this is how to craft this item
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("FrostScale"), 30);
            recipe.AddIngredient(mod.ItemType("DuneScale"), 30);
            recipe.AddTile(TileID.Anvils);  //this is where to craft the item ,WorkBenches = all WorkBenches    Anvils = all anvils , MythrilAnvil = Mythril Anvil and Orichalcum Anvil, Furnaces = all furnaces , DemonAltar = Demon Altar and Crimson Altar , TinkerersWorkbench = Tinkerer's Workbench
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            if (type == ProjectileID.Bullet) //remove this line if you want it to override all projectile instead of just wooden arrows, which i do not recommend
            {
                type = mod.ProjectileType("DuneFrostBullet");
            }
            float numberProjectiles = 2; // 3, 4, or 5 shots
            float rotation = MathHelper.ToRadians(5);
            position += Vector2.Normalize(new Vector2(speedX, speedY)) * 5f;
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (numberProjectiles))) * 1f; // Watch out for dividing by 0 if there is only 1 projectile.
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false;
        }
    }
}