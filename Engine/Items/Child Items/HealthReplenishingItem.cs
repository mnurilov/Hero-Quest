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

        public HealthReplenishingItem(int ID, string Name, int HealthReplenishingValue) : base(ID, Name)
        {
            this.HealthReplenishingValue = HealthReplenishingValue;
        }

        #region Methods
        public override void UseItem()
        {
            Console.WriteLine("Healing Item");
            Console.ReadKey();
        }

        public override string ToString()
        {
            string info = "";

            info += base.ToString();
            info += ("Health Replenishing Value: " + HealthReplenishingValue.ToString() + "\n");

            return info;
        }
        #endregion
    }
}