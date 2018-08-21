using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Game
    {
        public enum GameState { Battle = 1 }
        private GameState gameState;

        public void Update()
        {
            if(gameState == GameState.Battle)
            {
                //Battle();
            }
            if(gameState == GameState.Save)
            {
                //Save();
            }
            if(gameState == GameState.Load)
            {
                //Load();
            }
            if(gameState == GameState.Menu)
            {
                //Menu();
            }
        }
    }
}
