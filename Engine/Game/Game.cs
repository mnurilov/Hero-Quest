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
            Player player = new Player(1, "Bob", Player.Class.Thief);

            IntroductionState introductionState = new IntroductionState();
            TravelState ts = new TravelState();
            BattleState bs = new BattleState();
            ShopState ss = new ShopState();
            GameStateManager.Push(ts);

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
                    case Player.State.Shop:
                        GameStateManager.Set(ss);
                        break;
                }
                GameStateManager.Update(player);
            }
        }
    }
}
