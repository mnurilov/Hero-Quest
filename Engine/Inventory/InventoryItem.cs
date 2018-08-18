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
    }
}
