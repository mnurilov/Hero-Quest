using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Item
    {
        #region Properties
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        #endregion

        #region Constructor
        public Item (int ID, string Name)
        {
            this.ID = ID;
            this.Name = Name;
        }
        #endregion

        #region Methods
        public virtual void UseItem()
        {
            Console.WriteLine("Base Item");
            Console.ReadKey();
        }

        public override string ToString()
        {
            string info = "";

            info += ("ID: " + ID.ToString() + "\n");
            info += ("Name: " + Name + "\n");
            info += ("Description: " + Description + "\n");

            return info;
        }
        #endregion
    }
}
