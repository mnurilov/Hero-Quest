using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Spell
    {
        #region Properties
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ManaCost { get; set; }
        #endregion

        #region Constructor
        public Spell(int ID, string Name, string Description, int ManaCost)
        {
            this.ID = ID;
            this.Name = Name;
            this.Description = Description;
            this.ManaCost = ManaCost;
        }
        #endregion

        public override string ToString()
        {
            string info = "";

            info += ("ID: " + ID.ToString() + "\n");
            info += ("Name: " + Name + "\n");
            info += ("Description: " + Description + "\n");
            info += ("Mana Cost: " + ManaCost.ToString() + "\n");

            return info;
        }
    }
}
