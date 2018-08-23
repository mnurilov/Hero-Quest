using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class GameStateMachine
    {
        public enum GameState { Travel, Battle, Shop }

        public enum Transition { Encounter, PlayerDeath, EnemyDeath, RunAway, EnterShop, LeaveShop }

        public void Update()
        {
            /*switch (gameState)
            {
                case GameState.Travel:
                    //Display Travel UI();
                    //Wait for travel input();
                    //Travel Logic();
                    break;
                case GameState.Battle:
                    //Display Battle UI();
                    //Wait for battle input();
                    //Battle Logic();
                    break;
                case GameState.Shop:
                    //Display Shop UI();
                    //Wait for shop input();
                    //Shop Logic();
                    break;
                default:
                    throw new Exception("No game state!");
            }*/
        }
    }
}
