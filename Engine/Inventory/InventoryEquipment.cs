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

        public InventoryEquipment(Equipment Equipment, int Quantity)
        {
            this.Equipment = Equipment;
            this.Quantity = Quantity;
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
