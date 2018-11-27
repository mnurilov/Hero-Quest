using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Player : FightingUnit
    {
        //Warrior Class Constants
        private const double WarriorHealthStatScaleFactor = 6.073588;
        private const double WarriorHealthStatExponent = 1.7;
        private const double WarriorHealthStatConstant = 10;

        private const double WarriorManaStatScaleFactor = 0.583;
        private const double WarriorManaStatExponent = 1.7;
        private const double WarriorManaStatConstant = 5;

        private const double WarriorStrengthStatScaleFactor = 0.58;
        private const double WarriorStrengthStatExponent = 1.7;
        private const double WarriorStrengthStatConstant = 5;

        private const double WarriorDefenseStatScaleFactor = 0.58;
        private const double WarriorDefenseStatExponent = 1.7;
        private const double WarriorDefenseStatConstant = 5;

        private const double WarriorLuckStatScaleFactor = 0.116681662;
        private const double WarriorLuckStatExponent = 1.7;
        private const double WarriorLuckStatConstant = 1;

        private const double WarriorSpeedStatScaleFactor = 0.227222184;
        private const double WarriorSpeedStatExponent = 1.7;
        private const double WarriorSpeedStatConstant = 3;

        private const double WarriorIntellectStatScaleFactor = 0.147387363;
        private const double WarriorIntellectStatExponent = 1.7;
        private const double WarriorIntellectStatConstant = 1;

        private const double WarriorResistanceStatScaleFactor = 0.147387363;
        private const double WarriorResistanceStatExponent = 1.7;
        private const double WarriorResistanceStatConstant = 1;


        //Mage Class Constants
        private const double MageHealthStatScaleFactor = 3.03372322;
        private const double MageHealthStatExponent = 1.7;
        private const double MageHealthStatConstant = 6;

        private const double MageManaStatScaleFactor = 6.073588;
        private const double MageManaStatExponent = 1.7;
        private const double MageManaStatConstant = 10;

        private const double MageStrengthStatScaleFactor = 0.147387363;
        private const double MageStrengthStatExponent = 1.7;
        private const double MageStrengthStatConstant = 1;

        private const double MageDefenseStatScaleFactor = 0.147387363;
        private const double MageDefenseStatExponent = 1.7;
        private const double MageDefenseStatConstant = 1;

        private const double MageLuckStatScaleFactor = 0.116681662;
        private const double MageLuckStatExponent = 1.7;
        private const double MageLuckStatConstant = 1;

        private const double MageSpeedStatScaleFactor = 0.343903846;
        private const double MageSpeedStatExponent = 1.7;
        private const double MageSpeedStatConstant = 4;

        private const double MageIntellectStatScaleFactor = 0.58;
        private const double MageIntellectStatExponent = 1.7;
        private const double MageIntellectStatConstant = 5;
        
        private const double MageResistanceStatScaleFactor = 0.58;
        private const double MageResistanceStatExponent = 1.7;
        private const double MageResistanceStatConstant = 5;


        //Thief Class Constants
        private const double ThiefHealthStatScaleFactor = 4.2558101;
        private const double ThiefHealthStatExponent = 1.7;
        private const double ThiefHealthStatConstant = 7;

        private const double ThiefManaStatScaleFactor = 1.20366346;
        private const double ThiefManaStatExponent = 1.7;
        private const double ThiefManaStatConstant = 4;

        private const double ThiefStrengthStatScaleFactor = 0.343903846;
        private const double ThiefStrengthStatExponent = 1.7;
        private const double ThiefStrengthStatConstant = 4;

        private const double ThiefDefenseStatScaleFactor = 0.343903846;
        private const double ThiefDefenseStatExponent = 1.7;
        private const double ThiefDefenseStatConstant = 4;

        private const double ThiefLuckStatScaleFactor = 0.58;
        private const double ThiefLuckStatExponent = 1.7;
        private const double ThiefLuckStatConstant = 5;

        private const double ThiefSpeedStatScaleFactor = 0.58;
        private const double ThiefSpeedStatExponent = 1.7;
        private const double ThiefSpeedStatConstant = 5;

        private const double ThiefIntellectStatScaleFactor = 0.227222184;
        private const double ThiefIntellectStatExponent = 1.7;
        private const double ThiefIntellectStatConstant = 3;

        private const double ThiefResistanceStatScaleFactor = 0.282492445;
        private const double ThiefResistanceStatExponent = 1.7;
        private const double ThiefResistanceStatConstant = 4;


        //Experience Points Constants
        private const double ExperiencePointsScaleFactor = 2;
        private const double ExperiencePointsExponent = 2.5;
        private const double ExperiencePointsConstant = 10;


        //Critical Chance Constants
        private const double CriticalChanceRateScaleFactor = 100.505051;
        private const double CriticalChanceRateConstant = 100;


        //Dodge Change Constants
        private const double DodgeChanceRateScaleFactor = 100.505051;
        private const double DodgeChanceRateConstant = 100;


        //Gold Constants
        private const int GoldCap = 10000;


        //Level Constants
        private const int MinimumLevel = 1;
        private const int MaximumLevel = 20;
        
        private int level;
        public int Level
        {
            get
            {
                return level;
            }
            set
            {
                if(value < MinimumLevel)
                {
                    level = MinimumLevel;
                }
                else if(value > MaximumLevel)
                {
                    level = MaximumLevel;
                }
                else
                {
                    level = value;
                }
            }
        }

        private int currentExperiencePoints;
        public int CurrentExperiencePoints
        {
            get
            {
                return currentExperiencePoints;
            }
            set
            {
                if(level == MaximumLevel)
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
                if(value > GoldCap)
                {
                    gold = GoldCap;
                }
                else
                {
                    gold = value;
                }
            }
        }

        //Player Character Class
        public enum Class { Warrior, Mage, Thief }
        private Class PlayerClass;

        public Class GetClass()
        {
            return PlayerClass;
        }
        
        public Location CurrentLocation { get; set; }

        //Equipment
        public Weapon CurrentWeapon { get; set; }
        public SideArm CurrentSideArm { get; set; }
        public HeadEquipment CurrentHeadEquipment { get; set; }
        public ChestEquipment CurrentChestEquipment { get; set; }
        public LegEquipment CurrentLegEquipment { get; set; }

        //Inventory
        public List<Quest> PlayerQuests = new List<Quest>();
        public List<Equipment> PlayerEquipments = new List<Equipment>();
        //Key is the item, Value is the quantity of the item
        public Dictionary<Item, int> PlayerItems = new Dictionary<Item, int>();
        public List<Spell> PlayerSpells = new List<Spell>();


        public Player(int level, string name, Class playerClass) : base(name, 1, 1, 1, 1, 1, 1, 1, 1, 1.0, 1.0)
        {
            this.Level = level;
            this.MaximumExperiencePoints = GetUpdatedMaximumExperience();
            this.CurrentExperiencePoints = 0;
            this.PlayerClass = playerClass;

            UpdatePlayerStats();

            //Set the starting location of the player
            if (World.FindLocationByID(1) != null)
            {
                MoveTo(World.FindLocationByID(1));
            }
            else
            {
                throw new Exception("Player's starting location cannot be set");
            }
        }


        //Leveling, Experience, and Stats Functions
        private void UpdateWarriorStats()
        {
            MaximumHealth = (int)(Math.Round((WarriorHealthStatScaleFactor * (Math.Pow(Level, WarriorHealthStatExponent))) + WarriorHealthStatConstant));
            CurrentHealth = MaximumHealth;
            MaximumMana = (int)(Math.Round((WarriorManaStatScaleFactor * (Math.Pow(Level, WarriorManaStatExponent))) + WarriorManaStatConstant));
            CurrentMana = MaximumMana;
            Strength = (int)(Math.Round((WarriorStrengthStatScaleFactor * (Math.Pow(Level, WarriorStrengthStatExponent))) + WarriorStrengthStatConstant));
            Defense = (int)(Math.Round((WarriorDefenseStatScaleFactor * (Math.Pow(Level, WarriorDefenseStatExponent))) + WarriorDefenseStatConstant));
            Luck = (int)(Math.Round((WarriorLuckStatScaleFactor * (Math.Pow(Level, WarriorLuckStatExponent))) + WarriorLuckStatConstant));
            Speed = (int)(Math.Round((WarriorSpeedStatScaleFactor * (Math.Pow(Level, WarriorSpeedStatExponent))) + WarriorSpeedStatConstant));
            Intellect = (int)(Math.Round((WarriorIntellectStatScaleFactor * (Math.Pow(Level, WarriorIntellectStatExponent))) + WarriorIntellectStatConstant));
            Resistance = (int)(Math.Round((WarriorResistanceStatScaleFactor * (Math.Pow(Level, WarriorResistanceStatExponent))) + WarriorResistanceStatConstant));
        }

        private void UpdateMageStats()
        {
            MaximumHealth = (int)(Math.Round((MageHealthStatScaleFactor * (Math.Pow(Level, MageHealthStatExponent))) + MageHealthStatConstant));
            CurrentHealth = MaximumHealth;
            MaximumMana = (int)(Math.Round((MageManaStatScaleFactor * (Math.Pow(Level, MageManaStatExponent))) + MageManaStatConstant));
            CurrentMana = MaximumMana;
            Strength = (int)(Math.Round((MageStrengthStatScaleFactor * (Math.Pow(Level, MageStrengthStatExponent))) + MageStrengthStatConstant));
            Defense = (int)(Math.Round((MageDefenseStatScaleFactor * (Math.Pow(Level, MageDefenseStatExponent))) + MageDefenseStatConstant));
            Luck = (int)(Math.Round((MageLuckStatScaleFactor * (Math.Pow(Level, MageLuckStatExponent))) + MageLuckStatConstant));
            Speed = (int)(Math.Round((MageSpeedStatScaleFactor * (Math.Pow(Level, MageSpeedStatExponent))) + MageSpeedStatConstant));
            Intellect = (int)(Math.Round((MageIntellectStatScaleFactor * (Math.Pow(Level, MageIntellectStatExponent))) + MageIntellectStatConstant));
            Resistance = (int)(Math.Round((MageResistanceStatScaleFactor * (Math.Pow(Level, MageResistanceStatExponent))) + MageResistanceStatConstant));
        }

        private void UpdateThiefStats()
        {
            MaximumHealth = (int)(Math.Round((ThiefHealthStatScaleFactor * (Math.Pow(Level, ThiefHealthStatExponent))) + ThiefHealthStatConstant));
            CurrentHealth = MaximumHealth;
            MaximumMana = (int)(Math.Round((ThiefManaStatScaleFactor * (Math.Pow(Level, ThiefManaStatExponent))) + ThiefManaStatConstant));
            CurrentMana = MaximumMana;
            Strength = (int)(Math.Round((ThiefStrengthStatScaleFactor * (Math.Pow(Level, ThiefStrengthStatExponent))) + ThiefStrengthStatConstant));
            Defense = (int)(Math.Round((ThiefDefenseStatScaleFactor * (Math.Pow(Level, ThiefDefenseStatExponent))) + ThiefDefenseStatConstant));
            Luck = (int)(Math.Round((ThiefLuckStatScaleFactor * (Math.Pow(Level, ThiefLuckStatExponent))) + ThiefLuckStatConstant));
            Speed = (int)(Math.Round((ThiefSpeedStatScaleFactor * (Math.Pow(Level, ThiefSpeedStatExponent))) + ThiefSpeedStatConstant));
            Intellect = (int)(Math.Round((ThiefIntellectStatScaleFactor * (Math.Pow(Level, ThiefIntellectStatExponent))) + ThiefIntellectStatConstant));
            Resistance = (int)(Math.Round((ThiefResistanceStatScaleFactor * (Math.Pow(Level, ThiefResistanceStatExponent))) + ThiefResistanceStatConstant));
        }

        public void UpdatePlayerStats()
        {
            switch (PlayerClass)
            {
                case Class.Warrior:
                    UpdateWarriorStats();
                    break;
                case Class.Mage:
                    UpdateMageStats();
                    break;
                case Class.Thief:
                    UpdateThiefStats();
                    break;
                default:
                    throw new Exception("Error no class selected");
            }
            CriticalChanceRate = ((CriticalChanceRateScaleFactor * Luck) / (Luck + CriticalChanceRateConstant));
            DodgeChanceRate = ((DodgeChanceRateScaleFactor * Luck) / (Luck + DodgeChanceRateConstant));
        }

        private int GetUpdatedMaximumExperience() 
        {
            return (int)(Math.Round((ExperiencePointsScaleFactor * (Math.Pow(Level, ExperiencePointsExponent))) + ExperiencePointsConstant));
        }

        public void GainExperience(int experience)
        {
            CurrentExperiencePoints += experience;

            while(CurrentExperiencePoints >= MaximumExperiencePoints)
            {
                LevelUp();
                CurrentExperiencePoints -= MaximumExperiencePoints;
                MaximumExperiencePoints = GetUpdatedMaximumExperience();
            }
        }

        private void LevelUp()
        {
            Level++;
            UpdatePlayerStats();
        }

        public void GainEnemyRewards(Enemy enemy)
        {
            Gold += enemy.RewardGold;
            GainExperience(enemy.RewardExperiencePoints);
        }

        //Check is if is the player's turn, return true if it is
        public bool IsPlayerTurn(Enemy enemy)
        {
            //Determines player's turn based on speed
            if (Speed > enemy.Speed)
            {
                return true;
            }
            else if (Speed < enemy.Speed)
            {
                return false;
            }
            //If the speeds are equal decide randomly
            else
            {
                int turnDecider = RandomNumberGenerator.RandomNumberBetween(1, 100);
                if (turnDecider > 50)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }


        //Movement Functions
        //Moves the player to a different location
        private void MoveTo(Location newLocation)
        {
            CurrentLocation = newLocation;
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


        //Battle Functions
        public int Attack(Enemy enemy, ref GameSession.BattleResult battleResult)
        {
            int damage = 0;

            //If the enemy would dodge the attack do not calculate damage
            if (RandomNumberGenerator.RandomNumberBetween(1, 100) <= enemy.DodgeChanceRate)
            {
                battleResult = GameSession.BattleResult.Missed;
                return 0;
            }

            //If the player would critical strike the enemy then calculate the damage accordingly
            if(RandomNumberGenerator.RandomNumberBetween(1, 100) <= CriticalChanceRate)
            {
                //Double the damage
                battleResult = GameSession.BattleResult.Critical;
                damage = (((Strength * Strength) / (Strength + enemy.Defense)) * 2) * 2;
            }
            //Else the player would normally strike the enemy then calculate the damage accordingly
            else
            {
                battleResult = GameSession.BattleResult.Normal;
                damage = ((Strength * Strength) / (Strength + enemy.Defense)) * 2;
            }

            return damage;
        }

        public int CastSpell(Enemy enemy, DamageSpell damageSpell, ref GameSession.BattleResult battleResult)
        {
            int spellDamage = 0;

            //If the enemy would dodge the attack do not calculate spell damage
            if (RandomNumberGenerator.RandomNumberBetween(1, 100) <= enemy.DodgeChanceRate)
            {
                battleResult = GameSession.BattleResult.Missed;
                return 0;
            }

            //If the player would critical strike the enemy then calculate the spell damage accordingly
            if (RandomNumberGenerator.RandomNumberBetween(1, 100) <= CriticalChanceRate)
            {
                //Double the spell damage
                battleResult = GameSession.BattleResult.Critical;
                spellDamage = (((Intellect + damageSpell.DamageAmount) / (Intellect + enemy.Resistance) * 2) * 2);
            }
            //Else the player would normally strike the enemy then calculate the spell damage accordingly
            else
            {
                battleResult = GameSession.BattleResult.Normal;
                spellDamage = ((Intellect + damageSpell.DamageAmount) / (Intellect + enemy.Resistance) * 2);
            }

            return spellDamage;
        }

        //Determines if the player can escape FIX THIS TO HAVE IT BE AFFECTED BY SPEED OF BOTH PLAYER AND ENEM
        public bool Run(Enemy enemy)
        {
            if (RandomNumberGenerator.RandomNumberBetween(0, 99) < 50)
            {
                return true;
            }

            return false;
        }


        //Shop Functions
        //Returns true if player successfully bought the item, false otherwise
        public bool BuyItem(Item item)
        {
            if(Gold >= item.GoldValue)
            {
                //If the player already has that item increase its quantity
                if (PlayerItems.ContainsKey(item))
                {
                    PlayerItems[item]++;
                }
                //Otherwise add the item to the players inventory
                else
                {
                    PlayerItems.Add(item, 1);
                }
                
                Gold -= item.GoldValue;

                return true;
            }
            else
            {
                return false;
            }
        }

        //Returns true if player successfully bought the equipment, false otherwise
        public bool BuyEquipment(Equipment equipment)
        {
            if (Gold >= equipment.GoldValue)
            {
                //If the player already has that item he does not need to buy another
                if (PlayerEquipments.Contains(equipment))
                {
                    return false;
                }
                //If the player doesnt have the item then add it to the player's equipment inventory
                else
                {
                    PlayerEquipments.Add(equipment);
                    Gold -= equipment.GoldValue;
                    return true;
                }
            }
            else
            {
                return false;
            }
        }

        //Returns true if player successfully bought the spell, false otherwise
        public bool BuySpell(Spell spell)
        {
            if (Gold >= spell.GoldValue)
            {
                //If the player already has that spell he does not need to buy another
                if (PlayerSpells.Contains(spell))
                {
                    return false;
                }
                //If the player doesnt have the item then add it to the player's equipment inventory
                else
                {
                    PlayerSpells.Add(spell);
                    Gold -= spell.GoldValue;
                    return true;
                }
            }
            else
            {
                return false;
            }
        }


        public bool Equip(Equipment equipment)
        {
            if(equipment is HeadEquipment)
            {
                CurrentHeadEquipment = equipment as HeadEquipment;
                return true;
            }
            else if(equipment is ChestEquipment)
            {
                CurrentChestEquipment = equipment as ChestEquipment;
                return true;
            }
            else if(equipment is LegEquipment)
            {
                CurrentLegEquipment = equipment as LegEquipment;
                return true;
            }
            else if(equipment is Weapon)
            {
                if(equipment is Sword)
                {
                    if(PlayerClass == Class.Warrior)
                    {
                        CurrentWeapon = equipment as Sword;
                        return true;
                    }
                }
                else if(equipment is Staff)
                {
                    if (PlayerClass == Class.Mage)
                    {
                        CurrentWeapon = equipment as Staff;
                        return true;
                    }
                }
                else if(equipment is Dagger)
                {
                    if (PlayerClass == Class.Thief)
                    {
                        CurrentWeapon = equipment as Dagger;
                        return true;
                    }
                }
            }
            else if (equipment is SideArm)
            {
                if(equipment is Shield)
                {
                    if (PlayerClass == Class.Warrior)
                    {
                        CurrentSideArm = equipment as Shield;
                        return true;
                    }
                }
                else if (equipment is Tome)
                {
                    if (PlayerClass == Class.Mage)
                    {
                        CurrentSideArm = equipment as Tome;
                        return true;
                    }
                }
                else if (equipment is ParryingDagger)
                {
                    if (PlayerClass == Class.Thief)
                    {
                        CurrentSideArm = equipment as ParryingDagger;
                        return true;
                    }
                }
            }
            return false;
        }


        //public void DeEquip()

        
        public override string ToString()
        {
            string info = "";

            info += ("Level: " + Level.ToString() + "\n");
            info += ("Class: " + PlayerClass.ToString() + "\n");
            info += ("Gold: " + Gold.ToString() + "\n");
            info += ("Current Experience: " + CurrentExperiencePoints.ToString() + "\n");
            info += ("Maximum Experience: " + MaximumExperiencePoints.ToString() + "\n");
            info += base.ToString();

            return info;
        }
    }
}
