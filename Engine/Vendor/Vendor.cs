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

        //<----------Vendor's inventory---------->
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

        
        public void AddToInventory(object objectToBeAdded)
        {
            if(objectToBeAdded is Item)
            {
                AddItem((Item)objectToBeAdded);
            }
            else if(objectToBeAdded is Equipment)
            {
                AddEquipment((Equipment)objectToBeAdded);
            }
            else if(objectToBeAdded is Spell)
            {
                AddSpell((Spell)objectToBeAdded);
            }
            else
            {
                throw new Exception("Trying to add an object that cannot be added to vendor's inventory");
            }
        }

        public void RemoveFromInventory(object objectToBeRemoved)
        {
            if (objectToBeRemoved is Item)
            {
                RemoveItem((Item)objectToBeRemoved);
            }
            else if (objectToBeRemoved is Equipment)
            {
                RemoveEquipment((Equipment)objectToBeRemoved);
            }
            else if (objectToBeRemoved is Spell)
            {
                RemoveSpell((Spell)objectToBeRemoved);
            }
            else
            {
                throw new Exception("Trying to remove an object that cannot be removed from vendor's inventory");
            }
        }

        private void AddItem(Item item)
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

        private void AddEquipment(Equipment equipment)
        {
            if(VendorEquipmentInventory != null)
            {
                VendorEquipmentInventory.Add(equipment);
            }
        }

        private void AddSpell(Spell spell)
        {
            if(VendorSpellInventory != null)
            {
                VendorSpellInventory.Add(spell);
            }
        }

        private void RemoveItem(Item item)
        {
            if (VendorItemInventory.ContainsKey(item))
            {
                if (VendorItemInventory[item] > 1)
                {
                    VendorItemInventory[item]--;
                }
                else
                {
                    VendorItemInventory.Remove(item);
                }
            }
            else
            {
                throw new Exception("Somehow the vendor is selling an item they don't own");
            }
        }

        private void RemoveEquipment(Equipment equipment)
        {
            if (VendorEquipmentInventory.Contains(equipment))
            {
                VendorEquipmentInventory.Remove(equipment);
            }
            else
            {
                throw new Exception("Somehow the vendor is selling a piece of equipment they don't own");
            }
        }

        private void RemoveSpell(Spell spell)
        {
            if (VendorSpellInventory.Contains(spell))
            {
                VendorSpellInventory.Remove(spell);
            }
            else
            {
                throw new Exception("Somehow the vendor is selling a spell they don't own");
            }
        }

        public override string ToString()
        {
            string info = "";

            info += ("ID: " + ID + "\n");
            info += ("Name: " + Name + "\n");
            info += ("Description " + Description + "\n");
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