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
            Player player = new Player(100, 10, 5, 6, 7, 8, 9, 9);

            Console.Write(player.ToString());
            Console.ReadKey();

            while (true)
            {
                player.GainExperience(10);
                Console.Write(player.ToString());
                Console.ReadKey();
            }
            


            Weapon weapon = new Weapon(1, "Rusty Sword");
        }
    }
}
