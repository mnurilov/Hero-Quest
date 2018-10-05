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
        public Item (int id, string name, string description)
        {
            this.ID = id;
            this.Name = name;
            this.Description = description;
        }
        #endregion

        #region Methods
        //An item cannot use itself this should probably be moved to whoever is using the item 
        //Then again if using an item would belong to the item itself it would allow other classes to use it 
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
