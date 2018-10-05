using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class InventoryLoot  
    {
        public EnemyLoot EnemyLoot;
        public int Quantity;

        public InventoryLoot(EnemyLoot enemyLoot, int quantity)
        {
            this.EnemyLoot = enemyLoot;
            this.Quantity = quantity;
        }

        public override string ToString()
        {
            string info = "";
            
            info += ("Enemy Loot: " + EnemyLoot.ToString() + "\n");
            info += ("Quantity " + Quantity.ToString() + "\n");

            return info;
        }
    }
}
