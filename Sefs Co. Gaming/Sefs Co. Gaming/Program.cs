﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sefs_Co.Gaming
{
    class Program
    {
        static void Main(string[] args)
        {

            Games game1 = new Games("Borderlands: The Pre-Sequel", "PEGI 18", "Borderlands: The Pre-Sequel is an action role-playing first-person shooter video game developed by 2K Australia, with assistance from Gearbox Software and published by 2K Games", 75, 59.99, true);
            Games game2 = new Games("SUPERHOT", "ESRB T", "SUPERHOT is the first person shooter where time moves only when you move. No regenerating health bars. No conveniently placed ammo drops. It's just you, outnumbered and outgunned, grabbing weapons off fallen enemies to shoot, slice, and maneuver through a hurricane of slow-motion bullets.", 82, 34.99, false);
            Games game3 = new Games("Tales of Berseria™", "ESRB T", "Players embark on a journey of self-discovery as they assume the role of Velvet, a young woman whose once kind demeanor has been replaced and overcome with a festering anger and hatred after a traumatic experience three years prior to the events within Tales of Berseria.", 80, 89.95, false);
            Games game4 = new Games("The Elder Scrolls® Online", "ESRB M", "Join over 10 million players in the award-winning online multiplayer RPG and experience limitless adventure in a persistent Elder Scrolls world. Battle, craft, steal, or explore, and combine different types of equipment and abilities to create your own style of play. No game subscription required.", 71, 39.95, false);
            Games game5 = new Games("Warframe", "ESRB M", "Warframe is a cooperative free-to-play third person online action game set in an evolving sci-fi world.", 71, 00.00, false);
            Games game6 = new Games("Grand Theft Auto V", "R 18", "Los Santos is a city of bright lights, long nights and dirty secrets, and they don’t come brighter, longer or dirtier than in GTA Online: After Hours. The party starts now.", 96, 54.95, true);
            Games game7 = new Games("DRAGON QUEST® XI: Echoes of an Elusive Age™ - Digital Edition of Light", "PEGI 12", "DRAGON QUEST® XI: Echoes of an Elusive Age™ follows the perilous journey of a hunted Hero who must uncover the mystery of his fate with the aid of a charismatic cast of supporting characters.", 94, 99.95, true);

            string menu;

            do
            {
                Console.WriteLine("Welcome to Sefs Co. Gaming's project MemeTeam.");
                Console.WriteLine("'a' View All Games");
                Console.WriteLine("'b' View Restricted Games");
                Console.WriteLine("'c' View Un-Restricted Games");
                Console.WriteLine("'d' Join The Meme Team");
                Console.WriteLine("'e' Exit");

                menu = Console.ReadLine();
                Console.WriteLine();
                switch (menu)
                {
                    case "a":
                        Console.WriteLine("All Games:");
                        break;
                    case "b":
                        Console.WriteLine("Restricted Games:");
                        break;
                    case "c":
                        Console.WriteLine("Un-Restricted Games:");
                        break;
                    case "d":
                        Console.WriteLine("Enter Game Details:");
                        break;
                    case "e":
                        break;
                    default:
                        Console.WriteLine("Error: 404");
                        break;

                }
            } while (menu != "e");
        }
    }
}