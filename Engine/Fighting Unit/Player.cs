using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Player
    {
        //<----------Warrior Class Constants---------->
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

        //<----------Mage Class Constants---------->
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

        //<----------Thief Class Constants---------->
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

        //<----------Experience Points Constants----------->
        private const double ExperiencePointsScaleFactor = 2;
        private const double ExperiencePointsExponent = 2.5;
        private const double ExperiencePointsConstant = 10;

        //<----------Critical Chance Constants----------->
        private const double CriticalChanceRateScaleFactor = 100.505051;
        private const double CriticalChanceRateConstant = 100;

        //<----------Critical Damage Constants----------->
        private const double CriticalDamageModifier = 2;

        //<----------Dodge Chance Constants----------->
        private const double DodgeChanceRateScaleFactor = 100.505051;
        private const double DodgeChanceRateConstant = 100;

        //<----------Gold Constants----------->
        private const int GoldCap = 100000;

        //<----------Level Constants----------->
        private const int MinimumLevel = 1;
        private const int MaximumLevel = 20;

        //<----------Empower Constants---------->
        private const int EmpoweredModifier = 2;
        private const int EmpowerCounterCap = 4;

        //<----------Greed Constants---------->
        private const double GreedModifier = 0.7;

        //<----------Stats----------->
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
        private Class playerClass;

        public Class GetClass()
        {
            return playerClass;
        }

        public string Name { get; set; }

        private int currentHealth;
        public int CurrentHealth
        {
            get
            {
                return currentHealth;
            }
            set
            {
                if (value > TotalMaximumHealth)
                {
                    currentHealth = TotalMaximumHealth;
                }
                else if (value < 0)
                {
                    currentHealth = 0;
                }
                else
                {
                    currentHealth = value;
                }
            }
        }

        private int currentMana;
        public int CurrentMana
        {
            get
            {
                return currentMana;
            }
            set
            {
                if (value > TotalMaximumMana)
                {
                    currentMana = TotalMaximumMana;
                }
                else if (value < 0)
                {
                    currentMana = 0;
                }
                else
                {
                    currentMana = value;
                }
            }
        }

        //<----------Base stats---------->
        public int BaseMaximumHealth { get; set; }
        public int BaseMaximumMana { get; set; }
        public int BaseStrength { get; set; }
        public int BaseDefense { get; set; }
        public int BaseLuck { get; set; }
        public int BaseSpeed { get; set; }
        public int BaseIntellect { get; set; }
        public int BaseResistance { get; set; }

        //<----------Total stats after equipment bonuses are calculated---------->
        public int TotalMaximumHealth { get; set; }
        public int TotalMaximumMana { get; set; }
        public int TotalStrength { get; set; }
        public int TotalDefense { get; set; }
        public int TotalLuck { get; set; }
        public int TotalSpeed { get; set; }
        public int TotalIntellect { get; set; }
        public int TotalResistance { get; set; }

        public double CriticalChanceRate { get; set; }
        public double DodgeChanceRate { get; set; }

        public Location CurrentLocation { get; set; }

        //<---------Inventory---------->
        //Key is the item, Value is the quantity of the item
        public Dictionary<Item, int> PlayerItems = new Dictionary<Item, int>();
        public List<Equipment> PlayerEquipments = new List<Equipment>();
        public List<Spell> PlayerSpells = new List<Spell>();
        public List<Quest> PlayerQuests = new List<Quest>();

        //<---------Equipment---------->
        public Weapon CurrentWeapon { get; set; }
        public SideArm CurrentSideArm { get; set; }
        public HeadEquipment CurrentHeadEquipment { get; set; }
        public ChestEquipment CurrentChestEquipment { get; set; }
        public LegEquipment CurrentLegEquipment { get; set; }

        //<----------Empower Variables---------->
        private int empowerCounter;
        public int EmpowerCounter
        {
            get
            {
                return empowerCounter;
            }
            set
            {
                if (value >= EmpowerCounterCap)
                {
                    empowerCounter = EmpowerCounterCap;
                }
                else if (value < 0)
                {
                    empowerCounter = 0;
                }
                else
                {
                    empowerCounter = value;
                }
            }
        }
        public bool Empowered;

        //<----------Greed Variables---------->
        public bool Greed;


        public Player(int level, string name, Class playerClass)
        {
            this.Level = level;
            this.Name = name;
            this.playerClass = playerClass;
            this.CurrentExperiencePoints = 0;
            this.MaximumExperiencePoints = GetUpdatedMaximumExperience();
            
            Empowered = false;
            Greed = false;

            UpdateBaseStats();
            ResetTotalStats();

            //After properly setting up the players base and total stats only now can we set his current health and mana
            CurrentHealth = TotalMaximumHealth;
            CurrentMana = TotalMaximumMana;
            
            //After setting up total stats update critical and dodge rates
            UpdateCriticalAndDodge();

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


        //<----------Leveling, Experience, and Stats Functions---------->
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
            UpdateBaseStats();
            CalculateAllTotalStats();
        }

        private void CalculateAllTotalStats()
        {
            //Reset the total stats back to base stats numbers
            ResetTotalStats();

            if(CurrentHeadEquipment != null)
            {
                UpdateTotalStats(CurrentHeadEquipment);
            }
            if(CurrentChestEquipment != null)
            {
                UpdateTotalStats(CurrentChestEquipment);
            }
            if(CurrentLegEquipment != null)
            {
                UpdateTotalStats(CurrentLegEquipment);
            }
            if(CurrentWeapon != null)
            {
                UpdateTotalStats(CurrentWeapon);
            }
            if(CurrentSideArm != null)
            {
                UpdateTotalStats(CurrentSideArm);
            }

            UpdateCriticalAndDodge();
        }

        private void ResetTotalStats()
        {
            TotalMaximumHealth = BaseMaximumHealth;
            TotalMaximumMana = BaseMaximumMana;
            TotalStrength = BaseStrength;
            TotalDefense = BaseDefense;
            TotalLuck = BaseLuck;
            TotalSpeed = BaseSpeed;
            TotalIntellect = BaseIntellect;
            TotalResistance = BaseResistance;
        }

        private void UpdateTotalStats(Equipment equipment)
        {
            TotalMaximumHealth += equipment.HealthBonus;
            TotalMaximumMana += equipment.ManaBonus;
            TotalStrength += equipment.StrengthBonus;
            TotalDefense += equipment.DefenseBonus;
            TotalLuck += equipment.LuckBonus;
            TotalSpeed += equipment.SpeedBonus;
            TotalIntellect += equipment.IntellectBonus;
            TotalResistance += equipment.ResistanceBonus;
        }

        private void UpdateCriticalAndDodge()
        {
            CriticalChanceRate = ((CriticalChanceRateScaleFactor * TotalLuck) / (TotalLuck + CriticalChanceRateConstant));
            DodgeChanceRate = ((DodgeChanceRateScaleFactor * TotalLuck) / (TotalLuck + DodgeChanceRateConstant));
        }

        private int GetUpdatedMaximumExperience() 
        {
            return (int)(Math.Round((ExperiencePointsScaleFactor * (Math.Pow(Level, ExperiencePointsExponent))) + ExperiencePointsConstant));
        }

        private void UpdateBaseStats()
        {
            switch (playerClass)
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
        }

        private void UpdateWarriorStats()
        {
            BaseMaximumHealth = (int)(Math.Round((WarriorHealthStatScaleFactor * (Math.Pow(Level, WarriorHealthStatExponent))) + WarriorHealthStatConstant));
            BaseMaximumMana = (int)(Math.Round((WarriorManaStatScaleFactor * (Math.Pow(Level, WarriorManaStatExponent))) + WarriorManaStatConstant));
            BaseStrength = (int)(Math.Round((WarriorStrengthStatScaleFactor * (Math.Pow(Level, WarriorStrengthStatExponent))) + WarriorStrengthStatConstant));
            BaseDefense = (int)(Math.Round((WarriorDefenseStatScaleFactor * (Math.Pow(Level, WarriorDefenseStatExponent))) + WarriorDefenseStatConstant));
            BaseLuck = (int)(Math.Round((WarriorLuckStatScaleFactor * (Math.Pow(Level, WarriorLuckStatExponent))) + WarriorLuckStatConstant));
            BaseSpeed = (int)(Math.Round((WarriorSpeedStatScaleFactor * (Math.Pow(Level, WarriorSpeedStatExponent))) + WarriorSpeedStatConstant));
            BaseIntellect = (int)(Math.Round((WarriorIntellectStatScaleFactor * (Math.Pow(Level, WarriorIntellectStatExponent))) + WarriorIntellectStatConstant));
            BaseResistance = (int)(Math.Round((WarriorResistanceStatScaleFactor * (Math.Pow(Level, WarriorResistanceStatExponent))) + WarriorResistanceStatConstant));
        }

        private void UpdateMageStats()
        {
            BaseMaximumHealth = (int)(Math.Round((MageHealthStatScaleFactor * (Math.Pow(Level, MageHealthStatExponent))) + MageHealthStatConstant));
            BaseMaximumMana = (int)(Math.Round((MageManaStatScaleFactor * (Math.Pow(Level, MageManaStatExponent))) + MageManaStatConstant));
            BaseStrength = (int)(Math.Round((MageStrengthStatScaleFactor * (Math.Pow(Level, MageStrengthStatExponent))) + MageStrengthStatConstant));
            BaseDefense = (int)(Math.Round((MageDefenseStatScaleFactor * (Math.Pow(Level, MageDefenseStatExponent))) + MageDefenseStatConstant));
            BaseLuck = (int)(Math.Round((MageLuckStatScaleFactor * (Math.Pow(Level, MageLuckStatExponent))) + MageLuckStatConstant));
            BaseSpeed = (int)(Math.Round((MageSpeedStatScaleFactor * (Math.Pow(Level, MageSpeedStatExponent))) + MageSpeedStatConstant));
            BaseIntellect = (int)(Math.Round((MageIntellectStatScaleFactor * (Math.Pow(Level, MageIntellectStatExponent))) + MageIntellectStatConstant));
            BaseResistance = (int)(Math.Round((MageResistanceStatScaleFactor * (Math.Pow(Level, MageResistanceStatExponent))) + MageResistanceStatConstant));
        }

        private void UpdateThiefStats()
        {
            BaseMaximumHealth = (int)(Math.Round((ThiefHealthStatScaleFactor * (Math.Pow(Level, ThiefHealthStatExponent))) + ThiefHealthStatConstant));
            BaseMaximumMana = (int)(Math.Round((ThiefManaStatScaleFactor * (Math.Pow(Level, ThiefManaStatExponent))) + ThiefManaStatConstant));
            BaseStrength = (int)(Math.Round((ThiefStrengthStatScaleFactor * (Math.Pow(Level, ThiefStrengthStatExponent))) + ThiefStrengthStatConstant));
            BaseDefense = (int)(Math.Round((ThiefDefenseStatScaleFactor * (Math.Pow(Level, ThiefDefenseStatExponent))) + ThiefDefenseStatConstant));
            BaseLuck = (int)(Math.Round((ThiefLuckStatScaleFactor * (Math.Pow(Level, ThiefLuckStatExponent))) + ThiefLuckStatConstant));
            BaseSpeed = (int)(Math.Round((ThiefSpeedStatScaleFactor * (Math.Pow(Level, ThiefSpeedStatExponent))) + ThiefSpeedStatConstant));
            BaseIntellect = (int)(Math.Round((ThiefIntellectStatScaleFactor * (Math.Pow(Level, ThiefIntellectStatExponent))) + ThiefIntellectStatConstant));
            BaseResistance = (int)(Math.Round((ThiefResistanceStatScaleFactor * (Math.Pow(Level, ThiefResistanceStatExponent))) + ThiefResistanceStatConstant));
        }


        //<-----------Movement Functions----------->
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

        //Moves the player to a different location
        private void MoveTo(Location newLocation)
        {
            CurrentLocation = newLocation;
            UpdateTravelQuests(newLocation);
        }


        //<----------Battle Functions---------->
        public int Attack(Enemy enemy, ref GameSession.BattleResult battleResult)
        {
            int damage = 0;

            //This value modifies the damage depending on whether Greed or Empower is activated
            double empoweredGreedModifier = 1;

            //Check to see if player is using Greed or Empower
            if (Greed)
            {
                empoweredGreedModifier = GreedModifier;
            }
            else if (Empowered)
            {
                empoweredGreedModifier = EmpoweredModifier;
                ResetEmpowerment();
            }

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
                damage = (int)(((((TotalStrength * TotalStrength) / (TotalStrength + enemy.Defense)) * 2) * CriticalDamageModifier)
                                   * empoweredGreedModifier);
            }
            //Else the player would normally strike the enemy then calculate the damage accordingly
            else
            {
                battleResult = GameSession.BattleResult.Normal;
                damage = (int)((((TotalStrength * TotalStrength) / (TotalStrength + enemy.Defense)) * 2) * empoweredGreedModifier);
            }

            //If the player is not using Greed or using Empower then increase empower counter
            if(empoweredGreedModifier == 1)
            {
                IncreaseEmpowerment();
            }

            return damage;
        }

        public int CastSpell(Enemy enemy, Spell spell, ref GameSession.BattleResult battleResult)
        {
            if (CurrentMana < spell.ManaCost)
            {
                return -1;
            }

            if (spell is DamageSpell)
            {
                return CastDamageSpell(enemy, (DamageSpell)spell, ref battleResult);
            }
            else if (spell is ReplenishSpell)
            {
                return CastReplenishSpell((ReplenishSpell)spell);
            }
            else
            {
                throw new Exception("Somehow player is casting a spell that isn't a damage or replenish spell");
            }
        }

        public int CastSpellWhileTravel(Spell spell)
        {
            if (CurrentMana < spell.ManaCost)
            {
                return -1;
            }

            if (spell is ReplenishSpell)
            {
                return CastReplenishSpell((ReplenishSpell)spell);
            }
            else
            {
                throw new Exception("Somehow the player is casting a spell in the travel screen that is not a replenish spell");
            }
        }

        public int UseItem(Item item)
        {
            int itemEffectValue = 0;

            //This value modifies the item effect value depending on whether Greed or Empower is activated
            double empoweredGreedModifier = 1;

            //Check to see if player is using Greed or Empower
            if (Greed)
            {
                empoweredGreedModifier = GreedModifier;
            }
            else if (Empowered)
            {
                empoweredGreedModifier = EmpoweredModifier;
                ResetEmpowerment();
            }

            //Depending on the item type being used calculate the item effect value accordingly
            if (item is HealthReplenishingItem)
            {
                itemEffectValue = (int)(((HealthReplenishingItem)item).HealthReplenishingValue * empoweredGreedModifier);
            }
            else if(item is ManaReplenishingItem)
            {
                itemEffectValue = (int)(((ManaReplenishingItem)item).ManaReplenishingValue * empoweredGreedModifier);
            }
            else if(item is DamageItem)
            {
                itemEffectValue = (int)(((DamageItem)item).DamageValue * empoweredGreedModifier);
            }
            else
            {
                throw new Exception("Somehow an item is being used that is not a usable item");
            }

            RemoveItem(item);

            return itemEffectValue;
        }

        //Determines if the player can escape
        public bool Run(Enemy enemy)
        {
            int roll = RandomNumberGenerator.RandomNumberBetween(0, 99);

            if(TotalSpeed >= enemy.Speed + 10)
            {
                return true;
            }
            else if(TotalSpeed >= enemy.Speed + 5 && roll < 70)
            {
                return true;
            }
            else if(TotalSpeed >= enemy.Speed && roll < 60)
            {
                return true;
            }
            else if(TotalSpeed <= enemy.Speed - 10)
            {
                return false;
            }
            else if (TotalSpeed <= enemy.Speed - 5 && roll < 70)
            {
                return false;
            }
            else if (TotalSpeed <= enemy.Speed && roll < 60)
            {
                return false;
            }
            else if(TotalSpeed == enemy.Speed && roll < 50)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Check is if is the player's turn, return true if it is
        public bool IsPlayerTurn(Enemy enemy)
        {
            //Determines player's turn based on speed
            if (TotalSpeed > enemy.Speed)
            {
                return true;
            }
            else if (TotalSpeed < enemy.Speed)
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

        private int CastDamageSpell(Enemy enemy, DamageSpell damageSpell, ref GameSession.BattleResult battleResult)
        {
            int spellDamage = 0;

            //This value modifies the spell damage depending on whether Greed or Empower is activated
            double empoweredGreedModifier = 1;

            //Check to see if player is using Greed or Empower
            if (Greed)
            {
                empoweredGreedModifier = GreedModifier;
            }
            else if (Empowered)
            {
                empoweredGreedModifier = EmpoweredModifier;
                ResetEmpowerment();
            }

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
                spellDamage = (int)(((((TotalIntellect + damageSpell.DamageValue) / (TotalIntellect + enemy.Resistance)) * 2)
                                        * CriticalDamageModifier) * empoweredGreedModifier);
                CurrentMana -= damageSpell.ManaCost;
            }
            //Else the player would normally strike the enemy then calculate the spell damage accordingly
            else
            {
                battleResult = GameSession.BattleResult.Normal;
                spellDamage = (int)(((TotalIntellect + damageSpell.DamageValue) / (TotalIntellect + enemy.Resistance) * 2)
                                      * empoweredGreedModifier);
                CurrentMana -= damageSpell.ManaCost;
            }

            //If the player is not using Greed or using Empower then increase empower counter
            if (empoweredGreedModifier == 1)
            {
                IncreaseEmpowerment();
            }

            return spellDamage;
        }

        private int CastReplenishSpell(ReplenishSpell replenishSpell)
        {
            double empoweredGreedModifier = 1;

            //Check to see if player is using Greed or Empower
            if (Greed)
            {
                empoweredGreedModifier = GreedModifier;
            }
            else if (Empowered)
            {
                empoweredGreedModifier = EmpoweredModifier;
                ResetEmpowerment();
            }

            CurrentMana -= replenishSpell.ManaCost;

            return ((int)(replenishSpell.ReplenishValue * empoweredGreedModifier));
        }


        //<----------Enemy Loot Functions---------->
        public void GainEnemyRewards(Enemy enemy)
        {
            Gold += enemy.RewardGold;
            GainExperience(enemy.RewardExperiencePoints);

            if (enemy.WeightedItemLootTable != null && Greed == true)
            {
                GreedLootItemFromEnemy(enemy);
            }
            else if (enemy.WeightedItemLootTable != null && Greed == false)
            {
                LootItemFromEnemy(enemy);
            }

            if (enemy.WeightedEquipmentLootTable != null && Greed == true)
            {
                GreedLootEquipmentFromEnemy(enemy);
            }
            else if(enemy.WeightedEquipmentLootTable != null && Greed == false)
            {
                LootEquipmentFromEnemy(enemy);
            }

            if(enemy.WeightedSpellLootTable != null && Greed == true)
            {
                GreedLootSpellFromEnemy(enemy);
            }
            else if(enemy.WeightedSpellLootTable != null && Greed == false)
            {
                LootSpellFromEnemy(enemy);
            }
        }

        private void GreedLootItemFromEnemy(Enemy enemy)
        {
            foreach (KeyValuePair<Item, int> weightedItemLoot in enemy.WeightedItemLootTable)
            {
                AddItem(weightedItemLoot.Key);
            }
        }
        
        private void GreedLootEquipmentFromEnemy(Enemy enemy)
        {
            foreach (KeyValuePair<Equipment, int> weightedEquipmentLoot in enemy.WeightedEquipmentLootTable)
            {
                AddEquipment(weightedEquipmentLoot.Key);
            }
        }

        private void GreedLootSpellFromEnemy(Enemy enemy)
        {
            foreach(KeyValuePair<Spell, int> weightedSpellLoot in enemy.WeightedSpellLootTable)
            {
                AddSpell(weightedSpellLoot.Key);
            }
        }

        private void LootItemFromEnemy(Enemy enemy)
        {
            foreach (KeyValuePair<Item, int> weightedItemLoot in enemy.WeightedItemLootTable)
            {
                //If the player won the dice roll for the item loot then give them the loot
                if (RandomNumberGenerator.RandomNumberBetween(1, 100) <= weightedItemLoot.Value)
                {
                    AddItem(weightedItemLoot.Key);
                }
            }
        }

        private void LootEquipmentFromEnemy(Enemy enemy)
        {
            foreach (KeyValuePair<Equipment, int> weightedEquipmentLoot in enemy.WeightedEquipmentLootTable)
            {
                if (RandomNumberGenerator.RandomNumberBetween(1, 100) <= weightedEquipmentLoot.Value)
                {
                    AddEquipment(weightedEquipmentLoot.Key);
                }
            }
        }

        private void LootSpellFromEnemy(Enemy enemy)
        {
            foreach (KeyValuePair<Spell, int> weightedSpellLoot in enemy.WeightedSpellLootTable)
            {
                if (RandomNumberGenerator.RandomNumberBetween(1, 100) <= weightedSpellLoot.Value)
                {
                    AddSpell(weightedSpellLoot.Key);
                }
            }
        }


        //<----------Empowered Functions---------->
        public void ResetEmpowerment()
        {
            EmpowerCounter = 0;
            Empowered = false;
        }

        public void ActivateEmpowerment()
        {
            if(EmpowerCounter == 4)
            {
                Empowered = true;
            }
        }
        
        private void IncreaseEmpowerment()
        {
            EmpowerCounter++;
        }


        //<----------Greed Functions---------->
        public void ActivateGreed()
        {
            ResetEmpowerment();
            Greed = true;
        }

        public void DisableGreed()
        {
            ResetEmpowerment();
            Greed = false;
        }
        

        //<----------Shop Functions----------->

        //Returns true if player successfully bought the item, false otherwise
        public bool BuyFromStore(object objectBeingBought)
        {
            if (objectBeingBought is Item)
            {
                return BuyItem((Item)objectBeingBought);
            }
            else if (objectBeingBought is Equipment)
            {
                return BuyEquipment((Equipment)objectBeingBought);
            }
            else if (objectBeingBought is Spell)
            {
                return BuySpell((Spell)objectBeingBought);
            }
            else
            {
                throw new Exception("Trying to buy an object that cannot be bought");
            }
        }

        public void SellToStore(object objectBeingSold)
        {
            if (objectBeingSold is Item)
            {
                SellItem((Item)objectBeingSold);
            }
            else if (objectBeingSold is Equipment)
            {
                SellEquipment((Equipment)objectBeingSold);
            }
            else if (objectBeingSold is Spell)
            {
                SellSpell((Spell)objectBeingSold);
            }
            else
            {
                throw new Exception("Trying to sell an object that cannot be sold");
            }
        }

        private bool BuyItem(Item item)
        {
            if(Gold >= item.GoldValue)
            {
                AddItem(item);
                
                Gold -= item.GoldValue;
                
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool BuyEquipment(Equipment equipment)
        {
            if (Gold >= equipment.GoldValue)
            {
                AddEquipment(equipment);

                Gold -= equipment.GoldValue;

                return true;
            }
            else
            {
                return false;
            }
        }

        private bool BuySpell(Spell spell)
        {
            if (Gold >= spell.GoldValue)
            {
                AddSpell(spell);

                Gold -= spell.GoldValue;

                return true;
            }
            else
            {
                return false;
            }
        }

        private void SellItem(Item item)
        {
            RemoveItem(item);

            Gold += item.SellingGoldValue;
        }

        private void SellEquipment(Equipment equipment)
        {
            RemoveEquipment(equipment);

            Gold += equipment.SellingGoldValue;
        }

        private void SellSpell(Spell spell)
        {
            RemoveSpell(spell);

            Gold += spell.SellingGoldValue;
        }

        private void AddItem(Item item)
        {
            if (PlayerItems != null)
            {
                if (PlayerItems.ContainsKey(item))
                {
                    PlayerItems[item]++;
                }
                else
                {
                    PlayerItems.Add(item, 1);
                }
            }
        }

        private void AddEquipment(Equipment equipment)
        {
            PlayerEquipments.Add(equipment);
        }

        private void AddSpell(Spell spell)
        {
            PlayerSpells.Add(spell);
        }

        private void RemoveItem(Item item)
        {
            if (PlayerItems.ContainsKey(item))
            {
                if (PlayerItems[item] > 1)
                {
                    PlayerItems[item]--;
                }
                else
                {
                    PlayerItems.Remove(item);
                }
            }
            else
            {
                throw new Exception("Somehow the player is selling an item they don't own");
            }
        }

        private void RemoveEquipment(Equipment equipment)
        {
            if (PlayerEquipments.Contains(equipment))
            {
                PlayerEquipments.Remove(equipment);
            }
            else
            {
                throw new Exception("Player is somehow selling equipment they don't own");
            }
        }

        private void RemoveSpell(Spell spell)
        {
            if (PlayerSpells.Contains(spell))
            {
                PlayerSpells.Remove(spell);
            }
            else
            {
                throw new Exception("Player is somehow selling a spell they don't own");
            }
        }


        //<----------Equipment Methods--------->
        public bool Equip(Equipment equipment)
        {
            bool canEquip = false;

            if (equipment is HeadEquipment)
            {
                CurrentHeadEquipment = equipment as HeadEquipment;
                canEquip = true;
            }
            else if (equipment is ChestEquipment)
            {
                CurrentChestEquipment = equipment as ChestEquipment;
                canEquip = true;
            }
            else if (equipment is LegEquipment)
            {
                CurrentLegEquipment = equipment as LegEquipment;
                canEquip = true;
            }
            else if (equipment is Weapon)
            {
                if (equipment is Sword)
                {
                    if (playerClass == Class.Warrior)
                    {
                        CurrentWeapon = equipment as Sword;
                        canEquip = true;
                    }
                }
                else if (equipment is Staff)
                {
                    if (playerClass == Class.Mage)
                    {
                        CurrentWeapon = equipment as Staff;
                        canEquip = true;
                    }
                }
                else if (equipment is Dagger)
                {
                    if (playerClass == Class.Thief)
                    {
                        CurrentWeapon = equipment as Dagger;
                        canEquip = true;
                    }
                }
            }
            else if (equipment is SideArm)
            {
                if (equipment is Shield)
                {
                    if (playerClass == Class.Warrior)
                    {
                        CurrentSideArm = equipment as Shield;
                        canEquip = true;
                    }
                }
                else if (equipment is Tome)
                {
                    if (playerClass == Class.Mage)
                    {
                        CurrentSideArm = equipment as Tome;
                        canEquip = true;
                    }
                }
                else if (equipment is ParryingDagger)
                {
                    if (playerClass == Class.Thief)
                    {
                        CurrentSideArm = equipment as ParryingDagger;
                        canEquip = true;
                    }
                }
            }

            if (canEquip == true)
            {
                CalculateAllTotalStats();
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Unequip(Equipment equipment)
        {
            if (equipment is HeadEquipment)
            {
                CurrentHeadEquipment = null;
            }
            else if (equipment is ChestEquipment)
            {
                CurrentChestEquipment = null;
            }
            else if (equipment is LegEquipment)
            {
                CurrentLegEquipment = null;
            }
            else if (equipment is Weapon)
            {
                if (equipment is Sword)
                {
                    if (playerClass == Class.Warrior)
                    {
                        CurrentWeapon = null;
                    }
                }
                else if (equipment is Staff)
                {
                    if (playerClass == Class.Mage)
                    {
                        CurrentWeapon = null;
                    }
                }
                else if (equipment is Dagger)
                {
                    if (playerClass == Class.Thief)
                    {
                        CurrentWeapon = null;
                    }
                }
            }
            else if (equipment is SideArm)
            {
                if (equipment is Shield)
                {
                    if (playerClass == Class.Warrior)
                    {
                        CurrentSideArm = null;
                    }
                }
                else if (equipment is Tome)
                {
                    if (playerClass == Class.Mage)
                    {
                        CurrentSideArm = null;
                    }
                }
                else if (equipment is ParryingDagger)
                {
                    if (playerClass == Class.Thief)
                    {
                        CurrentSideArm = null;
                    }
                }
            }

            CalculateAllTotalStats();
        }

        public bool CheckIfEquippable(Equipment equipment)
        {
            bool canEquip = false;

            if (equipment is HeadEquipment)
            {
                canEquip = true;
            }
            else if (equipment is ChestEquipment)
            {
                canEquip = true;
            }
            else if (equipment is LegEquipment)
            {
                canEquip = true;
            }
            else if (equipment is Weapon)
            {
                if (equipment is Sword)
                {
                    if (playerClass == Class.Warrior)
                    {
                        canEquip = true;
                    }
                }
                else if (equipment is Staff)
                {
                    if (playerClass == Class.Mage)
                    {
                        canEquip = true;
                    }
                }
                else if (equipment is Dagger)
                {
                    if (playerClass == Class.Thief)
                    {
                        canEquip = true;
                    }
                }
            }
            else if (equipment is SideArm)
            {
                if (equipment is Shield)
                {
                    if (playerClass == Class.Warrior)
                    {
                        canEquip = true;
                    }
                }
                else if (equipment is Tome)
                {
                    if (playerClass == Class.Mage)
                    {
                        canEquip = true;
                    }
                }
                else if (equipment is ParryingDagger)
                {
                    if (playerClass == Class.Thief)
                    {
                        canEquip = true;
                    }
                }
            }
            
            return canEquip;
        }

        public bool CheckIfAlreadyEquipped(Equipment equipment)
        {
            bool alreadyEquipped = false;

            if (equipment is HeadEquipment)
            {
                if(CurrentHeadEquipment == equipment)
                {
                    alreadyEquipped = true;
                }
            }
            else if (equipment is ChestEquipment)
            {
                if (CurrentChestEquipment == equipment)
                {
                    alreadyEquipped = true;
                }
            }
            else if (equipment is LegEquipment)
            {
                if (CurrentLegEquipment == equipment)
                {
                    alreadyEquipped = true;
                }
            }
            else if (equipment is Weapon)
            {
                if (equipment is Sword)
                {
                    if (playerClass == Class.Warrior)
                    {
                        if (CurrentWeapon == equipment)
                        {
                            alreadyEquipped = true;
                        }
                    }
                }
                else if (equipment is Staff)
                {
                    if (playerClass == Class.Mage)
                    {
                        if (CurrentWeapon == equipment)
                        {
                            alreadyEquipped = true;
                        }
                    }
                }
                else if (equipment is Dagger)
                {
                    if (playerClass == Class.Thief)
                    {
                        if (CurrentWeapon == equipment)
                        {
                            alreadyEquipped = true;
                        }
                    }
                }
            }
            else if (equipment is SideArm)
            {
                if (equipment is Shield)
                {
                    if (playerClass == Class.Warrior)
                    {
                        if (CurrentSideArm == equipment)
                        {
                            alreadyEquipped = true;
                        }
                    }
                }
                else if (equipment is Tome)
                {
                    if (playerClass == Class.Mage)
                    {
                        if (CurrentSideArm == equipment)
                        {
                            alreadyEquipped = true;
                        }
                    }
                }
                else if (equipment is ParryingDagger)
                {
                    if (playerClass == Class.Thief)
                    {
                        if (CurrentSideArm == equipment)
                        {
                            alreadyEquipped = true;
                        }
                    }
                }
            }

            return alreadyEquipped;
        }


        //<----------Inn Methods---------->
        public bool StayAtInn(Inn inn)
        {
            if(Gold >= inn.GoldCost)
            {
                Recover();

                Gold -= inn.GoldCost;

                return true;
            }
            else
            {
                return false;
            }
        }

        private void Recover()
        {
            CurrentHealth = TotalMaximumHealth;
            CurrentMana = TotalMaximumMana;
        }


        //<----------Quests Methods----------->
        public void AcceptQuest(Quest quest)
        {
            PlayerQuests.Add(quest);
        }

        public bool CheckIfQuestComplete(Quest quest)
        {
            if(quest is GatherQuest)
            {
                if(IsGatherQuestComplete((GatherQuest)quest) == true)
                {
                    ((GatherQuest)quest).IsCompleted = true;
                    RemoveGatherQuestRequirements((GatherQuest)quest);
                    return true;
                }
            }
            else if(quest is KillQuest)
            {
                if(IsKillQuestComplete((KillQuest)quest))
                {
                    ((KillQuest)quest).IsCompleted = true;
                    return true;
                }
            }
            else if(quest is TravelQuest)
            {
                if(((TravelQuest)quest).HasVisitedLocation == true)
                {
                    ((TravelQuest)quest).IsCompleted = true;
                    return true;
                }
            }
            return false;
        }

        public void GainQuestRewards(Quest quest)
        {
            Gold += quest.RewardGold;
            GainExperience(quest.RewardExperience);
            if(quest.RewardItem != null)
            {
                AddItem(quest.RewardItem);
            }
            if(quest.RewardEquipment != null)
            {
                AddEquipment(quest.RewardEquipment);
            }
            if(quest.RewardSpell != null)
            {
                AddSpell(quest.RewardSpell);
            }
        }
        
        public void UpdateKillQuests(Enemy enemy)
        {
            foreach (Quest quest in PlayerQuests)
            {
                if (quest is KillQuest)
                {
                    //Checks if the enemy that was slain is a quest requirement
                    if (IsEnemyRequirement((KillQuest)quest, enemy))
                    {
                        //Checks if the dictionary already contains the enemy
                        //Here I am added the base enemy for the world class instead of the copy enemy
                        if (!ContainsEnemy((KillQuest)quest, enemy))
                        {
                            ((KillQuest)quest).EnemiesDefeatedSoFar.Add(World.FindEnemyByID(enemy.ID), 1);
                        }
                        else
                        {
                            ((KillQuest)quest).EnemiesDefeatedSoFar[World.FindEnemyByID(enemy.ID)]++;
                        }
                    }
                }
            }
        }

        private bool IsEnemyRequirement(KillQuest quest, Enemy enemy)
        {
            foreach (KeyValuePair<Enemy, int> requiredEnemy in quest.RequiredEnemies)
            {
                if (requiredEnemy.Key.ID == enemy.ID)
                {
                    return true;
                }
            }
            return false;
        }

        private bool ContainsEnemy(KillQuest quest, Enemy enemy)
        {
            foreach (KeyValuePair<Enemy, int> requiredEnemy in quest.EnemiesDefeatedSoFar)
            {
                if (requiredEnemy.Key.ID == enemy.ID)
                {
                    return true;
                }
            }
            return false;
        }
        
        private void UpdateTravelQuests(Location location)
        {
            foreach (Quest quest in PlayerQuests)
            {
                if (quest is TravelQuest)
                {
                    if (((TravelQuest)quest).RequiredLocation == location)
                    {
                        ((TravelQuest)quest).HasVisitedLocation = true;
                    }
                }
            }
        }
        
        private bool IsKillQuestComplete(KillQuest killQuest)
        {
            foreach (KeyValuePair<Enemy, int> requiredEnemy in killQuest.RequiredEnemies)
            {
                if (!killQuest.EnemiesDefeatedSoFar.ContainsKey(requiredEnemy.Key))
                {
                    return false;
                }
                else if (killQuest.EnemiesDefeatedSoFar[requiredEnemy.Key] < requiredEnemy.Value)
                {
                    return false;
                }
            }
            return true;
        }

        private bool IsGatherQuestComplete(GatherQuest gatherQuest)
        {
            int correctItems = 0;

            foreach (KeyValuePair<Item, int> item in PlayerItems)
            {
                if (item.Key is EnemyLoot)
                {
                    if (gatherQuest.RequiredEnemyLoots.ContainsKey((EnemyLoot)item.Key))
                    {
                        if (item.Value >= gatherQuest.RequiredEnemyLoots[((EnemyLoot)item.Key)])
                        {
                            correctItems++;
                        }
                    }
                }
            }

            if (correctItems == gatherQuest.RequiredEnemyLoots.Count())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void RemoveGatherQuestRequirements(GatherQuest gatherQuest)
        {
            Dictionary<Item, int> cloneItemInventory = CloneGenerator.CloneItemInventory(PlayerItems);

            foreach (KeyValuePair<Item, int> item in cloneItemInventory)
            {
                if (item.Key is EnemyLoot)
                {
                    if (gatherQuest.RequiredEnemyLoots.ContainsKey((EnemyLoot)item.Key))
                    {
                        if (item.Value > gatherQuest.RequiredEnemyLoots[((EnemyLoot)item.Key)])
                        {
                            PlayerItems[item.Key] -= gatherQuest.RequiredEnemyLoots[((EnemyLoot)item.Key)];
                        }
                        else if (item.Value == gatherQuest.RequiredEnemyLoots[((EnemyLoot)item.Key)])
                        {
                            PlayerItems.Remove(item.Key);
                        }
                    }
                }
            }
        }


        public override string ToString()
        {
            string info = "";

            info += ("Level: " + Level + "\n");
            info += ("Name: " + Name + "\n");
            info += ("Class: " + playerClass + "\n");
            info += ("Gold: " + Gold.ToString() + "\n");
            info += ("Experience: " + CurrentExperiencePoints + "/" + MaximumExperiencePoints + "\n");
            info += ("Current Health: " + CurrentHealth + "\n");
            info += ("Maximum Health: " + BaseMaximumHealth + "\n");
            info += ("Current Mana: " + CurrentMana + "\n");
            info += ("Maximum Mana: " + BaseMaximumMana + "\n");
            info += ("Strength: " + BaseStrength + "\n");
            info += ("Defense: " + BaseDefense + "\n");
            info += ("Luck: " + BaseLuck + "\n");
            info += ("Speed: " + BaseSpeed + "\n");
            info += ("Intellect: " + BaseIntellect + "\n");
            info += ("Resistance: " + BaseResistance + "\n");
            info += ("Critical Chance: " + ((int)CriticalChanceRate) + "%\n");
            info += ("Dodge Chance: " + ((int)DodgeChanceRate) + "%\n");

            return info;
        }
    }
}