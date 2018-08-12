using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Player : FightingUnit
    {
        private int level;
        private int experience;

        public string Name;
        public int Level
        {
            get { return level; }
            set
            {
                if(value > 20)
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

        public Player(int health, int level) : base(health)
        {
            this.level = level;
        }
    }
}
