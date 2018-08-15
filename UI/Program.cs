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
            Player player = new Player(100, 10, 5, 6, 7, 8, 9, 9, Player.Class.Thief);

            Console.Write(player.ToString());
            Console.ReadKey();

            while (true)
            {
                player.LevelUp();
                Console.Write(player.ToString());
                Console.ReadKey();
            }
        }
    }
}
