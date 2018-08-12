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
            Player player = new Player(5, 10);

            Console.WriteLine(player.Health);
            Console.ReadKey();

            Console.WriteLine(player.Level);
            Console.ReadKey();
            Console.ReadKey();

        }
    }
}
