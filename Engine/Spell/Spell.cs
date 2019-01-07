using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public abstract class Spell
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int GoldValue { get; set; }
        private const double SellingValueModifier = 0.5;
        public int SellingGoldValue { get; set; }
        public int ManaCost { get; set; }


        public Spell(int id, string name, string description, int goldValue, int manaCost)
        {
            this.ID = id;
            this.Name = name;
            this.Description = description;
            this.GoldValue = goldValue;
            SellingGoldValue = (int)(GoldValue * SellingValueModifier);
            this.ManaCost = manaCost;
        }


        public override string ToString()
        {
            string info = "";

            info += ("ID: " + ID + "\n");
            info += ("Name: " + Name + "\n");
            info += ("Description: " + Description + "\n");
            info += ("Gold Value: " + GoldValue + "\n");
            info += ("Mana Cost: " + ManaCost + "\n");

            return info;
        }
    }
}
