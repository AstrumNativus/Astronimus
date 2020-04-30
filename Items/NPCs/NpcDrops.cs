using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace QuodAstrum.NPCs
{
    public class NpcDrops : GlobalNPC
    {
        public override void NPCLoot(NPC npc)
        {

            if (npc.type == mod.NPCType("AstrumTerr")) //this is where you choose what vanilla npc you want  , for a modded npc add this instead  if (npc.type == mod.NPCType("ModdedNpcName"))
            {
                if (!AstrumWorld.spawnDragonAge)
                {                                                          //Red  Green Blue
                    Main.NewText("Lyrium has developed in the world caverns", 50, 100, 225);
                    Main.NewText("You are a unique failure, but a failure nonetheless", 255, 0, 247);//this is the message that will appear when the npc is killed  , 200, 200, 55 is the text color
                    for (int k = 0; k < (int)((double)(WorldGen.rockLayer * Main.maxTilesY) * 40E-05); k++)   //40E-05 is how many veins ore is going to spawn , change 40 to a lover value if you want less vains ore or higher value for more veins ore
                    {
                        int X = WorldGen.genRand.Next(0, Main.maxTilesX);
                        int Y = WorldGen.genRand.Next((int)WorldGen.rockLayer, Main.maxTilesY + 200); //this is the coordinates where the veins ore will spawn, so in Cavern layer
                        WorldGen.OreRunner(X, Y, WorldGen.genRand.Next(9, 15), WorldGen.genRand.Next(5, 9), (ushort)mod.TileType("LyriumOre"));   //WorldGen.genRand.Next(9, 15), WorldGen.genRand.Next(5, 9) is the vein ore sizes, so 9 to 15 blocks or 5 to 9 blocks, mod.TileType("CustomOreTile") is the custom tile that will spawn
                    }
                }
                AstrumWorld.spawnDragonAge = true;
                AstrumWorld.downedTerrum = true; //so the message and the ore spawn does not proc(show) when you kill EoC/npc again
            }
            if (npc.type == NPCID.WallofFlesh)
            //this is where you choose what vanilla npc you want  , for a modded npc add this instead  if (npc.type == mod.NPCType("ModdedNpcName"))
            {
                if (!AstrumWorld.spawnWyvernSteel)
                {                                                          //Red  Green Blue
                    Main.NewText("The Sky has been gifted with the Wyvern's Steel", 150, 100, 255);
                    Main.NewText("Your attempt at showing me skill has not worked in the slightest. Fine, whatever, you killed a wall, and now everything wants to kill you.", 255, 0, 247);//this is the message that will appear when the npc is killed  , 200, 200, 55 is the text color
                    for (int k = 0; k < (int)((double)(Main.maxTilesX * Main.maxTilesY) * 50E-05); k++)   //40E-05 is how many veins ore is going to spawn , change 40 to a lover value if you want less vains ore or higher value for more veins ore
                    {
                        int X = WorldGen.genRand.Next(10, Main.maxTilesX);
                        int Y = WorldGen.genRand.Next(10, 100); //this is the coordinates where the veins ore will spawn, so in Cavern layer
                        WorldGen.OreRunner(X, Y, WorldGen.genRand.Next(5, 10), WorldGen.genRand.Next(5, 10), (ushort)mod.TileType("AstrumRock"));
                        
                    }
                }
                AstrumWorld.spawnWyvernSteel = false;   //so the message and the ore spawn does not proc(show) when you kill EoC/npc again
            }
            if (npc.type == mod.NPCType("AstrumMachina")) //this is where you choose what vanilla npc you want  , for a modded npc add this instead  if (npc.type == mod.NPCType("ModdedNpcName"))
            {
                if (!AstrumWorld.downedMachina)
                {                                                          //Red  Green Blue

                    Main.NewText("So, the lost machine has become found once more... pity you had to destroy it.", 255, 0, 247);//this is the message that will appear when the npc is killed  , 200, 200, 55 is the text color

                }

                AstrumWorld.downedMachina = true; //so the message and the ore spawn does not proc(show) when you kill EoC/npc again
            }
            if (npc.type == NPCID.Plantera)
            //this is where you choose what vanilla npc you want  , for a modded npc add this instead  if (npc.type == mod.NPCType("ModdedNpcName"))
            {
                if (!AstrumWorld.downedPlant)
                {                                                          //Red  Green Blue
                    Main.NewText("As a good friend of mine once said, 'Congratulations! You killed a plant!'", 255, 0, 247);//this is the message that will appear when the npc is killed  , 200, 200, 55 is the text color
                    
                }

            }
            if (npc.type == mod.NPCType("Vecna")) //this is where you choose what vanilla npc you want  , for a modded npc add this instead  if (npc.type == mod.NPCType("ModdedNpcName"))
            {
                if (!AstrumWorld.downedVecna)
                {                                                          //Red  Green Blue

                    Main.NewText("It appears you've put the Lich to rest. But be warned, the whispers of his wrath shall never fully stop, there's always one who still believes...", 255, 0, 247);//this is the message that will appear when the npc is killed  , 200, 200, 55 is the text color

                }

                AstrumWorld.downedVecna = true; //so the message and the ore spawn does not proc(show) when you kill EoC/npc again
            }

        }
    }
}