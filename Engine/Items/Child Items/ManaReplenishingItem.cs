using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class ManaReplenishingItem : Item
    {
        public int ManaReplenishingValue { get; set; }

        public ManaReplenishingItem(int ID, string Name, int ManaReplenishingValue) : base(ID, Name)
        {
            this.ManaReplenishingValue = ManaReplenishingValue;
        }

        #region Methods
        public override void UseItem()
        {
            Console.WriteLine("Mana Item");
            Console.ReadKey();
        }

        public override string ToString()
        {
            string info = "";

            info += base.ToString();
            info += ("Mana Replenishing Value: " + ManaReplenishingValue.ToString() + "\n");

            return info;
        }
        #endregion
    }
}
