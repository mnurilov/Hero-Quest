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
        public Enemy CurrentEnemy;
        //Holds the result of a battle whether an entity missed, normally hit, or critical hit their opponent
        public enum BattleResult { Missed, Normal, Critical }
        public enum GameState { Introduction, Travel, Battle, Shop, GameOver }
        public enum Transition { CreatePlayer, Encounter, ExitBattle, EnterShop, ExitShop, Death }
        public GameState GameStates;
        public Transition Transitions;
        public event MyEventHandler OnMessagedRaised;

        public GameSession()
        {
            CurrentPlayer = new Player(1, "Bob", Player.Class.Thief);
        }

        public void Action()
        {
            switch (GameStates)
            {
                case GameState.Introduction:
                    break;
                case GameState.Travel:

                    break;
                case GameState.Battle:
                    break;
                case GameState.Shop:
                    break;
                case GameState.GameOver:
                    break;
            }
        }
        
        public void AttackCommand()
        {
            BattleResult battleResult = BattleResult.Normal;

            if (CurrentEnemy != null)
            {
                int damage = CurrentPlayer.Attack(CurrentEnemy, ref battleResult);

                CurrentEnemy.CurrentHealth -= damage;

                switch (battleResult)
                {
                    case BattleResult.Missed:
                        RaiseMessage(CurrentPlayer.Name + " missed");
                        break;
                    case BattleResult.Normal:
                        RaiseMessage(CurrentPlayer.Name + " does " + damage + " points of damage");
                        break;
                    case BattleResult.Critical:
                        RaiseMessage(CurrentPlayer.Name + " critically strikes and does " + damage + " points of damage");
                        break;
                }
            }
        }

        //NEED TO DO: Add a way for the player to choose a spell currently it just picks the first spell which is fire
        public void CastSpellCommand()
        {
            BattleResult battleResult = BattleResult.Normal;

            if (CurrentEnemy != null)
            {
                int damage = CurrentPlayer.CastSpell(CurrentEnemy, (DamageSpell)World.FindSpellByID(1), ref battleResult);

                CurrentEnemy.CurrentHealth -= damage;

                switch (battleResult)
                {
                    case BattleResult.Missed:
                        RaiseMessage(CurrentPlayer.Name + " missed his magical attack");
                        break;
                    case BattleResult.Normal:
                        RaiseMessage(CurrentPlayer.Name + " does " + damage + " points of magical damage");
                        break;
                    case BattleResult.Critical:
                        RaiseMessage(CurrentPlayer.Name + " critically strikes and does " + damage + " points of magical damage");
                        break;
                }
            }
        }

        public void RunCommand()
        {
            if(CurrentPlayer.Run(CurrentEnemy) == true)
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
            CurrentEnemy = CurrentPlayer.CurrentLocation.SelectEnemy();
        }

        public void MoveSouthCommand()
        {
            CurrentPlayer.MoveSouth();
            RaiseMessage(CurrentPlayer.CurrentLocation.ToString());
            CurrentEnemy = CurrentPlayer.CurrentLocation.SelectEnemy();
        }

        public void MoveWestCommand()
        {
            CurrentPlayer.MoveWest();
            RaiseMessage(CurrentPlayer.CurrentLocation.ToString());
            CurrentEnemy = CurrentPlayer.CurrentLocation.SelectEnemy();
        }

        public void MoveEastCommand()
        {
            CurrentPlayer.MoveEast();
            RaiseMessage(CurrentPlayer.CurrentLocation.ToString());
            CurrentEnemy = CurrentPlayer.CurrentLocation.SelectEnemy();
        }

        public void RaiseMessage(string message)
        {
            OnMessagedRaised?.Invoke(this, new MessageEventArgs(message));
        }
    }
}