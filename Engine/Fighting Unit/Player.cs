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

        //Base stats
        public int BaseMaximumHealth { get; set; }
        public int BaseMaximumMana { get; set; }
        public int BaseStrength { get; set; }
        public int BaseDefense { get; set; }
        public int BaseLuck { get; set; }
        public int BaseSpeed { get; set; }
        public int BaseIntellect { get; set; }
        public int BaseResistance { get; set; }


        //Total stats after equipment bonuses are calculated
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


        public Player(int level, string name, Class playerClass)
        {
            this.Level = level;
            this.Name = name;
            this.MaximumExperiencePoints = GetUpdatedMaximumExperience();
            this.CurrentExperiencePoints = 0;
            this.PlayerClass = playerClass;

            UpdateBaseStats();
            ResetTotalStats();

            //After properly setting up the players base and total stats only then can you set his current health and mana
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


        //Leveling, Experience, and Stats Functions
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

        private void UpdateBaseStats()
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
            TotalStrength += equipment.AttackBonus;
            TotalDefense += equipment.DefenseBonus;
            TotalLuck += equipment.LuckBonus;
            TotalSpeed += equipment.SpeedBonus;
            TotalIntellect += equipment.IntellectBonus;
            TotalResistance += equipment.ResistanceBonus;
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

        private void UpdateCriticalAndDodge()
        {
            CriticalChanceRate = ((CriticalChanceRateScaleFactor * TotalLuck) / (TotalLuck + CriticalChanceRateConstant));
            DodgeChanceRate = ((DodgeChanceRateScaleFactor * TotalLuck) / (TotalLuck + DodgeChanceRateConstant));
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
            UpdateBaseStats();
        }

        //FIX THIS UP SO IT DOESNT JUST GIVE ALL ENEMY LOOT
        public void GainEnemyRewards(Enemy enemy)
        {
            Gold += enemy.RewardGold;
            GainExperience(enemy.RewardExperiencePoints);
            if(enemy.LootTable != null)
            {
                foreach(EnemyLoot loot in enemy.LootTable)
                {
                    if (PlayerItems.ContainsKey(loot))
                    {
                        PlayerItems[loot]++;
                    }
                    else
                    {
                        PlayerItems.Add(loot, 1);
                    }
                }
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


        //Movement Functions
        //Moves the player to a different location
        private void MoveTo(Location newLocation)
        {
            CurrentLocation = newLocation;
            CheckTravelQuest(newLocation);
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
                damage = (((TotalStrength * TotalStrength) / (TotalStrength + enemy.Defense)) * 2) * 2;
            }
            //Else the player would normally strike the enemy then calculate the damage accordingly
            else
            {
                battleResult = GameSession.BattleResult.Normal;
                damage = ((TotalStrength * TotalStrength) / (TotalStrength + enemy.Defense)) * 2;
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
                spellDamage = (((TotalIntellect + damageSpell.DamageAmount) / (TotalIntellect + enemy.Resistance) * 2) * 2);
            }
            //Else the player would normally strike the enemy then calculate the spell damage accordingly
            else
            {
                battleResult = GameSession.BattleResult.Normal;
                spellDamage = ((TotalIntellect + damageSpell.DamageAmount) / (TotalIntellect + enemy.Resistance) * 2);
            }

            return spellDamage;
        }

        //Determines if the player can escape FIX THIS TO HAVE IT BE AFFECTED BY SPEED OF BOTH PLAYER AND ENEMY
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
            bool canEquip = false;

            if(equipment is HeadEquipment)
            {
                CurrentHeadEquipment = equipment as HeadEquipment;
                canEquip = true;
            }
            else if(equipment is ChestEquipment)
            {
                CurrentChestEquipment = equipment as ChestEquipment;
                canEquip = true;
            }
            else if(equipment is LegEquipment)
            {
                CurrentLegEquipment = equipment as LegEquipment;
                canEquip = true;
            }
            else if(equipment is Weapon)
            {
                if(equipment is Sword)
                {
                    if(PlayerClass == Class.Warrior)
                    {
                        CurrentWeapon = equipment as Sword;
                        canEquip = true;
                    }
                }
                else if(equipment is Staff)
                {
                    if (PlayerClass == Class.Mage)
                    {
                        CurrentWeapon = equipment as Staff;
                        canEquip = true;
                    }
                }
                else if(equipment is Dagger)
                {
                    if (PlayerClass == Class.Thief)
                    {
                        CurrentWeapon = equipment as Dagger;
                        canEquip = true;
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
                        canEquip = true;
                    }
                }
                else if (equipment is Tome)
                {
                    if (PlayerClass == Class.Mage)
                    {
                        CurrentSideArm = equipment as Tome;
                        canEquip = true;
                    }
                }
                else if (equipment is ParryingDagger)
                {
                    if (PlayerClass == Class.Thief)
                    {
                        CurrentSideArm = equipment as ParryingDagger;
                        canEquip = true;
                    }
                }
            }

            if(canEquip == true)
            {
                CalculateAllTotalStats();
                return true;
            }
            else
            {
                return false;
            }
        }

        //public void DeEquip()

        //Quests Methods
        public void AcceptQuest(Quest quest)
        {
            PlayerQuests.Add(quest);
        }
        
        public void CheckKillQuest(Enemy enemy)
        {
            foreach(Quest quest in PlayerQuests)
            {
                if(quest is KillQuest)
                {
                    if(((KillQuest)quest).RequiredEnemies.ContainsKey(enemy))
                    {
                        if (!(((KillQuest)quest).EnemiesDefeatedSoFar.ContainsKey(enemy)))
                        {
                            ((KillQuest)quest).EnemiesDefeatedSoFar.Add(enemy, 1);
                        }
                        else
                        {
                            ((KillQuest)quest).EnemiesDefeatedSoFar[enemy]++;
                        }
                    }
                }
            }
        }

        private void CheckTravelQuest(Location location)
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

        private bool CheckGatherQuest(GatherQuest gatherQuest)
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
            foreach (KeyValuePair<Item, int> item in PlayerItems)
            {
                if (item.Key is EnemyLoot)
                {
                    if (gatherQuest.RequiredEnemyLoots.ContainsKey((EnemyLoot)item.Key))
                    {
                        if (item.Value >= gatherQuest.RequiredEnemyLoots[((EnemyLoot)item.Key)])
                        {
                            PlayerItems[item.Key] -= gatherQuest.RequiredEnemyLoots[((EnemyLoot)item.Key)];
                        }
                    }
                }
            }
        }

        private bool CheckKillQuestRequirements(KillQuest killQuest)
        {
            foreach(KeyValuePair<Enemy, int> enemy in killQuest.RequiredEnemies)
            {
                if (!killQuest.EnemiesDefeatedSoFar.ContainsKey(enemy.Key))
                {
                    return false;
                }
                else if(killQuest.EnemiesDefeatedSoFar[enemy.Key] < enemy.Value)
                {
                    return false;
                }
            }
            return true;
        }

        public bool CheckIfQuestComplete(Quest quest)
        {
            if(quest is GatherQuest)
            {
                if(CheckGatherQuest((GatherQuest)quest) == true)
                {
                    ((GatherQuest)quest).IsCompleted = true;
                    RemoveGatherQuestRequirements((GatherQuest)quest);
                    return true;
                }
            }
            else if(quest is KillQuest)
            {
                if(CheckKillQuestRequirements((KillQuest)quest))
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

        public void QuestRewards(Quest quest)
        {
            Gold += quest.RewardGold;
            GainExperience(quest.RewardExperience);
            if(quest.RewardItem != null)
            {
                if (PlayerItems.ContainsKey(quest.RewardItem))
                {
                    PlayerItems[quest.RewardItem]++;
                }
                else
                {
                    PlayerItems.Add(quest.RewardItem, 1);
                }
            }
            if(quest.RewardEquipment != null)
            {
                PlayerEquipments.Add(quest.RewardEquipment);
            }
            if(quest.RewardSpell != null)
            {
                PlayerSpells.Add(quest.RewardSpell);
            }
        }

        public override string ToString()
        {
            string info = "";

            info += ("Level: " + Level.ToString() + "\n");
            info += ("Name: " + Name + "\n");
            info += ("Class: " + PlayerClass.ToString() + "\n");
            info += ("Gold: " + Gold.ToString() + "\n");
            info += ("Current Experience: " + CurrentExperiencePoints.ToString() + "\n");
            info += ("Maximum Experience: " + MaximumExperiencePoints.ToString() + "\n");
            info += ("Current Health: " + CurrentHealth.ToString() + "\n");
            info += ("Maximum Health: " + BaseMaximumHealth.ToString() + "\n");
            info += ("Current Mana: " + CurrentMana.ToString() + "\n");
            info += ("Maximum Mana: " + BaseMaximumMana.ToString() + "\n");
            info += ("Strength: " + BaseStrength.ToString() + "\n");
            info += ("Defense: " + BaseDefense.ToString() + "\n");
            info += ("Luck: " + BaseLuck.ToString() + "\n");
            info += ("Speed: " + BaseSpeed.ToString() + "\n");
            info += ("Intellect: " + BaseIntellect.ToString() + "\n");
            info += ("Resistance: " + BaseResistance.ToString() + "\n");
            info += ("Critical Chance: " + ((int)CriticalChanceRate).ToString() + "%\n");
            info += ("Dodge Chance: " + ((int)DodgeChanceRate).ToString() + "%\n");

            return info;
        }
    }
}