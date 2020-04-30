using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace QuodAstrum.Items.Weapons
{
    public class BookOfBookers : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Book Of Bookers");
        }
        public override void SetDefaults()
        {
            item.damage = 15;
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
            item.mana = 3;             //mana use
            item.UseSound = SoundID.Item1;            //this is the sound when you use the item
            item.autoReuse = true;
            item.shoot = mod.ProjectileType("BookOfBookers");  //this make the item shoot your projectile
            item.shootSpeed = 12f;    //projectile speed when shoot
        }
        public override void AddRecipes()
        {                                        //this is how to craft this item
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Book, 15);
            recipe.AddTile(TileID.Bookcases);  //this is where to craft the item ,WorkBenches = all WorkBenches    Anvils = all anvils , MythrilAnvil = Mythril Anvil and Orichalcum Anvil, Furnaces = all furnaces , DemonAltar = Demon Altar and Crimson Altar , TinkerersWorkbench = Tinkerer's Workbench
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}