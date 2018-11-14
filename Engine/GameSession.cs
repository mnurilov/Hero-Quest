using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class GameSession
    {
        public Player CurrentPlayer;
        public LocationEnemy CurrentLocationEnemy;
        //public Vendor CurrentVendor;

        public GameSession()
        {
            CurrentPlayer = new Player(1, "Bob", Player.Class.Warrior);
        }

        public void AttackCommand()
        {
            if (CurrentLocationEnemy != null)
            {
                CurrentPlayer.AttackCommand(CurrentLocationEnemy);
            }
        }
    }
}

