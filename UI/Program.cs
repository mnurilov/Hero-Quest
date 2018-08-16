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
            Console.ReadKey();

            while (true)
            {
                player.GainExperience(1000);
                Console.Write(player.ToString());
                Console.ReadKey();
            }
        }
    }
}
