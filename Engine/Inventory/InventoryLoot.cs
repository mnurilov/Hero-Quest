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

        public InventoryLoot(EnemyLoot EnemyLoot, int Quantity)
        {
            this.EnemyLoot = EnemyLoot;
            this.Quantity = Quantity;
        }
    }
}
