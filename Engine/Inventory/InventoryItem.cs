using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class InventoryItem
    {
        public Item Item;
        public int Quantity;

        public InventoryItem(Item Item, int Quantity)
        {
            this.Item = Item;
            this.Quantity = Quantity;
        }

        public override string ToString()
        {
            if (this != null)
            {
                string info = "";

                info += ("Item: " + Item.ToString() + "\n");
                info += ("Quantity " + Quantity.ToString() + "\n");

                return info;
            }
            return "Empty";
        }
    }
}
