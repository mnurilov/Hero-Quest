using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Item
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int GoldValue { get; set; }


        public Item(int id, string name, string description, int goldValue)
        {
            this.ID = id;
            this.Name = name;
            this.Description = description;
            this.GoldValue = goldValue;
        }

        public override string ToString()
        {
            string info = "";

            info += ("ID: " + ID.ToString() + "\n");
            info += ("Name: " + Name + "\n");
            info += ("Description: " + Description + "\n");

            return info;
        }
    }
}
