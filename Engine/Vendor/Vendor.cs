using System;
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
        public string Description { get; set; }

        //Vendor's stuff that is for sale
        //Key is the item, Value is the quantity of the item
        public Dictionary<Item, int> VendorItemInventory { get; set; }
        public List<Equipment> VendorEquipmentInventory { get; set; }
        public List<Spell> VendorSpellInventory { get; set; }


        public Vendor(int id, string name, string description, Dictionary<Item, int> vendorItemInventory = null, 
            List<Equipment> vendorEquipmentInventory = null, List<Spell> vendorSpellInventory = null)
        {
            this.ID = id;
            this.Name = name;
            this.Description = description;
            this.VendorItemInventory = vendorItemInventory;
            this.VendorEquipmentInventory = vendorEquipmentInventory;
            this.VendorSpellInventory = vendorSpellInventory;
        }

        public void AddItem(Item item)
        {
            if(VendorItemInventory != null)
            {
                if (VendorItemInventory.ContainsKey(item))
                {
                    VendorItemInventory[item]++;
                }
                else
                {
                    VendorItemInventory.Add(item, 1);
                }
            }
        }

        public override string ToString()
        {
            string info = "";

            info += ("ID: " + ID.ToString() + "\n");
            info += ("Name: " + Name.ToString() + "\n");
            info += ("Description " + Description.ToString() + "\n");
            foreach(KeyValuePair<Item, int> vendorItem in VendorItemInventory)
            {
                info += ("Item: " + vendorItem.Key.Name + "\t" + "Quantity: " + vendorItem.Value + "\n");
            }
            foreach(Equipment equipmentItem in VendorEquipmentInventory)
            {
                info += ("Equipment: " + equipmentItem.Name + "\n");
            }
            foreach(Spell inventorySpell in VendorSpellInventory)
            {
                info += ("Spell: " + inventorySpell.Name + "\n");
            }

            return info;
        }
    }
}
