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

        public InventoryItem(Item item, int quantity)
        {
            this.Item = item;
            this.Quantity = quantity;
        }

        public override string ToString()
        {
            //Why is this if statement here check this out latter
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
