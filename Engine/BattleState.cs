using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class BattleState : IState
    {
        string playerInput;

        public void Update()
        {

        }
        public void Update(Player player)
        {
            Enemy enemy = World.FindEnemyByID(1);
            playerInput = Console.ReadLine();
            InputManager.ManageBattleStateInput(player, enemy, playerInput);
        }

        public void Draw()
        {

        }
    }
}
