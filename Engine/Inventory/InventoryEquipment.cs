using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class InventoryEquipment
    {
        public Equipment Equipment;
        public int Quantity { get; set; }

        public InventoryEquipment(Equipment equipment, int quantity)
        {
            this.Equipment = equipment;
            this.Quantity = quantity;
        }

        public override string ToString()
        {
            string info = "";

            info += Equipment.ToString();
            info += ("Quantity: " + Quantity.ToString() + "\n");
            
            return info;
        }
    }
}
