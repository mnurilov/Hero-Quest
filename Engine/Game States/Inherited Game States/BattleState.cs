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
        bool playerTurn = true;

        public void Update(Player player)
        {
            playerInput = Console.ReadLine();
            
            if (playerTurn)
            {
                playerTurn = false;
                InputManager.ManageBattleStateInput(player, player.CurrentLocation.CurrentEnemy, playerInput);
                if(player.CurrentLocation.CurrentEnemy.CurrentHealth <= 0)
                {
                    Console.WriteLine("{0} killed a {1}", player.Name, player.CurrentLocation.CurrentEnemy.Name);
                    Player.PlayerState = Player.State.Travel;
                }
            }
            else
            {
                playerTurn = true;
                player.CurrentLocation.CurrentEnemy.AttackCommand(player);
                if (player.CurrentHealth <= 0)
                {
                    Console.WriteLine("{0} was killed by a {1}", player.Name, player.CurrentLocation.CurrentEnemy.Name);
                    Player.PlayerState = Player.State.Travel;
                }
            }
        }

        public void Draw()
        {

        }
    }
}
