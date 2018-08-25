using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class TravelState : IState
    {
        string playerInput;

        public void Update()
        {

        }
        public void Update(Player player)
        {
            playerInput = Console.ReadLine();
            InputManager.ManageTravelStateInput(player, playerInput);
        }

        public void Draw()
        {

        }
    }
}
