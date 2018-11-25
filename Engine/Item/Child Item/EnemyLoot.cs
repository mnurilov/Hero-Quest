using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class EnemyLoot : Item
    {
        public EnemyLoot(int id, string name, string description, int goldValue) : base(id, name, description, goldValue)
        {

        }
    }
}
