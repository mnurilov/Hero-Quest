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
            //Fix this
            CurrentPlayer = new Player(1, "Bob", Player.Class.Thief);
            CurrentPlayer.PlayerItems.Add(World.FindItemByID(1), 3);
            CurrentPlayer.PlayerItems.Add(World.FindItemByID(2), 6);
            GameStates = GameState.Travel;
        }

        //Checks if the game state passed through the parameter is the same as the current game state
        private void CheckGameState(GameState gameState)
        {
            if(GameStates == gameState)
            {

            }
            else
            {
                throw new Exception("You cannot access this function, you are not in the correct game state.");
            }
        }
        
        public void AttackCommand()
        {
            CheckGameState(GameState.Battle);

            BattleResult battleResult = BattleResult.Normal;

            if (CurrentEnemy != null)
            {
                if (CurrentPlayer.IsPlayerTurn(CurrentEnemy))
                {
                    PlayerAttack(battleResult);
                    if(GameStates == GameState.Battle)
                    {
                        EnemyAttack(battleResult);
                    }
                }
                else
                {
                    EnemyAttack(battleResult);
                    if(GameStates == GameState.Battle)
                    {
                        PlayerAttack(battleResult);
                    }
                }
            }
        }

        //NEED TO DO: Add a way for the player to choose a spell currently it just picks the first spell which is fire
        public void CastSpellCommand()
        {
            CheckGameState(GameState.Battle);

            BattleResult battleResult = BattleResult.Normal;

            if (CurrentEnemy != null)
            {
                if (CurrentPlayer.IsPlayerTurn(CurrentEnemy))
                {
                    PlayerCastSpell(battleResult);
                    if (GameStates == GameState.Battle)
                    {
                        EnemyAttack(battleResult);
                    }
                }
                else
                {
                    EnemyAttack(battleResult);
                    if (GameStates == GameState.Battle)
                    {
                        PlayerCastSpell(battleResult);
                    }
                }
            }
        }

        public void RunCommand()
        {
            CheckGameState(GameState.Battle);

            if (CurrentPlayer.Run(CurrentEnemy) == true)
            { 
                RaiseMessage(CurrentPlayer.Name + " ran away from the fight");
                GameStates = GameState.Travel;
            }
            else
            {
                RaiseMessage(CurrentPlayer.Name + " failed to run away from the fight");
            }
        }

        public void MoveNorthCommand()
        {
            CheckGameState(GameState.Travel);

            CurrentPlayer.MoveNorth();
            RaiseMessage(CurrentPlayer.CurrentLocation.ToString());
            CurrentEnemy = CurrentPlayer.CurrentLocation.SelectEnemy();
            if(CurrentEnemy != null)
            {
                GameStates = GameState.Battle;
            }
        }

        public void MoveSouthCommand()
        {
            CheckGameState(GameState.Travel);

            CurrentPlayer.MoveSouth();
            RaiseMessage(CurrentPlayer.CurrentLocation.ToString());
            CurrentEnemy = CurrentPlayer.CurrentLocation.SelectEnemy();
            if (CurrentEnemy != null)
            {
                GameStates = GameState.Battle;
            }
        }

        public void MoveWestCommand()
        {
            CheckGameState(GameState.Travel);

            CurrentPlayer.MoveWest();
            RaiseMessage(CurrentPlayer.CurrentLocation.ToString());
            CurrentEnemy = CurrentPlayer.CurrentLocation.SelectEnemy();
            if (CurrentEnemy != null)
            {
                GameStates = GameState.Battle;
            }
        }

        public void MoveEastCommand()
        {
            CheckGameState(GameState.Travel);

            CurrentPlayer.MoveEast();
            RaiseMessage(CurrentPlayer.CurrentLocation.ToString());
            CurrentEnemy = CurrentPlayer.CurrentLocation.SelectEnemy();
            if (CurrentEnemy != null)
            {
                GameStates = GameState.Battle;
            }
        }

        private void PlayerAttack(BattleResult battleResult)
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

            if (CurrentEnemy.CurrentHealth <= 0)
            {
                RaiseMessage(CurrentPlayer.Name + " has slain a " + CurrentEnemy.Name);
                CurrentPlayer.GainEnemyRewards(CurrentEnemy);
                GameStates = GameState.Travel;
            }
        }

        private void PlayerCastSpell(BattleResult battleResult)
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

            if (CurrentEnemy.CurrentHealth <= 0)
            {
                RaiseMessage(CurrentPlayer.Name + " has slain a " + CurrentEnemy.Name);
                CurrentPlayer.GainEnemyRewards(CurrentEnemy);
                GameStates = GameState.Travel;
            }
        }


        public void EnterShop()
        {
            GameStates = GameState.Shop;
        }


        public void ExitShop()
        {
            GameStates = GameState.Travel;
        }
        //Enemy Commands
        private void EnemyAttack(BattleResult battleResult)
        {
            int damage = CurrentEnemy.Attack(CurrentPlayer, ref battleResult);

            CurrentPlayer.CurrentHealth -= damage;

            switch (battleResult)
            {
                case BattleResult.Missed:
                    RaiseMessage(CurrentEnemy.Name + " missed");
                    break;
                case BattleResult.Normal:
                    RaiseMessage(CurrentEnemy.Name + " does " + damage + " points of damage");
                    break;
                case BattleResult.Critical:
                    RaiseMessage(CurrentEnemy.Name + " critically strikes and does " + damage + " points of damage");
                    break;
            }

            if (CurrentPlayer.CurrentHealth <= 0)
            {
                RaiseMessage(CurrentEnemy.Name + " has slain a " + CurrentPlayer.Name);
                GameStates = GameState.GameOver;
            }
        }

        public void RaiseMessage(string message)
        {
            OnMessagedRaised?.Invoke(this, new MessageEventArgs(message));
        }
    }
}