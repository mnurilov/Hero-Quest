using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public static class InputManager
    {
        public enum Input { North, South, West, East, Vendor, Quest, Stats, Inventory, Equipment, Spells }

        public static void EvaluateInput(Input input, Player player)
        {
            switch (input)
            {
                case Input.North:
                    player.MoveNorth();
                    break;
                case Input.South:
                    player.MoveSouth();
                    break;
                case Input.West:
                    player.MoveWest();
                    break;
                case Input.East:
                    player.MoveEast();
                    break;
                case Input.Vendor:
                    
                    break;
            }
        }
    }
}
