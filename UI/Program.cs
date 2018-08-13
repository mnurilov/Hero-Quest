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
            Player player = new Player(1, 100, 50, 30, 20, 10, 5, 15, 10, 3);

            Console.Write(player.ToString());
            Console.ReadKey();
        }
    }
}
