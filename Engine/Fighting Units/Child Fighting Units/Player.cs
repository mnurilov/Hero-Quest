﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Player : FightingUnit
    {
        #region Data Storage
        //CREATE CONSTANTS FOR CAPS ON THE STATS AND GOLD FOR EXAMPLE MAKE A CONSTANT THAT HOLDS THE GOLD CAP FOR GOLD, EASIER TO MODIFY THAT WAY
        #region Constants
        #region Warrior Class Constants
        public const double WarriorHealthStatScaleFactor = 6.073588;
        public const double WarriorHealthStatExponent = 1.7;
        public const double WarriorHealthStatConstant = 10;

        public const double WarriorManaStatScaleFactor = 0.583;
        public const double WarriorManaStatExponent = 1.7;
        public const double WarriorManaStatConstant = 5;

        public const double WarriorAttackStatScaleFactor = 0.58;
        public const double WarriorAttackStatExponent = 1.7;
        public const double WarriorAttackStatConstant = 5;

        public const double WarriorDefenseStatScaleFactor = 0.58;
        public const double WarriorDefenseStatExponent = 1.7;
        public const double WarriorDefenseStatConstant = 5;

        public const double WarriorLuckStatScaleFactor = 0.116681662;
        public const double WarriorLuckStatExponent = 1.7;
        public const double WarriorLuckStatConstant = 1;

        public const double WarriorSpeedStatScaleFactor = 0.227222184;
        public const double WarriorSpeedStatExponent = 1.7;
        public const double WarriorSpeedStatConstant = 3;

        public const double WarriorIntellectStatScaleFactor = 0.147387363;
        public const double WarriorIntellectStatExponent = 1.7;
        public const double WarriorIntellectStatConstant = 1;

        public const double WarriorResistanceStatScaleFactor = 0.147387363;
        public const double WarriorResistanceStatExponent = 1.7;
        public const double WarriorResistanceStatConstant = 1;
        #endregion

        #region Mage Class Constants
        public const double MageHealthStatScaleFactor = 3.03372322;
        public const double MageHealthStatExponent = 1.7;
        public const double MageHealthStatConstant = 6;
                            
        public const double MageManaStatScaleFactor = 6.073588;
        public const double MageManaStatExponent = 1.7;
        public const double MageManaStatConstant = 10;
                            
        public const double MageAttackStatScaleFactor = 0.147387363;
        public const double MageAttackStatExponent = 1.7;
        public const double MageAttackStatConstant = 1;
                            
        public const double MageDefenseStatScaleFactor = 0.147387363;
        public const double MageDefenseStatExponent = 1.7;
        public const double MageDefenseStatConstant = 1;
                           
        public const double MageLuckStatScaleFactor = 0.116681662;
        public const double MageLuckStatExponent = 1.7;
        public const double MageLuckStatConstant = 1;
                            
        public const double MageSpeedStatScaleFactor = 0.343903846;
        public const double MageSpeedStatExponent = 1.7;
        public const double MageSpeedStatConstant = 4;
                            
        public const double MageIntellectStatScaleFactor = 0.58;
        public const double MageIntellectStatExponent = 1.7;
        public const double MageIntellectStatConstant = 5;
                            
        public const double MageResistanceStatScaleFactor = 0.58;
        public const double MageResistanceStatExponent = 1.7;
        public const double MageResistanceStatConstant = 5;
        #endregion

        #region Thief Class Constants
        public const double ThiefHealthStatScaleFactor = 4.2558101;
        public const double ThiefHealthStatExponent = 1.7;
        public const double ThiefHealthStatConstant = 7;
                            
        public const double ThiefManaStatScaleFactor = 1.20366346;
        public const double ThiefManaStatExponent = 1.7;
        public const double ThiefManaStatConstant = 4;
                            
        public const double ThiefAttackStatScaleFactor = 0.343903846;
        public const double ThiefAttackStatExponent = 1.7;
        public const double ThiefAttackStatConstant = 4;
                            
        public const double ThiefDefenseStatScaleFactor = 0.343903846;
        public const double ThiefDefenseStatExponent = 1.7;
        public const double ThiefDefenseStatConstant = 4;
                            
        public const double ThiefLuckStatScaleFactor = 0.58;
        public const double ThiefLuckStatExponent = 1.7;
        public const double ThiefLuckStatConstant = 5;
                            
        public const double ThiefSpeedStatScaleFactor = 0.58;
        public const double ThiefSpeedStatExponent = 1.7;
        public const double ThiefSpeedStatConstant = 5;
                            
        public const double ThiefIntellectStatScaleFactor = 0.227222184;
        public const double ThiefIntellectStatExponent = 1.7;
        public const double ThiefIntellectStatConstant = 3;
                            
        public const double ThiefResistanceStatScaleFactor = 0.282492445;
        public const double ThiefResistanceStatExponent = 1.7;
        public const double ThiefResistanceStatConstant = 4;
        #endregion

        #region Experience Points Constants
        public const double ExperiencePointsScaleFactor = 2;
        public const double ExperiencePointsExponent = 2.5;
        public const double ExperiencePointsConstant = 10;
        #endregion

        #region Critical Chance Constants
        public const double CriticalChanceRateScaleFactor = 100.505051;
        public const double CriticalChanceRateConstant = 100;
        #endregion 

        #region Dodge Chance Constants
        public const double DodgeChanceRateScaleFactor = 100.505051;
        public const double DodgeChanceRateConstant = 100;
        #endregion
        #endregion

        #region Variables
        

        private int currentExperiencePoints;
        public int CurrentExperiencePoints
        {
            get
            {
                return currentExperiencePoints;
            }
            set
            {
                if (Level >= 20)
                {
                    currentExperiencePoints = 0;
                }
                else
                {
                    currentExperiencePoints = value;
                }
            }
        }

        public int MaximumExperiencePoints { get; set; }
        
        

        private int gold;
        public int Gold
        {
            get
            {
                return gold;
            }
            set
            {
                if(value < 0)
                {
                    gold = 0;
                }
                if(value > 10000)
                {
                    gold = 10000;
                }
                else
                {
                    gold = value;
                }
            }
        }

        public enum Class { Warrior = 1, Mage = 2, Thief = 3 }
        private Class PlayerClass;

        private GameStateMachine.GameState PlayerGameState = GameStateMachine.GameState.Battle;
        #endregion 

        #region Player Objects
        public Location CurrentLocation { get; set; }
        public Weapon CurrentWeapon { get; set; }
        public HeadEquipment CurrentHeadEquipment { get; set; }
        public ChestEquipment CurrentChestEquipment { get; set; }
        public LegEquipment CurrentLegEquipment { get; set; }
        public List<Quest> PlayerQuests = new List<Quest>();
        public List<InventoryItem> PlayerItemInventory = new List<InventoryItem>();
        public List<InventoryEquipment> PlayerEquipmentInventory = new List<InventoryEquipment>();
        public List<InventoryLoot> PlayerLootInventory = new List<InventoryLoot>();
        public List<Spell> PlayerSpells = new List<Spell>();
        #endregion 
        #endregion 

        #region Constructor
        public Player(int Level, string Name, Class playerClass) : base(1, Name, 1, 1, 1, 1, 1, 1, 1, 1)
        {
            this.Level = Level;
            this.MaximumExperiencePoints = (int)(Math.Round((ExperiencePointsScaleFactor * (Math.Pow(Level, ExperiencePointsExponent))) + ExperiencePointsConstant));
            this.CurrentExperiencePoints = 0;
            this.PlayerClass = playerClass;
            if(World.FindLocationByID(1) != null)
            {
                MoveTo(World.FindLocationByID(1));
            }

            switch (PlayerClass)
            {
                case Class.Warrior:
                    MaximumHealth = (int)(Math.Round((WarriorHealthStatScaleFactor * (Math.Pow(Level, WarriorHealthStatExponent))) + WarriorHealthStatConstant));
                    CurrentHealth = MaximumHealth;
                    MaximumMana = (int)(Math.Round((WarriorManaStatScaleFactor * (Math.Pow(Level, WarriorManaStatExponent))) + WarriorManaStatConstant));
                    CurrentMana = MaximumMana;
                    Attack = (int)(Math.Round((WarriorAttackStatScaleFactor * (Math.Pow(Level, WarriorAttackStatExponent))) + WarriorAttackStatConstant));
                    Defense = (int)(Math.Round((WarriorDefenseStatScaleFactor * (Math.Pow(Level, WarriorDefenseStatExponent))) + WarriorDefenseStatConstant));
                    Luck = (int)(Math.Round((WarriorLuckStatScaleFactor * (Math.Pow(Level, WarriorLuckStatExponent))) + WarriorLuckStatConstant));
                    Speed = (int)(Math.Round((WarriorSpeedStatScaleFactor * (Math.Pow(Level, WarriorSpeedStatExponent))) + WarriorSpeedStatConstant));
                    Intellect = (int)(Math.Round((WarriorIntellectStatScaleFactor * (Math.Pow(Level, WarriorIntellectStatExponent))) + WarriorIntellectStatConstant));
                    Resistance = (int)(Math.Round((WarriorResistanceStatScaleFactor * (Math.Pow(Level, WarriorResistanceStatExponent))) + WarriorResistanceStatConstant));
                    break;
                case Class.Mage:
                    MaximumHealth = (int)(Math.Round((MageHealthStatScaleFactor * (Math.Pow(Level, MageHealthStatExponent))) + MageHealthStatConstant));
                    CurrentHealth = MaximumHealth;
                    MaximumMana = (int)(Math.Round((MageManaStatScaleFactor * (Math.Pow(Level, MageManaStatExponent))) + MageManaStatConstant));
                    CurrentMana = MaximumMana;
                    Attack = (int)(Math.Round((MageAttackStatScaleFactor * (Math.Pow(Level, MageAttackStatExponent))) + MageAttackStatConstant));
                    Defense = (int)(Math.Round((MageDefenseStatScaleFactor * (Math.Pow(Level, MageDefenseStatExponent))) + MageDefenseStatConstant));
                    Luck = (int)(Math.Round((MageLuckStatScaleFactor * (Math.Pow(Level, MageLuckStatExponent))) + MageLuckStatConstant));
                    Speed = (int)(Math.Round((MageSpeedStatScaleFactor * (Math.Pow(Level, MageSpeedStatExponent))) + MageSpeedStatConstant));
                    Intellect = (int)(Math.Round((MageIntellectStatScaleFactor * (Math.Pow(Level, MageIntellectStatExponent))) + MageIntellectStatConstant));
                    Resistance = (int)(Math.Round((MageResistanceStatScaleFactor * (Math.Pow(Level, MageResistanceStatExponent))) + MageResistanceStatConstant));
                    break;
                case Class.Thief:
                    MaximumHealth = (int)(Math.Round((ThiefHealthStatScaleFactor * (Math.Pow(Level, ThiefHealthStatExponent))) + ThiefHealthStatConstant));
                    CurrentHealth = MaximumHealth;
                    MaximumMana = (int)(Math.Round((ThiefManaStatScaleFactor * (Math.Pow(Level, ThiefManaStatExponent))) + ThiefManaStatConstant));
                    CurrentMana = MaximumMana;
                    Attack = (int)(Math.Round((ThiefAttackStatScaleFactor * (Math.Pow(Level, ThiefAttackStatExponent))) + ThiefAttackStatConstant));
                    Defense = (int)(Math.Round((ThiefDefenseStatScaleFactor * (Math.Pow(Level, ThiefDefenseStatExponent))) + ThiefDefenseStatConstant));
                    Luck = (int)(Math.Round((ThiefLuckStatScaleFactor * (Math.Pow(Level, ThiefLuckStatExponent))) + ThiefLuckStatConstant));
                    Speed = (int)(Math.Round((ThiefSpeedStatScaleFactor * (Math.Pow(Level, ThiefSpeedStatExponent))) + ThiefSpeedStatConstant));
                    Intellect = (int)(Math.Round((ThiefIntellectStatScaleFactor * (Math.Pow(Level, ThiefIntellectStatExponent))) + ThiefIntellectStatConstant));
                    Resistance = (int)(Math.Round((ThiefResistanceStatScaleFactor * (Math.Pow(Level, ThiefResistanceStatExponent))) + ThiefResistanceStatConstant));
                    break;
                default:
                    throw new Exception("Error no class selected");
            }
            CriticalChanceRate = ((CriticalChanceRateScaleFactor * Luck) / (Luck + CriticalChanceRateConstant));
            DodgeChanceRate = ((DodgeChanceRateScaleFactor * Luck) / (Luck + DodgeChanceRateConstant));
        }
        #endregion

        #region Methods
        public void GainExperience(int experience)
        {
            CurrentExperiencePoints += experience;

            while(CurrentExperiencePoints >= MaximumExperiencePoints)
            {
                LevelUp();
                CurrentExperiencePoints -= MaximumExperiencePoints;
                MaximumExperiencePoints = (int)(Math.Round((ExperiencePointsScaleFactor * (Math.Pow(Level, ExperiencePointsExponent))) + ExperiencePointsConstant));
            }
        }

        //Make this class private so that it cannot be accessed outside the class it is 
        //dangerous to leave it public because experience wont get updated
        public void LevelUp()
        {
            switch (PlayerClass)
            {
                case Class.Warrior:
                    Level++;
                    MaximumHealth = (int)(Math.Round((WarriorHealthStatScaleFactor * (Math.Pow(Level, WarriorHealthStatExponent))) + WarriorHealthStatConstant));
                    CurrentHealth = MaximumHealth;
                    MaximumMana = (int)(Math.Round((WarriorManaStatScaleFactor * (Math.Pow(Level, WarriorManaStatExponent))) + WarriorManaStatConstant));
                    CurrentMana = MaximumMana;
                    Attack = (int)(Math.Round((WarriorAttackStatScaleFactor * (Math.Pow(Level, WarriorAttackStatExponent))) + WarriorAttackStatConstant));
                    Defense = (int)(Math.Round((WarriorDefenseStatScaleFactor * (Math.Pow(Level, WarriorDefenseStatExponent))) + WarriorDefenseStatConstant));
                    Luck = (int)(Math.Round((WarriorLuckStatScaleFactor * (Math.Pow(Level, WarriorLuckStatExponent))) + WarriorLuckStatConstant));
                    Speed = (int)(Math.Round((WarriorSpeedStatScaleFactor * (Math.Pow(Level, WarriorSpeedStatExponent))) + WarriorSpeedStatConstant));
                    Intellect = (int)(Math.Round((WarriorIntellectStatScaleFactor * (Math.Pow(Level, WarriorIntellectStatExponent))) + WarriorIntellectStatConstant));
                    Resistance = (int)(Math.Round((WarriorResistanceStatScaleFactor * (Math.Pow(Level, WarriorResistanceStatExponent))) + WarriorResistanceStatConstant));
                    break;
                case Class.Mage:
                    Level++;
                    MaximumHealth = (int)(Math.Round((MageHealthStatScaleFactor * (Math.Pow(Level, MageHealthStatExponent))) + MageHealthStatConstant));
                    CurrentHealth = MaximumHealth;
                    MaximumMana = (int)(Math.Round((MageManaStatScaleFactor * (Math.Pow(Level, MageManaStatExponent))) + MageManaStatConstant));
                    CurrentMana = MaximumMana;
                    Attack = (int)(Math.Round((MageAttackStatScaleFactor * (Math.Pow(Level, MageAttackStatExponent))) + MageAttackStatConstant));
                    Defense = (int)(Math.Round((MageDefenseStatScaleFactor * (Math.Pow(Level, MageDefenseStatExponent))) + MageDefenseStatConstant));
                    Luck = (int)(Math.Round((MageLuckStatScaleFactor * (Math.Pow(Level, MageLuckStatExponent))) + MageLuckStatConstant));
                    Speed = (int)(Math.Round((MageSpeedStatScaleFactor * (Math.Pow(Level, MageSpeedStatExponent))) + MageSpeedStatConstant));
                    Intellect = (int)(Math.Round((MageIntellectStatScaleFactor * (Math.Pow(Level, MageIntellectStatExponent))) + MageIntellectStatConstant));
                    Resistance = (int)(Math.Round((MageResistanceStatScaleFactor * (Math.Pow(Level, MageResistanceStatExponent))) + MageResistanceStatConstant));
                    break;
                case Class.Thief:
                    Level++;
                    MaximumHealth = (int)(Math.Round((ThiefHealthStatScaleFactor * (Math.Pow(Level, ThiefHealthStatExponent))) + ThiefHealthStatConstant));
                    CurrentHealth = MaximumHealth;
                    MaximumMana = (int)(Math.Round((ThiefManaStatScaleFactor * (Math.Pow(Level, ThiefManaStatExponent))) + ThiefManaStatConstant));
                    CurrentMana = MaximumMana;
                    Attack = (int)(Math.Round((ThiefAttackStatScaleFactor * (Math.Pow(Level, ThiefAttackStatExponent))) + ThiefAttackStatConstant));
                    Defense = (int)(Math.Round((ThiefDefenseStatScaleFactor * (Math.Pow(Level, ThiefDefenseStatExponent))) + ThiefDefenseStatConstant));
                    Luck = (int)(Math.Round((ThiefLuckStatScaleFactor * (Math.Pow(Level, ThiefLuckStatExponent))) + ThiefLuckStatConstant));
                    Speed = (int)(Math.Round((ThiefSpeedStatScaleFactor * (Math.Pow(Level, ThiefSpeedStatExponent))) + ThiefSpeedStatConstant));
                    Intellect = (int)(Math.Round((ThiefIntellectStatScaleFactor * (Math.Pow(Level, ThiefIntellectStatExponent))) + ThiefIntellectStatConstant));
                    Resistance = (int)(Math.Round((ThiefResistanceStatScaleFactor * (Math.Pow(Level, ThiefResistanceStatExponent))) + ThiefResistanceStatConstant));
                    break;
                default:
                    throw new Exception("Error no class selected");
            }
            CriticalChanceRate = ((CriticalChanceRateScaleFactor * Luck) / (Luck + CriticalChanceRateConstant));
            DodgeChanceRate = ((DodgeChanceRateScaleFactor * Luck) / (Luck + DodgeChanceRateConstant));
        }

        public void UseItem(Item item)
        {
            if (item.GetType() == typeof(HealthReplenishingItem))
            {

            }
        }

        //Make this private it never needs to be accessed outside the player class
        public void MoveTo(Location newLocation)
        {
            CurrentLocation = newLocation;
            Console.WriteLine(CurrentLocation.ToString());
            if (RandomNumberGenerator.RandomNumberBetween(0, 100) < 33)
            {
                //Player.Battle(CurrentLocation.EnemiesInLocation[RandomNumberGenerator.RandomNumberBetween(0, CurrentLocation.EnemiesInLocation.Count - 1)]);
            }
        }

        public void MoveNorth()
        {
            if (CurrentLocation.LocationToTheNorth != null)
            {
                MoveTo(CurrentLocation.LocationToTheNorth);
            }
        }

        public void MoveSouth()
        {
            if (CurrentLocation.LocationToTheSouth != null)
            {
                MoveTo(CurrentLocation.LocationToTheSouth);
            }
        }

        public void MoveWest()
        {
            if (CurrentLocation.LocationToTheWest != null)
            {
                MoveTo(CurrentLocation.LocationToTheWest);
            }
        }

        public void MoveEast()
        {
            if (CurrentLocation.LocationToTheEast != null)
            {
                MoveTo(CurrentLocation.LocationToTheEast);
            }
        }

        public void UseItem()
        {

        }

        public void AttackCommand(Enemy enemy)
        {
            int damage = 0;

            //If the enemy would dodge the attack do not calculate damage
            if (RandomNumberGenerator.RandomNumberBetween(0, 100) <= enemy.DodgeChanceRate)
            {
                return;
            }

            //If the player would critical strike the enemy then calculate the damage accordingly
            if(RandomNumberGenerator.RandomNumberBetween(0, 100) <= CriticalChanceRate)
            {
                //Double the damage
                damage = (((Attack * Attack) / (Attack + enemy.Defense)) * 10) * 2;
            }
            else
            {
                damage = ((Attack * Attack) / (Attack + enemy.Defense)) * 10;
            }
        }

        public void SpellCommand(Enemy enemy)
        {
            int spellDamage = 0;

            //If the enemy would dodge the attack do not calculate spell damage
            if (RandomNumberGenerator.RandomNumberBetween(0, 100) <= enemy.DodgeChanceRate)
            {
                return;
            }

            //If the player would critical strike the enemy then calculate the spell damage accordingly
            if (RandomNumberGenerator.RandomNumberBetween(0, 100) <= CriticalChanceRate)
            {
                //Double the spell damage
                spellDamage = (((Intellect * Intellect) / (Intellect + enemy.Resistance)) * 10) * 2;
            }
            else
            {
                spellDamage = ((Intellect * Intellect) / (Intellect + enemy.Resistance)) * 10;
            }
        }

        public bool RunCommand(Enemy enemy)
        {
            if(RandomNumberGenerator.RandomNumberBetween(0, 100) < Speed + Luck)
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            string info = "";

            info += ("Level: " + Level.ToString() + "\n");
            info += ("Class: " + PlayerClass.ToString() + "\n");
            info += ("Current Experience: " + CurrentExperiencePoints.ToString() + "\n");
            info += ("Maximum Experience: " + MaximumExperiencePoints.ToString() + "\n");
            info += ("Critical Chance: " + ((int)CriticalChanceRate).ToString() + "%\n");
            info += ("Dodge Chance: " + ((int)DodgeChanceRate).ToString() + "%\n");
            info += base.ToString();

            return info;
        }
        #endregion
    }
}