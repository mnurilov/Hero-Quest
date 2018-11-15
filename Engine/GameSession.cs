using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public delegate void MyEventHandler(object o, MessageEventArgs e);

    public class GameSession
    {
        public Player CurrentPlayer;
        public LocationEnemy CurrentLocationEnemy;
        //public Vendor CurrentVendor;
        public event MyEventHandler OnMessagedRaised;

        public GameSession()
        {
            CurrentPlayer = new Player(1, "Bob", Player.Class.Thief);
            CurrentLocationEnemy = World.CreateNewLocationEnemy(new LocationEnemy(World.FindEnemyByID(1), 10));
        }

        public void AttackCommand()
        {
            string attackResult = "";

            if (CurrentLocationEnemy != null)
            {
                int damage = CurrentPlayer.AttackCommand(CurrentLocationEnemy, ref attackResult);

                CurrentLocationEnemy.CurrentHealth -= damage;

                switch (attackResult)
                {
                    case "Missed":
                        RaiseMessage(CurrentPlayer.Name + " missed");
                        break;
                    case "Normal":
                        RaiseMessage(CurrentPlayer.Name + " does " + damage + " point of damage");
                        break;
                    case "Critical":
                        RaiseMessage(CurrentPlayer.Name + " critically strikes and does " + damage + " point of damage");
                        break;
                }
            }
        }

        public void RaiseMessage(string message)
        {
            OnMessagedRaised?.Invoke(this, new MessageEventArgs(message));
        }
    }
}

