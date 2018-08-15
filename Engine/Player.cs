using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Player : FightingUnit
    {
        #region Variable

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

        private int level;
        public int Level 
        { 
            get
            {
                return level;
            } 
            set 
            { 
                if (value > 20)
                {

                    level = 20;
                }
                else if (value < 1)
                {
                    level = 1;
                }
                else
                {
                    level = value;
                }
            }
        }
        public int CurrentExperience { get; set; }
        public int MaximumExperience { get; set; }
        public Location CurrentLocation { get; set; }
        public Weapon CurrentWeapon { get; set; }
        public HeadEquipment CurrentHeadEquipment { get; set; }
        public ChestEquipment CurrentChestEquipment { get; set; }
        public LegEquipment CurrentLegEquipment { get; set; }

        public enum Class {Warrior = 1, Mage = 2, Thief = 3}
        public Class PlayerClass;
        #endregion 

        #region Constructor
        public Player(int maximumHealth, int maximumMana, int attack, int defense, int luck,
            int speed, int intellect, int resistance, Class playerClass, int level = 1) : base(maximumHealth, maximumMana,
                attack, defense, luck, speed, intellect, resistance)
        {
            this.Level = level;
            this.MaximumExperience = (int)(10 + (Math.Pow(Level, 3)));
            this.CurrentExperience = 0;
            this.PlayerClass = playerClass;

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
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            string stats = "";

            stats += ("Level: " + Level.ToString() + "\n");
            stats += ("Class: " + PlayerClass.ToString() + "\n");
            stats += ("Current Experience: " + CurrentExperience.ToString() + "\n");
            stats += ("Maximum Experience: " + MaximumExperience.ToString() + "\n");
            stats += base.ToString();

            return stats;
        }

        public void GainExperience(int experience)
        {
            CurrentExperience += experience;

            while(CurrentExperience >= MaximumExperience)
            {
                LevelUp();
                CurrentExperience -= MaximumExperience;
                MaximumExperience = (int)(10 + (Math.Pow(Level, 3)));
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
        }
        #endregion
    }
}
