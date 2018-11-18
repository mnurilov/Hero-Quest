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
                        RaiseMessage(CurrentPlayer.Name + " does " + damage + " points of damage");
                        break;
                    case "Critical":
                        RaiseMessage(CurrentPlayer.Name + " critically strikes and does " + damage + " points of damage");
                        break;
                }
            }
        }

        //NEED TO DO: Add a way for the player to choose a spell currently it just picks the first spell which is fire
        public void SpellCommand()
        {
            string spellResult = "";

            if (CurrentLocationEnemy != null)
            {
                int damage = CurrentPlayer.SpellCommand(CurrentLocationEnemy, World.FindSpellByID(1), ref spellResult);

                CurrentLocationEnemy.CurrentHealth -= damage;

                switch (spellResult)
                {
                    case "Missed":
                        RaiseMessage(CurrentPlayer.Name + " missed his magical attack");
                        break;
                    case "Normal":
                        RaiseMessage(CurrentPlayer.Name + " does " + damage + " points of magical damage");
                        break;
                    case "Critical":
                        RaiseMessage(CurrentPlayer.Name + " critically strikes and does " + damage + " points of magical damage");
                        break;
                }
            }
        }

        public void RunCommand()
        {
            if(CurrentPlayer.RunCommand(CurrentPlayer.CurrentLocation.CurrentEnemy) == true)
            { 
                RaiseMessage(CurrentPlayer.Name + " ran away from the fight");
            }
            else
            {
                RaiseMessage(CurrentPlayer.Name + " failed to run away from the fight");
            }
        }

        public void MoveNorthCommand()
        {
            CurrentPlayer.MoveNorth();
            RaiseMessage(CurrentPlayer.CurrentLocation.ToString());
        }

        public void MoveSouthCommand()
        {
            CurrentPlayer.MoveSouth();
            RaiseMessage(CurrentPlayer.CurrentLocation.ToString());
        }

        public void MoveWestCommand()
        {
            CurrentPlayer.MoveWest();
            RaiseMessage(CurrentPlayer.CurrentLocation.ToString());
        }

        public void MoveEastCommand()
        {
            CurrentPlayer.MoveEast();
            RaiseMessage(CurrentPlayer.CurrentLocation.ToString());
        }

        public void RaiseMessage(string message)
        {
            OnMessagedRaised?.Invoke(this, new MessageEventArgs(message));
        }
    }
}