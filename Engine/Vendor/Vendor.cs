﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Vendor
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<InventoryItem> VendorItemInventory = new List<InventoryItem>();
        public List<InventoryEquipment> VendorEquipmentInventory = new List<InventoryEquipment>();
        public List<Spell> VendorSpellInventory = new List<Spell>();

        public Vendor(int ID, string Name)
        {
            this.ID = ID;
            this.Name = Name;
        }

        //Make this show item description 
        public override string ToString()
        {
            string info = "";

            info += ("ID: " + ID.ToString() + "\n");
            info += ("Name: " + Name.ToString() + "\n");
            foreach(InventoryItem inventoryItem in VendorItemInventory)
            {
                info += (inventoryItem.Item.Name + ", Quantity: " + inventoryItem.Quantity + "\n");
            }
            foreach (InventoryEquipment equipmentItem in VendorEquipmentInventory)
            {
                info += (equipmentItem.Equipment.Name + ", Quantity: " + equipmentItem.Quantity + "\n");
            }
            foreach(Spell inventorySpell in VendorSpellInventory)
            {
                info += (inventorySpell.ToString() + "\n");
            }

            return info;
        }
    }
}
