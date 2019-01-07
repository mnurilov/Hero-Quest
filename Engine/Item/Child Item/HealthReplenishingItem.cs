using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class HealthReplenishingItem : Item
    {
        public int HealthReplenishingValue { get; set; }


        public HealthReplenishingItem(int id, string name, string description, int goldValue, int healthReplenishingValue)
            : base(id, name, description, goldValue)
        {
            this.HealthReplenishingValue = healthReplenishingValue;
        }


        public override string ToString()
        {
            string info = "";

            info += base.ToString();
            info += ("Health Replenishing Value: " + HealthReplenishingValue + "\n");

            return info;
        }
    }
}