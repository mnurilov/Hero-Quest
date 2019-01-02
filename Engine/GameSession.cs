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
        public enum EnemyChoiceTaken { Attack, CastSpell, Replenish }
        public enum GameState { Introduction, Travel, Battle, Shop, GameOver }
        public enum Direction { NORTH, SOUTH, WEST, EAST }
        public GameState GameStates;
        public event MyEventHandler OnMessagedRaised;
        public int TurnCounter;

        public GameSession()
        {
            //Fix this
            CurrentPlayer = new Player(1, "Bob", Player.Class.Thief);
            CurrentPlayer.PlayerItems.Add(World.FindItemByID(1), 3);
            CurrentPlayer.PlayerItems.Add(World.FindItemByID(2), 6);
            CurrentPlayer.PlayerItems.Add(World.FindItemByID(9), 10);
            CurrentPlayer.PlayerItems.Add(World.FindItemByID(11), 3);
            CurrentPlayer.PlayerEquipments.Add(World.FindEquipmentByID(1));
            CurrentPlayer.PlayerEquipments.Add(World.FindEquipmentByID(5));
            CurrentPlayer.PlayerEquipments.Add(World.FindEquipmentByID(7));
            CurrentPlayer.PlayerEquipments.Add(World.FindEquipmentByID(13));
            CurrentPlayer.PlayerSpells.Add(World.FindSpellByID(2));
            CurrentPlayer.PlayerSpells.Add(World.FindSpellByID(1));


            GameStates = GameState.Travel;
        }

        //Checks if the game state passed through the parameter is the same as the current game state
        private void CheckGameState(GameState gameState)
        {
            if(GameStates != gameState)
            {
                throw new Exception("You cannot access this function, you are not in the correct game state.");
            }
        }
        
        public void AttackCommand()
        {
            CheckGameState(GameState.Battle);

            TurnCounter++;

            BattleResult battleResult = BattleResult.Normal;

            if (CurrentEnemy != null)
            {
                if (CurrentPlayer.IsPlayerTurn(CurrentEnemy))
                {
                    PlayerAttack(battleResult);
                    if(GameStates == GameState.Battle)
                    {
                        EnemyCombatAction(battleResult);
                    }
                }
                else
                {
                    EnemyCombatAction(battleResult);
                    if(GameStates == GameState.Battle)
                    {
                        PlayerAttack(battleResult);
                    }
                }
            }
        }

        public void CastSpellCommand(Spell spell)
        {
            CheckGameState(GameState.Battle);

            TurnCounter++;

            BattleResult battleResult = BattleResult.Normal;

            if (CurrentEnemy != null)
            {
                if (CurrentPlayer.IsPlayerTurn(CurrentEnemy))
                {
                    PlayerCastSpell(spell, battleResult);
                    if (GameStates == GameState.Battle)
                    {
                        EnemyCombatAction(battleResult);
                    }
                }
                else
                {
                    EnemyCombatAction(battleResult);
                    if (GameStates == GameState.Battle)
                    {
                        PlayerCastSpell(spell, battleResult);
                    }
                }
            }
        }

        public void UseItemCommand(Item item)
        {
            CheckGameState(GameState.Battle);

            TurnCounter++;

            BattleResult battleResult = BattleResult.Normal;

            if (CurrentEnemy != null)
            {
                if (CurrentPlayer.IsPlayerTurn(CurrentEnemy))
                {
                    PlayerUseItem(item);
                    if (GameStates == GameState.Battle)
                    {
                        EnemyCombatAction(battleResult);
                    }
                }
                else
                {
                    EnemyCombatAction(battleResult);
                    if (GameStates == GameState.Battle)
                    {
                        PlayerUseItem(item);
                    }
                }
            }
        }

        public void RunCommand()
        {
            CheckGameState(GameState.Battle);

            BattleResult battleResult = BattleResult.Normal;

            if (CurrentPlayer.Run(CurrentEnemy) == true)
            { 
                RaiseMessage(CurrentPlayer.Name + " ran away from the fight");
                CurrentPlayer.ResetEmpowerment();
                CurrentPlayer.DisableGreed();
                TurnCounter = 0;
                GameStates = GameState.Travel;
            }
            else
            {
                RaiseMessage(CurrentPlayer.Name + " failed to run away from the fight");
                EnemyCombatAction(battleResult);
            }
        }

        private void MoveCommand(Direction direction)
        {
            CheckGameState(GameState.Travel);

            switch (direction)
            {
                case Direction.NORTH:
                    CurrentPlayer.MoveNorth();
                    break;
                case Direction.SOUTH:
                    CurrentPlayer.MoveSouth();
                    break;
                case Direction.WEST:
                    CurrentPlayer.MoveWest();
                    break;
                case Direction.EAST:
                    CurrentPlayer.MoveEast();
                    break;
            }

            RaiseMessage(CurrentPlayer.CurrentLocation.ToString());

            //If an encounter would occur, determine the enemy
            if (CurrentPlayer.CurrentLocation.EncounterTriggered())
            {
                CurrentEnemy = CurrentPlayer.CurrentLocation.SelectEnemy();
                TurnCounter = 1;
            }
            else
            {
                CurrentEnemy = null;
            }

            if (CurrentEnemy != null)
            {
                GameStates = GameState.Battle;
            }
        }

        public void MoveNorthCommand()
        {
            MoveCommand(Direction.NORTH);
        }

        public void MoveSouthCommand()
        {
            MoveCommand(Direction.SOUTH);
        }

        public void MoveWestCommand()
        {
            MoveCommand(Direction.WEST);
        }

        public void MoveEastCommand()
        {
            MoveCommand(Direction.EAST);
        }


        private void PlayerAttack(BattleResult battleResult)
        {
            int damage = CurrentPlayer.Attack(CurrentEnemy, ref battleResult);

            CurrentEnemy.CurrentHealth -= damage;

            string weaponUsed;

            if (CurrentPlayer.CurrentWeapon == null)
            {
                weaponUsed = "fists";
            }
            else
            {
                weaponUsed = CurrentPlayer.CurrentWeapon.Name;
            }

            switch (battleResult)
            {
                case BattleResult.Missed:
                    RaiseMessage(CurrentPlayer.Name + " missed");
                    break;
                case BattleResult.Normal:
                    RaiseMessage(CurrentPlayer.Name + " strikes with their " + weaponUsed + " and does " + damage + " points of damage");
                    break;
                case BattleResult.Critical:
                    RaiseMessage(CurrentPlayer.Name + " strikes with their " + weaponUsed + ", it critically strikes and does " + damage + " points of damage");
                    break;
            }


            //TWO OF THE SAME CODE
            if (CurrentEnemy.CurrentHealth <= 0)
            {
                RaiseMessage(CurrentPlayer.Name + " has slain a " + CurrentEnemy.Name);
                CurrentPlayer.GainEnemyRewards(CurrentEnemy);
                CurrentPlayer.CheckKillQuest(CurrentEnemy);
                CurrentPlayer.ResetEmpowerment();
                CurrentPlayer.DisableGreed();
                TurnCounter = 0;
                GameStates = GameState.Travel;
            }
        }

        private void PlayerCastSpell(Spell spell, BattleResult battleResult)
        {
            int damage = CurrentPlayer.CastSpell(CurrentEnemy, (DamageSpell)spell, ref battleResult);

            CurrentEnemy.CurrentHealth -= damage;

            switch (battleResult)
            {
                case BattleResult.Missed:
                    RaiseMessage(CurrentPlayer.Name + " missed " + spell.Name);
                    break;
                case BattleResult.Normal:
                    RaiseMessage(CurrentPlayer.Name + " casts " + spell.Name + " and does " + damage + " points of magical damage");
                    break;
                case BattleResult.Critical:
                    RaiseMessage(CurrentPlayer.Name + " casts " + spell.Name + " and it critically strikes and does " + damage + " points of magical damage");
                    break;
            }


            //TWO OF THE SAME CODE
            if (CurrentEnemy.CurrentHealth <= 0)
            {
                RaiseMessage(CurrentPlayer.Name + " has slain a " + CurrentEnemy.Name);
                CurrentPlayer.GainEnemyRewards(CurrentEnemy);
                CurrentPlayer.CheckKillQuest(CurrentEnemy);
                CurrentPlayer.ResetEmpowerment();
                CurrentPlayer.DisableGreed();
                TurnCounter = 0;
                GameStates = GameState.Travel;
            }
        }

        private void PlayerUseItem(Item item)
        {
            int itemValue = CurrentPlayer.UseItem(item);

            if (item is HealthReplenishingItem)
            {
                CurrentPlayer.CurrentHealth += itemValue;
                RaiseMessage(CurrentPlayer.Name + " used a " + item.Name + " and healed for " + itemValue + " hitpoints");
            }
            else if(item is ManaReplenishingItem)
            {
                CurrentPlayer.CurrentMana += itemValue;
                RaiseMessage(CurrentPlayer.Name + " used a " + item.Name + " and replenished for " + itemValue + " manapoints");
            }
            else if(item is DamageItem)
            {
                CurrentEnemy.CurrentHealth -= itemValue;
                RaiseMessage(CurrentPlayer.Name + " used a " + item.Name + " and did " + itemValue + " points of damage to " + CurrentEnemy.Name);
            }

            if (CurrentEnemy.CurrentHealth <= 0)
            {
                RaiseMessage(CurrentPlayer.Name + " has slain a " + CurrentEnemy.Name);
                CurrentPlayer.GainEnemyRewards(CurrentEnemy);
                CurrentPlayer.CheckKillQuest(CurrentEnemy);
                CurrentPlayer.ResetEmpowerment();
                CurrentPlayer.DisableGreed();
                TurnCounter = 0;
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

        public bool BuyItem(Item item)
        {
            CheckGameState(GameState.Shop);

            if (CurrentPlayer.BuyItem(item))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool StayAtInn(Inn inn)
        {
            if (CurrentPlayer.StayAtInn(inn))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public void EquipCommand(Equipment equipment)
        {
            if (CurrentPlayer.Equip(equipment))
            {
                RaiseMessage("You successfully equipped " + equipment.Name);
            }
            else
            {
                RaiseMessage("You failed to equip " + equipment.Name);
            }
        }

        public void UnEquipCommand(Equipment equipment)
        {
            CurrentPlayer.DeEquip(equipment);

            RaiseMessage("You de equip " + equipment.Name);
        }


        public bool CheckIfQuestCompleted(Quest quest)
        {
            if (!CurrentPlayer.PlayerQuests.Contains(quest))
            {
                return false;
            }
            if(CurrentPlayer.CheckIfQuestComplete(quest) == true)
            {
                CurrentPlayer.QuestRewards(quest);
                return true;
            }
            return false;
        }

        //Enemy Commands
        private void EnemyAttack(BattleResult battleResult, int damage)
        {
            CurrentPlayer.CurrentHealth -= damage;

            switch (battleResult)
            {
                case BattleResult.Missed:
                    RaiseMessage(CurrentEnemy.Name + " missed");
                    break;
                case BattleResult.Normal:
                    RaiseMessage(CurrentEnemy.Name + " strikes with their " + CurrentEnemy.WeaponUsed + " and does " + damage + " points of damage");
                    break;
                case BattleResult.Critical:
                    RaiseMessage(CurrentEnemy.Name + " strikes with their " + CurrentEnemy.WeaponUsed + ", it critically strikes and does " + damage + " points of damage");
                    break;
            }

            if (CurrentPlayer.CurrentHealth <= 0)
            {
                RaiseMessage(CurrentEnemy.Name + " has slain a " + CurrentPlayer.Name);
                GameStates = GameState.GameOver;
            }
        }

        private void EnemyCastSpell(BattleResult battleResult, int damage, string spellName)
        {
            CurrentPlayer.CurrentHealth -= damage;

            switch (battleResult)
            {
                case BattleResult.Missed:
                    RaiseMessage(CurrentEnemy.Name + " missed " + spellName);
                    break;
                case BattleResult.Normal:
                    RaiseMessage(CurrentEnemy.Name + " casts " + spellName + " and does " + damage + " points of magical damage");
                    break;
                case BattleResult.Critical:
                    RaiseMessage(CurrentEnemy.Name + " casts " + spellName + " and it critically strikes and does " + damage + " points of magical damage");
                    break;
            }

            if (CurrentPlayer.CurrentHealth <= 0)
            {
                RaiseMessage(CurrentEnemy.Name + " has slain a " + CurrentPlayer.Name);
                GameStates = GameState.GameOver;
            }
        }

        private void EnemyReplenish(int replenishAmount, string spellName)
        {
            CurrentEnemy.CurrentHealth += replenishAmount;

            RaiseMessage(CurrentEnemy.Name + " casts " + spellName + " and heals for " + replenishAmount + " hitpoints");
        }

        private void EnemyCombatAction(BattleResult battleResult)
        {
            EnemyChoiceTaken enemyChoiceTaken = EnemyChoiceTaken.Attack;
            string spellName = "None";

            int combatValue = CurrentEnemy.CombatAction(CurrentPlayer, ref battleResult, ref enemyChoiceTaken, ref spellName);

            switch (enemyChoiceTaken)
            {
                case EnemyChoiceTaken.Attack:
                    EnemyAttack(battleResult, combatValue);
                    break;
                case EnemyChoiceTaken.CastSpell:
                    EnemyCastSpell(battleResult, combatValue, spellName);
                    break;
                case EnemyChoiceTaken.Replenish:
                    EnemyReplenish(combatValue, spellName);
                    break;
                default:
                    throw new Exception("No enemy choice taken selected some how");
            }
        }

        public void RaiseMessage(string message)
        {
            OnMessagedRaised?.Invoke(this, new MessageEventArgs(message));
        }
    }
}