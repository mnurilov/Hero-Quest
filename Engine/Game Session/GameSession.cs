﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Engine
{
    public delegate void MyEventHandler(object o, MessageEventArgs e);

    public class GameSession
    {
        private const double EnemyGreedDamageModifier = 1.3;

        public Player CurrentPlayer;
        public Enemy CurrentEnemy;

        public event MyEventHandler OnMessagedRaised;

        private enum Direction { North, South, West, East }
        //Holds the result of a battle whether an entity missed, normally hit, or critical hit their opponent
        public enum BattleResult { Missed, Normal, Critical }
        public enum EnemyChoiceTaken { Attack, CastSpell, Replenish }
        public enum GameState { Travel, Battle, GameOver }
        public GameState GameStates;

        //Counts the turns in a battle 
        public int TurnCounter;


        public GameSession(string playerName, Player.Class playerClass)
        {
            CurrentPlayer = new Player(1, playerName, playerClass);

            /*CurrentPlayer.PlayerItems.Add(World.FindItemByID(1), 3);
            CurrentPlayer.PlayerItems.Add(World.FindItemByID(2), 6);
            CurrentPlayer.PlayerItems.Add(World.FindItemByID(9), 10);
            CurrentPlayer.PlayerItems.Add(World.FindItemByID(11), 3);
            CurrentPlayer.PlayerItems.Add(World.FindItemByID(4), 3);
            CurrentPlayer.PlayerItems.Add(World.FindItemByID(5), 5);
            CurrentPlayer.PlayerEquipments.Add(World.FindEquipmentByID(1));
            CurrentPlayer.PlayerEquipments.Add(World.FindEquipmentByID(5));
            CurrentPlayer.PlayerEquipments.Add(World.FindEquipmentByID(7));
            CurrentPlayer.PlayerEquipments.Add(World.FindEquipmentByID(13));
            CurrentPlayer.PlayerEquipments.Add(World.FindEquipmentByID(2));
            CurrentPlayer.PlayerEquipments.Add(World.FindEquipmentByID(9));
            CurrentPlayer.PlayerEquipments.Add(World.FindEquipmentByID(3));

            CurrentPlayer.PlayerEquipments.Add(World.FindEquipmentByID(14));
            CurrentPlayer.PlayerEquipments.Add(World.FindEquipmentByID(15));
            CurrentPlayer.PlayerEquipments.Add(World.FindEquipmentByID(16));
            CurrentPlayer.PlayerEquipments.Add(World.FindEquipmentByID(17));
            CurrentPlayer.PlayerEquipments.Add(World.FindEquipmentByID(18));
            CurrentPlayer.PlayerEquipments.Add(World.FindEquipmentByID(19));
            CurrentPlayer.PlayerEquipments.Add(World.FindEquipmentByID(20));
            CurrentPlayer.PlayerEquipments.Add(World.FindEquipmentByID(21));

            CurrentPlayer.PlayerEquipments.Add(World.FindEquipmentByID(22));
            CurrentPlayer.PlayerEquipments.Add(World.FindEquipmentByID(23));
            CurrentPlayer.PlayerEquipments.Add(World.FindEquipmentByID(24));



            CurrentPlayer.PlayerSpells.Add(World.FindSpellByID(2));
            //CurrentPlayer.PlayerSpells.Add(World.FindSpellByID(1));
            CurrentPlayer.PlayerSpells.Add(World.FindSpellByID(3));*/

            //Set the game state to the starting state
            GameStates = GameState.Travel;
        }


        //Used to check if the function the UI is trying to access has rights to access it
        private void CheckGameState(GameState gameState)
        {
            if(GameStates != gameState)
            {
                throw new Exception("You cannot access this function, you are not in the correct game state.");
            }
        }
        

        //<-----------Movement Commands---------->
        public void MoveNorthCommand()
        {
            MoveCommand(Direction.North);
        }

        public void MoveSouthCommand()
        {
            MoveCommand(Direction.South);
        }

        public void MoveWestCommand()
        {
            MoveCommand(Direction.West);
        }

        public void MoveEastCommand()
        {
            MoveCommand(Direction.East);
        }

        public void MoveToCommand(Location location)
        {
            CurrentPlayer.MoveTo(location);
        }

        private void MoveCommand(Direction direction)
        {
            CheckGameState(GameState.Travel);

            switch (direction)
            {
                case Direction.North:
                    CurrentPlayer.MoveNorth();
                    break;
                case Direction.South:
                    CurrentPlayer.MoveSouth();
                    break;
                case Direction.West:
                    CurrentPlayer.MoveWest();
                    break;
                case Direction.East:
                    CurrentPlayer.MoveEast();
                    break;
            }



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

        public bool CanTravel(Location location)
        {
            return CurrentPlayer.CanTravel(location);
        }

        public void SearchCommand()
        {
            object loot = CurrentPlayer.SearchForLoot();
            
            //LookingForLoot();

            if(loot == null)
            {
                FoundNothing();
            }
            else if(loot is Item)
            {
                FoundItem((Item)loot);
            }
            else if(loot is Equipment)
            {
                FoundEquipment((Equipment)loot);
            }
            else if(loot is Spell)
            {
                FoundSpell((Spell)loot);
            }
            else
            {
                throw new Exception("Somehow player is looting an unknown object from a location");
            }
        }

        private void LookingForLoot()
        {
            RaiseMessage(CurrentPlayer.Name + " is looking for loot");
        }

        private void FoundItem(Item item)
        {
            RaiseMessage(CurrentPlayer.Name + " has found a " + item.Name);
        }

        private void FoundEquipment(Equipment equipment)
        {
            RaiseMessage(CurrentPlayer.Name + " has found a " + equipment.Name);
        }
        
        private void FoundSpell(Spell spell)
        {
            RaiseMessage(CurrentPlayer.Name + " has found a " + spell.Name);
        }

        private void FoundNothing()
        {
            RaiseMessage(CurrentPlayer.Name + " has found nothing");
        }

        //<----------Battle Commands----------->
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
                        PlayerAttack(battleResult);
                    }
                }
            }
        }

        public void CastSpellCommand(Spell spell)
        {
            CheckGameState(GameState.Battle);

            BattleResult battleResult = BattleResult.Normal;

            if (!CanPlayerCastSpell(spell))
            {
                RaiseMessage(CurrentPlayer.Name + " does not have enough mana to cast " + spell.Name);
                return;
            }

            TurnCounter++;

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

        public void UseItemWhileTravelCommand(Item item)
        {
            int itemValue = CurrentPlayer.UseItem(item);

            if (item is HealthReplenishingItem)
            {
                CurrentPlayer.CurrentHealth += itemValue;
                RaiseMessage(CurrentPlayer.Name + " used a " + item.Name + " and healed for " + itemValue + " hitpoints");
            }
            else if (item is ManaReplenishingItem)
            {
                CurrentPlayer.CurrentMana += itemValue;
                RaiseMessage(CurrentPlayer.Name + " used a " + item.Name + " and replenished for " + itemValue + " manapoints");
            }
            else
            {
                throw new Exception("Player is using an item that cannot be used in the travel screen");
            }
        }

        public void CastSpellWhileTravelCommand(Spell spell)
        {
            CheckGameState(GameState.Travel);

            if (!CanPlayerCastSpell(spell))
            {
                RaiseMessage(CurrentPlayer.Name + " does not have enough mana to cast " + spell.Name);
                return;
            }

            if (spell is ReplenishSpell)
            {
                int replenishValue = CurrentPlayer.CastSpellWhileTravel(spell);
                PlayerCastReplenish(replenishValue, (ReplenishSpell)spell);
            }
            else
            {
                throw new Exception("Player is using a spell that cannot be used in the travel screen");
            }
        }

        public void ActivateEmpowermentCommand()
        {
            CurrentPlayer.ActivateEmpowerment();
        }
        
        public bool IsEmpowered()
        {
            if (CurrentPlayer.IsEmpowered())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CanActivateEmpowerment()
        {
            if (CurrentPlayer.CanActivateEmpowerment())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void ActivateGreedCommand()
        {
            CurrentPlayer.ActivateGreed();
        }

        public bool IsGreedActivated()
        {
            if (CurrentPlayer.Greed)
            {
                return true;
            }
            else
            {
                return false;
            }
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

            if (CurrentEnemy.CurrentHealth <= 0)
            {
                GainBattleRewards();
            }
        }

        private void PlayerCastSpell(Spell spell, BattleResult battleResult)
        {
            int spellEffectValue = CurrentPlayer.CastSpell(CurrentEnemy, spell, ref battleResult);
            
            if(spell is DamageSpell)
            {
                PlayerCastDamageSpell(battleResult, spellEffectValue, (DamageSpell)spell);
            }
            else if(spell is ReplenishSpell)
            {
                PlayerCastReplenish(spellEffectValue, (ReplenishSpell)spell);
            }
        }

        private void PlayerCastDamageSpell(BattleResult battleResult, int damage, DamageSpell damageSpell)
        {
            CurrentEnemy.CurrentHealth -= damage;

            switch (battleResult)
            {
                case BattleResult.Missed:
                    RaiseMessage(CurrentPlayer.Name + " missed " + damageSpell.Name);
                    break;
                case BattleResult.Normal:
                    RaiseMessage(CurrentPlayer.Name + " casts " + damageSpell.Name + " and does " + damage + " points of magical damage");
                    break;
                case BattleResult.Critical:
                    RaiseMessage(CurrentPlayer.Name + " casts " + damageSpell.Name + " and it critically strikes and does " + damage + " points of magical damage");
                    break;
            }

            if (CurrentEnemy.CurrentHealth <= 0)
            {
                GainBattleRewards();
            }
        }
        
        private void PlayerCastReplenish(int replenishValue, ReplenishSpell replenishSpell)
        {
            RaiseMessage(CurrentPlayer.Name + " casts " + replenishSpell.Name + " and heals for " + replenishValue + " hitpoints");
            CurrentPlayer.CurrentHealth += replenishValue;
        }

        private bool CanPlayerCastSpell(Spell spell)
        {
            return CurrentPlayer.CurrentMana >= spell.ManaCost;
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
                GainBattleRewards();
            }
        }

        private void GainBattleRewards()
        {
            RaiseMessage("");
            RaiseMessage(CurrentPlayer.Name + " has slain a " + CurrentEnemy.Name);
            List<string> playerLoot = CurrentPlayer.GainEnemyRewards(CurrentEnemy);
            if(playerLoot.Count != 0)
            {
                RaiseMessage(CurrentEnemy.Name + "'s Loot");
            }
            foreach(string loot in playerLoot)
            {
                RaiseMessage(loot);
            }
            CurrentPlayer.UpdateKillQuests(CurrentEnemy);
            CurrentPlayer.ResetEmpowerment();
            CurrentPlayer.DisableGreed();
            TurnCounter = 0;
            GameStates = GameState.Travel;
        }

        public string OnDeath()
        {
            string deathMessage = "";

            int goldLost = 0;
            int experienceLost = 0;

            CurrentPlayer.OnDeath(ref goldLost, ref experienceLost);

            deathMessage += "You lose " + goldLost + " gold!!!\n";
            deathMessage += "You lose " + experienceLost + " experience points!!!\n";
            deathMessage += "You have been brought back to " + World.FindLocationByID(1).Name;

            CurrentPlayer.DisableGreed();
            CurrentPlayer.ResetEmpowerment();

            CurrentEnemy.CurrentHealth = CurrentEnemy.MaximumHealth;
            CurrentEnemy.CurrentMana = CurrentEnemy.MaximumMana;

            return deathMessage;
        }

        public void ReturnToWorld()
        {
            GameStates = GameState.Travel;
        }

        //<----------Equipment Commands---------->
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
            CurrentPlayer.Unequip(equipment);

            RaiseMessage("You unequip " + equipment.Name);
        }

        public bool CheckIfEquippableCommand(Equipment equipment)
        {
            if (CurrentPlayer.CheckIfEquippable(equipment))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CheckIfAlreadyEquipped(Equipment equipment)
        {
            if (CurrentPlayer.CheckIfAlreadyEquipped(equipment))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        //<----------Vendor Commands---------->
        public bool BuyFromStoreCommand(object objectBeingBought)
        {
            CheckGameState(GameState.Travel);

            if (CurrentPlayer.BuyFromStore(objectBeingBought))
            {
                CurrentPlayer.CurrentLocation.VendorInLocation.RemoveFromInventory(objectBeingBought);
                return true;
            } 
            else
            {
                return false;
            }
        }

        public void SellToStoreCommand(object objectBeingSold)
        {
            CheckGameState(GameState.Travel);

            CurrentPlayer.SellToStore(objectBeingSold);

            CurrentPlayer.CurrentLocation.VendorInLocation.AddToInventory(objectBeingSold);
        }


        //<----------Inn Commands---------->
        public bool StayAtInnCommand(Inn inn)
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


        //<----------Quest Commands---------->
        private bool CheckIfQuestCompleted(Quest quest)
        {
            if (!CurrentPlayer.PlayerQuests.Contains(quest))
            {
                return false;
            }
            //if(CurrentPlayer.CheckIfQuestComplete(quest) == true)
            {
                CurrentPlayer.GainQuestRewards(quest);
                return true;
            }
           // return false;
        }


        //<----------Enemy Commands---------->
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

        private void EnemyAttack(BattleResult battleResult, int damage)
        {
            //If the player is using greed the enemy will do more damage
            if (CurrentPlayer.Greed)
            {
                damage = ((int)(damage * EnemyGreedDamageModifier));
            }

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
                RaiseMessage("");
                RaiseMessage(CurrentEnemy.Name + " has slain a " + CurrentPlayer.Name);
                GameStates = GameState.GameOver;
            }
        }

        private void EnemyCastSpell(BattleResult battleResult, int damage, string spellName)
        {
            //If the player is using greed the enemy will do more damage
            if (CurrentPlayer.Greed)
            {
                damage = ((int)(damage * EnemyGreedDamageModifier));
            }

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
                RaiseMessage("");
                RaiseMessage(CurrentEnemy.Name + " has slain a " + CurrentPlayer.Name);
                GameStates = GameState.GameOver;
            }
        }

        private void EnemyReplenish(int replenishAmount, string spellName)
        {
            if (CurrentPlayer.Greed)
            {
                replenishAmount = ((int)(replenishAmount * EnemyGreedDamageModifier));
            }

            CurrentEnemy.CurrentHealth += replenishAmount;

            RaiseMessage(CurrentEnemy.Name + " casts " + spellName + " and heals for " + replenishAmount + " hitpoints");
        }


        public void RaiseMessage(string message)
        {
            OnMessagedRaised?.Invoke(this, new MessageEventArgs(message));
        }
    }
}