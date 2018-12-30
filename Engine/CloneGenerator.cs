using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public static class CloneGenerator
    {
        public static Enemy CloneEnemy(Enemy enemy)
        {
            Enemy cloneEnemy = new Enemy(enemy.ID, enemy.Name, enemy.Description, enemy.MaximumHealth, enemy.MaximumMana,
                enemy.Strength, enemy.Defense, enemy.Luck, enemy.Speed, enemy.Intellect, enemy.Resistance, enemy.CriticalChanceRate,
                enemy.DodgeChanceRate, enemy.RewardGold, enemy.RewardExperiencePoints);

            cloneEnemy.LootTable = CloneEnemyLootTable(enemy.LootTable);

            return cloneEnemy;
        }

        public static Item CloneItem(Item item)
        {
            if(item is EnemyLoot)
            {
                return CloneEnemyLoot((EnemyLoot)item);
            }
            else if(item is HealthReplenishingItem)
            {
                return CloneHealthReplenishingItem((HealthReplenishingItem)item);
            }
            else if(item is ManaReplenishingItem)
            {
                return CloneManaReplenishingItem((ManaReplenishingItem)item);
            }
            else if(item is DamageItem)
            {
                return CloneDamageItem((DamageItem)item);
            }

            return item;
        }

        public static Dictionary<Item, int> CloneItemInventory(Dictionary<Item, int> itemInventory)
        {
            Dictionary<Item, int> cloneItemInventory = new Dictionary<Item, int>();

            foreach(KeyValuePair<Item, int> kvp in itemInventory)
            {
                cloneItemInventory.Add(CloneItem(kvp.Key), kvp.Value);
            }

            return cloneItemInventory;
        }

        private static EnemyLoot CloneEnemyLoot(EnemyLoot enemyLoot)
        {
            EnemyLoot cloneEnemyLoot = new EnemyLoot(enemyLoot.ID, enemyLoot.Name, enemyLoot.Description, enemyLoot.GoldValue);

            return cloneEnemyLoot;
        }

        private static HealthReplenishingItem CloneHealthReplenishingItem(HealthReplenishingItem healthReplenishingItem)
        {
            HealthReplenishingItem cloneHealthReplenishingItem = new HealthReplenishingItem(healthReplenishingItem.ID,
                healthReplenishingItem.Name, healthReplenishingItem.Description, healthReplenishingItem.GoldValue,
                healthReplenishingItem.HealthReplenishingValue);

            return cloneHealthReplenishingItem;
        }

        private static ManaReplenishingItem CloneManaReplenishingItem(ManaReplenishingItem manaReplenishingItem)
        {
            ManaReplenishingItem cloneManaReplenishingItem = new ManaReplenishingItem(manaReplenishingItem.ID,
                manaReplenishingItem.Name, manaReplenishingItem.Description, manaReplenishingItem.GoldValue,
                manaReplenishingItem.ManaReplenishingValue);

            return cloneManaReplenishingItem;
        }

        private static DamageItem CloneDamageItem(DamageItem damageItem)
        {
            DamageItem cloneDamageItem = new DamageItem(damageItem.ID, damageItem.Name, damageItem.Description,
                damageItem.GoldValue, damageItem.DamageValue);

            return cloneDamageItem;
        }

        private static List<EnemyLoot> CloneEnemyLootTable(List<EnemyLoot> lootTable)
        {
            List<EnemyLoot> cloneLootTable = new List<EnemyLoot>();

            foreach(EnemyLoot enemyLoot in lootTable)
            {
                cloneLootTable.Add((EnemyLoot)CloneItem(enemyLoot));
            }

            return cloneLootTable;
        }
    }
}
