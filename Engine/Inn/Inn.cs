using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Inn
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int GoldCost { get; set; }
        public Person InnKeeper { get; set; }
        
        public Inn(int id, string name, string description, int goldCost, Person innKeeper)
        {
            this.ID = id;
            this.Name = name;
            this.Description = description;
            this.GoldCost = goldCost;
            this.InnKeeper = innKeeper;
        }

        public override string ToString()
        {
            string info = "";

            info += ("ID: " + ID + "\n");
            info += ("Name: " + Name + "\n");
            info += ("Description: " + Description + "\n");
            info += ("Gold Cost: " + GoldCost + "\n");
            info += ("Inn Keeper: " + InnKeeper.Name + "\n");

            return info;
        }
    }
}
