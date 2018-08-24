using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    //Game class where all the game states will be organized
    public static class Game
    {
        public static void Run()
        {
            Player player;

            IntroductionState introductionState = new IntroductionState();
            TravelState ts = new TravelState();
            BattleState bs = new BattleState();
            GameStateManager.Push(introductionState);
            player = GameStateManager.Update();
            

            while (true)
            {
                switch (Player.PlayerState)
                {
                    case Player.State.Travel:
                        GameStateManager.Set(ts);
                        break;
                    case Player.State.Battle:
                        GameStateManager.Set(bs);
                        break;
                }
                GameStateManager.Update(player);
            }
        }
    }
}
