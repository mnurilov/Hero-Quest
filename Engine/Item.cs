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
        #endregion

        #region Constructor
        public Item (int ID, string Name)
        {
            this.ID = ID;
            this.Name = Name;
        }
        #endregion
    }
}
