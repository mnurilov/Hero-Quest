using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class GameOverState : State
    {
        public override void Update(Player player)
        {
            Console.WriteLine("Game Over!");
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}
