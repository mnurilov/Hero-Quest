using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class BattleState : State
    {
        string playerInput;
        public bool playerTurn = true;


        //Determines who goes first in the turn 
        public void DetermineTurn(Player player, Enemy enemy)
        {
            if(player.Speed > enemy.Speed)
            {
                playerTurn = true;
            }
            else if(enemy.Speed > player.Speed)
            {
                playerTurn = false;
            }
            else
            {
                int turnDecider = RandomNumberGenerator.RandomNumberBetween(1, 100);
                if (turnDecider > 50)
                {
                    playerTurn = true;
                }
                else
                {
                    playerTurn = false;
                }
            }
        }

        public override void Update(Player player)
        {
            playerInput = Console.ReadLine();
            bool playerInputIsValid = false;

            while (!playerInputIsValid)
            {
                if (playerInput != "attack" && playerInput != "spell" && playerInput != "view stats" && playerInput != "run away"
                    && playerInput != "cast fire" && playerInput != "cast thunder")
                {
                    Console.WriteLine("Wrong command given, please enter a new command");
                    playerInput = Console.ReadLine();
                    playerInput = playerInput.ToLower();
                }
                else
                {
                    playerInputIsValid = true;
                }
            }

            DetermineTurn(player, player.CurrentLocation.CurrentEnemy);

            if (playerTurn)
            {
                playerTurn = false;
                InputManager.ManageBattleStateInput(player, player.CurrentLocation.CurrentEnemy, playerInput);
                if(Player.PlayerState == Player.State.Travel)
                {
                    return;
                }
                if(player.CurrentLocation.CurrentEnemy.CurrentHealth <= 0)
                {
                    Console.WriteLine("{0} killed a {1}", player.Name, player.CurrentLocation.CurrentEnemy.Name);
                    player.GainExperience(player.CurrentLocation.CurrentEnemy.ExperiencePoints);
                    Player.PlayerState = Player.State.Travel;
                    return;
                }

                player.CurrentLocation.CurrentEnemy.AttackCommand(player);
                if (player.CurrentHealth <= 0)
                {
                    Console.WriteLine("{0} was killed by a {1}", player.Name, player.CurrentLocation.CurrentEnemy.Name);
                    Player.PlayerState = Player.State.GameOver;
                    return;
                }
            }
            else
            {
                playerTurn = true;
                player.CurrentLocation.CurrentEnemy.AttackCommand(player);
                if (player.CurrentHealth <= 0)
                {
                    Console.WriteLine("{0} was killed by a {1}", player.Name, player.CurrentLocation.CurrentEnemy.Name);
                    Player.PlayerState = Player.State.GameOver;
                    return;
                }

                InputManager.ManageBattleStateInput(player, player.CurrentLocation.CurrentEnemy, playerInput);
                if (player.CurrentLocation.CurrentEnemy.CurrentHealth <= 0)
                {
                    Console.WriteLine("{0} killed a {1}", player.Name, player.CurrentLocation.CurrentEnemy.Name);
                    player.GainExperience(player.CurrentLocation.CurrentEnemy.ExperiencePoints);
                    Player.PlayerState = Player.State.Travel;
                    return;
                }
            }
        }
    }
}
