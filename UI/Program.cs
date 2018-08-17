using Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player(Player.Class.Thief);

            Console.Write(player.ToString());

            string command = "";
            
            World.ViewItems();

            while (true)
            {
                command = Console.ReadLine();
                command = command.ToLower();
                switch (command)
                {
                    case "north":
                        player.MoveNorth();
                        break;
                    case "south":
                        player.MoveSouth();
                        break;
                    case "west":
                        player.MoveWest();
                        break;
                    case "east":
                        player.MoveEast();
                        break;
                    case "100":
                        player.GainExperience(100);
                        Console.WriteLine(player.ToString());
                        break;
                    case "1000":
                        player.GainExperience(1000);
                        Console.WriteLine(player.ToString());
                        break;
                }
            }
        }
    }
}
