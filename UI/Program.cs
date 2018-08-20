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
            Player player = new Player(1, "Bobby", Player.Class.Thief);

            //Forcibly run the world static constructor
            //Type type = typeof(World);
            //System.Runtime.CompilerServices.RuntimeHelpers.RunClassConstructor(type.TypeHandle);

            // Console.Write(player.ToString());

            Console.WriteLine(player.ToString());
            Console.ReadKey();


            string command = "";




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
                    case "vendor":
                        if(player.CurrentLocation.VendorInLocation != null)
                        {
                            Console.WriteLine(player.CurrentLocation.VendorInLocation.ToString());
                        }
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
