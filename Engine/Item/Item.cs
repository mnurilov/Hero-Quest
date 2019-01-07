using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public abstract class Item
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int GoldValue { get; set; }
        private const double SellingValueModifier = 0.5;
        public int SellingGoldValue { get; set; }


        public Item(int id, string name, string description, int goldValue)
        {
            this.ID = id;
            this.Name = name;
            this.Description = description;
            this.GoldValue = goldValue;
            SellingGoldValue = (int)(GoldValue * SellingValueModifier);
        }


        public override string ToString()
        {
            string info = "";

            info += ("ID: " + ID + "\n");
            info += ("Name: " + Name + "\n");
            info += ("Description: " + Description + "\n");
            info += ("Gold Value: " + GoldValue + "\n");

            return info;
        }
    }
}
