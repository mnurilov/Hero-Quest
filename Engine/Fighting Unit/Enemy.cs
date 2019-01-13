using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Enemy
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        //<----------Enemy Stats---------->
        private int currentHealth;
        public int CurrentHealth
        {
            get
            {
                return currentHealth;
            }
            set
            {
                if (value > MaximumHealth)
                {
                    currentHealth = MaximumHealth;
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
                if (value > MaximumMana)
                {
                    currentMana = MaximumMana;
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

        public int MaximumHealth { get; set; }
        public int MaximumMana { get; set; }
        public int Strength { get; set; }
        public int Defense { get; set; }
        public int Luck { get; set; }
        public int Speed { get; set; }
        public int Intellect { get; set; }
        public int Resistance { get; set; }

        public double CriticalDamageModifier { get; set; }
        public double CriticalChanceRate { get; set; }
        public double DodgeChanceRate { get; set; }

        //<----------Enemy Spell Casting----------->
        public List<Spell> Spells { get; set; }
        public int SpellCastRate { get; set; }

        //A string used for the UI. Its purpose is to show the player how the enemy attacked them (with their fist, claws, sword, etc)
        public string WeaponUsed { get; set; }

        //<----------Reward given to Player on death---------->
        public int RewardGold { get; set; }
        public int RewardExperiencePoints { get; set; }

        //<----------Key is the loot given to the player, Value is the chance of the item appearing----------->
        public Dictionary<Item, int> WeightedItemLootTable { get; set; }
        public Dictionary<Equipment, int> WeightedEquipmentLootTable { get; set; }
        public Dictionary<Spell, int> WeightedSpellLootTable { get; set; }

        public bool IsBoss { get; set; }

        
        public Enemy (int id, string name, string description, int maximumHealth, int maximumMana, int strength, 
            int defense, int luck, int speed, int intellect, int resistance, double criticalChanceRate,
            double dodgeChanceRate, int rewardGold, int rewardExperiencePoints, int spellCastRate, 
            List<Spell> spells = null, string weaponUsed = "fists", Dictionary<Item, int> weightedItemLootTable = null,
            Dictionary<Equipment, int> weightedEquipmentLootTable = null, Dictionary<Spell, int> weightedSpellLootTable = null)
        { 
            this.ID = id;
            this.Name = name;
            this.Description = description;
            this.MaximumHealth = maximumHealth;
            this.MaximumMana = maximumMana;
            CurrentHealth = MaximumHealth;
            CurrentMana = MaximumMana;
            this.Strength = strength;
            this.Defense = defense;
            this.Luck = luck;
            this.Speed = speed;
            this.Intellect = intellect;
            this.Resistance = resistance;
            CriticalDamageModifier = 2;
            this.CriticalChanceRate = criticalChanceRate;
            this.DodgeChanceRate = dodgeChanceRate;
            this.Spells = spells;
            this.SpellCastRate = spellCastRate;
            this.WeaponUsed = weaponUsed;
            this.RewardGold = rewardGold;
            this.RewardExperiencePoints = rewardExperiencePoints;
            this.WeightedItemLootTable = weightedItemLootTable;
            this.WeightedEquipmentLootTable = weightedEquipmentLootTable;
            this.WeightedSpellLootTable = weightedSpellLootTable;
        }


        //<----------Combat Actions---------->
        public int CombatAction(Player player, ref GameSession.BattleResult battleResult, ref GameSession.EnemyChoiceTaken enemyChoiceTaken,
            ref string spellName)
        {
            if(RandomNumberGenerator.RandomNumberBetween(1, 100) <= SpellCastRate)
            {
                Spell spellToBeCasted = PickRandomSpell();
                int attempts = 0;

                //While the current spell selected cannot be cast due to insufficent mana keep looking for a different spell
                //I set 100 as the amount of attempts the enemy gets to cast a spell if they still cannot cast that spell
                //It means that most likely they don't have enough mana for any spell and they should attack instead
                while(CurrentMana < spellToBeCasted.ManaCost && attempts < 100)
                {
                    spellToBeCasted = PickRandomSpell();
                    attempts++;
                }

                if(CurrentMana < spellToBeCasted.ManaCost)
                {
                    enemyChoiceTaken = GameSession.EnemyChoiceTaken.Attack;
                    return Attack(player, ref battleResult);
                }

                if (spellToBeCasted is DamageSpell)
                {
                    enemyChoiceTaken = GameSession.EnemyChoiceTaken.CastSpell;
                    spellName = spellToBeCasted.Name;
                    return CastDamageSpell(player, (DamageSpell)spellToBeCasted, ref battleResult);
                }
                else if(spellToBeCasted is ReplenishSpell)
                {
                    enemyChoiceTaken = GameSession.EnemyChoiceTaken.Replenish;
                    spellName = spellToBeCasted.Name;
                    return CastReplenishSpell((ReplenishSpell)spellToBeCasted);
                }
                else
                {
                    throw new Exception("Somehow the spell isn't a damage or replenish spell");
                }
            }
            else
            {
                enemyChoiceTaken = GameSession.EnemyChoiceTaken.Attack;
                return Attack(player, ref battleResult);
            }
        }

        private int Attack(Player player, ref GameSession.BattleResult battleResult)
        {
            int damage = 0;

            //If the player would dodge the attack do not calculate the damage
            if (RandomNumberGenerator.RandomNumberBetween(1, 100) <= player.DodgeChanceRate)
            {
                battleResult = GameSession.BattleResult.Missed;
                return damage;
            }

            //If the enemy would critical strike the player then calculate the damage accordingly
            if (RandomNumberGenerator.RandomNumberBetween(1, 100) <= CriticalChanceRate)
            {
                //Increase damage by critical damage modifier
                battleResult = GameSession.BattleResult.Critical;
                if(player.TotalDefense <= 0)
                {
                    damage = (int)(((((Strength * Strength) / (Strength + 1)) * 2) * (Math.Abs((double)player.TotalDefense) / 4)) * CriticalDamageModifier);
                }
                else
                {
                    damage = (int)((((Strength * Strength) / (Strength + player.TotalDefense)) * 2) * CriticalDamageModifier);
                }
            }
            //Else the enemy would normally strike the player then calculate the damage accordingly
            else
            {
                battleResult = GameSession.BattleResult.Normal;
                if(player.TotalDefense <= 0)
                {
                    damage = (int)((((Strength * Strength) / (Strength + 1)) * 2) * (Math.Abs((double)player.TotalDefense) / 4));
                }
                else
                {
                    damage = ((Strength * Strength) / (Strength + player.TotalDefense)) * 2;
                }
            }

            return damage;
        }

        private int CastDamageSpell(Player player, DamageSpell damageSpell, ref GameSession.BattleResult battleResult)
        {
            int spellDamage = 0;

            //If the enemy would dodge the attack do not calculate spell damage
            if (RandomNumberGenerator.RandomNumberBetween(1, 100) <= player.DodgeChanceRate)
            {
                battleResult = GameSession.BattleResult.Missed;
                CurrentMana -= damageSpell.ManaCost;
                return 0;
            }

            //If the player would critical strike the enemy then calculate the spell damage accordingly
            if (RandomNumberGenerator.RandomNumberBetween(1, 100) <= CriticalChanceRate)
            {
                //Increase damage by critical damage modifier
                battleResult = GameSession.BattleResult.Critical;
                spellDamage = (int)((damageSpell.DamageValue + ((Intellect * Intellect) / (Intellect + player.TotalResistance))) * CriticalDamageModifier);
                CurrentMana -= damageSpell.ManaCost;
            }
            //Else the player would normally strike the enemy then calculate the spell damage accordingly
            else
            {
                battleResult = GameSession.BattleResult.Normal;
                spellDamage = (int)(damageSpell.DamageValue + ((Intellect * Intellect) / (Intellect + player.TotalResistance)));
                CurrentMana -= damageSpell.ManaCost;
            }

            return spellDamage;
        }

        private int CastReplenishSpell(ReplenishSpell replenishSpell)
        {
            int intellectAffectModifier = 60;

            CurrentMana -= replenishSpell.ManaCost;

            double replenishAmount = replenishSpell.ReplenishValue * (1 + ((double)Intellect/intellectAffectModifier));

            return (int)replenishAmount;
        }
        
        private Spell PickRandomSpell()
        {
            int spellChoice = RandomNumberGenerator.RandomNumberBetween(0, 1000000) % Spells.Count;

            return Spells[spellChoice];
        }


        public override string ToString()
        {
            string info = "";

            info += ("ID: " + ID + "\n");
            info += ("Name: " + Name + "\n");
            info += ("Description: " + Description + "\n");
            info += ("Health: " + CurrentHealth + "/" + MaximumHealth + "\n");
            info += ("Mana: " + CurrentMana + "/" + MaximumMana + "\n");
            info += ("Strength: " + Strength + "\n");
            info += ("Defense: " + Defense + "\n");
            info += ("Luck: " + Luck + "\n");
            info += ("Speed: " + Speed + "\n");
            info += ("Intellect: " + Intellect + "\n");
            info += ("Resistance: " + Resistance + "\n");
            info += ("Critical Damage Modifier: " + CriticalDamageModifier + "\n");
            info += ("Critical Chance: " + ((int)CriticalChanceRate) + "%\n");
            info += ("Dodge Chance: " + ((int)DodgeChanceRate) + "%\n");
            if(Spells != null)
            {
                foreach(Spell spell in Spells)
                {
                    info += ("Spell: " + spell.Name + "\n");
                }
            }
            info += ("Spell Cast Rate" + SpellCastRate + "\n");
            info += ("Weapon Used" + WeaponUsed + "\n");
            info += ("Reward Gold: " + RewardGold + "\n");
            info += ("Reward Experience: " + RewardExperiencePoints + "\n");
            if(WeightedItemLootTable != null)
            {
                foreach (KeyValuePair<Item, int> item in WeightedItemLootTable)
                {
                    info += ("Item: " + item.Key.Name + "\n");
                }
            }
            if (WeightedEquipmentLootTable != null)
            {
                foreach (KeyValuePair<Equipment, int> equipment in WeightedEquipmentLootTable)
                {
                    info += ("Equipment: " + equipment.Key.Name + "\n");
                }
            }
            if (WeightedSpellLootTable != null)
            {
                foreach (KeyValuePair<Spell, int> spell in WeightedSpellLootTable)
                {
                    info += ("Spell: " + spell.Key.Name + "\n");
                }
            }

            return info;
        }
    }
}