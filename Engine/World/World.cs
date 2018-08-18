using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public static class World
    {
        private static readonly List<Enemy> enemies = new List<Enemy>();
        private static readonly List<Location> locations = new List<Location>();
        private static readonly List<Item> items = new List<Item>();
        //private static readonly List<InventoryItem> items = new List<InventoryItem>();
        private static readonly List<Vendor> vendors = new List<Vendor>();
        private static readonly List<Equipment> equipments = new List<Equipment>();

        #region Variables
        private const int EnemyIDRat = 1;

        private const int ItemIDBasicPotion = 1;
        private const int ItemIDMegaPotion = 2;
        private const int ItemIDHyperPotion = 3;
        private const int ItemIDBasicEther = 4;
        private const int ItemIDMegaEther = 5;
        private const int ItemIDHyperEther = 6;

        private const int LocationIDHome = 1;
        private const int LocationIDGrassPlains = 2;
        private const int LocationIDTown = 3;
        private const int LocationIDFarm = 4;
        private const int LocationIDBarn = 5;
        private const int LocationIDFarmHut = 6;

        private const int VendorIDJohn = 1;
        private const int VendorIDBobby = 2;

        private const int HeadEquipmentIDBronzeHelmet = 1;
        private const int HeadEquipmentIDRuneHelmet = 2;
        private const int ChestEquipmentIDBronzeChestPlate = 3;
        private const int ChestEquipmentIDRuneChestPlate = 4;
        private const int LegEquipmentIDBronzeLeggings = 5;
        private const int LegEquipmentIDRuneLeggings = 6;
        private const int WeaponEquipmentIDBronzeSword = 7;
        private const int WeaponEquipmentIDRuneSword = 8;
        private const int ShieldEquipmentIDBronzeShield = 9;
        private const int ShieldEquipmentIDRuneShield = 10;
        private const int TomeEquipmentIDBronzeTome = 11;
        private const int TomeEquipmentIDRuneTome = 12;

        #endregion

        static World()
        {
            PopulateItems();
            PopulateEquipments();

            //Put the vendors after the item and equipment spawns so that it can load the items
            PopulateVendors();
            
            //Put this last because it needs everything else to be loaded first
            PopulateLocations();
            /*
            PopulateEnemies();
            LoadEquipment();
            LoadSpells();
            LoadItems();
            LoadQuests();
            PopulateVendors();
            */
        }
        
        private static void PopulateLocations()
        {
            //Creation of locations
            Location home = new Location(LocationIDHome, "House", "Hey it's your house, it's dirty!");
            Location grassPlains = new Location(LocationIDGrassPlains, "Grassy Plains", "A nice vibrant grassy plains");
            Location town = new Location(LocationIDTown, "Town", "What a beautiful town");
            Location farm = new Location(LocationIDFarm, "Farm", "It's a farm! Alright I'm bored back to my phone");
            Location barn = new Location(LocationIDBarn, "Barn", "It smells terrible in here");
            Location farmHut = new Location(LocationIDFarmHut, "Farm Hut", "It's the farmer's hut, say hello!");


            //Linking up the locations
            home.LocationToTheNorth = grassPlains;

            grassPlains.LocationToTheNorth = town;
            grassPlains.LocationToTheSouth = home;

            town.LocationToTheEast = farm;
            town.LocationToTheSouth = grassPlains;

            farm.LocationToTheNorth = barn;
            farm.LocationToTheEast = farmHut;
            farm.LocationToTheWest = town;

            barn.LocationToTheSouth = farm;

            farmHut.LocationToTheWest = farm;


            //Added vendors to the locations
            town.VendorInLocation = FindVendorByID(1);
            farmHut.VendorInLocation = FindVendorByID(2);


            //Add the locations to list
            locations.Add(home);
            locations.Add(grassPlains);
            locations.Add(town);
            locations.Add(farm);
            locations.Add(barn);
            locations.Add(farmHut);
        }

        private static void PopulateItems()
        {
            items.Add(new HealthReplenishingItem(ItemIDBasicPotion, "Basic Potion", 5));
            items.Add(new HealthReplenishingItem(ItemIDMegaPotion, "Mega Potion", 15));
            items.Add(new HealthReplenishingItem(ItemIDHyperPotion, "Hyper Potion", 30));
            items.Add(new ManaReplenishingItem(ItemIDBasicEther, "Basic Ether", 4));
            items.Add(new ManaReplenishingItem(ItemIDMegaEther, "Mega Ether", 16));
            items.Add(new ManaReplenishingItem(ItemIDHyperEther, "Hyper Ether", 36));
        }

        public static void PopulateEquipments()
        {
            equipments.Add(new HeadEquipment(HeadEquipmentIDBronzeHelmet, "Bronze Helmet", 5, 0, 0, 5, 0, 0, 0, 0));
            equipments.Add(new HeadEquipment(HeadEquipmentIDRuneHelmet, "Rune Helmet", 10, 0, 0, 10, 0, 0, 0, 0));
            equipments.Add(new HeadEquipment(ChestEquipmentIDBronzeChestPlate, "Bronze Chest Plate", 15, 0, 0, 15, 0, 0, 0, 0));
            equipments.Add(new HeadEquipment(ChestEquipmentIDRuneChestPlate, "Rune Chest Plate", 30, 0, 0, 30, 0, 0, 0, 0));
            equipments.Add(new HeadEquipment(LegEquipmentIDBronzeLeggings, "Bronze Leggings", 10, 0, 0, 10, 0, 0, 0, 0));
            equipments.Add(new HeadEquipment(LegEquipmentIDRuneLeggings, "Rune Leggings", 20, 0, 0, 20, 0, 0, 0, 0));
            equipments.Add(new HeadEquipment(WeaponEquipmentIDBronzeSword, "Bronze Sword", 0, 0, 10, 0, 0, 0, 0, 0));
            equipments.Add(new HeadEquipment(WeaponEquipmentIDRuneSword, "Rune Sword", 0, 0, 0, 30, 0, 0, 0, 0));
            equipments.Add(new HeadEquipment(ShieldEquipmentIDBronzeShield, "Bronze Shield", 0, 0, 0, 0, 10, 0, 0, 0));
            equipments.Add(new HeadEquipment(ShieldEquipmentIDRuneShield, "Rune Shield", 5, 0, 0, 0, 30, 0, 0, 0));
            equipments.Add(new HeadEquipment(TomeEquipmentIDBronzeTome, "Bronze Tome", 0, 10, 0, 0, 0, 0, 15, 0));
            equipments.Add(new HeadEquipment(TomeEquipmentIDRuneTome, "Rune Tome", 0, 30, 0, 5, 0, 0, 30, 0));
        }

        private static void PopulateVendors()
        {
            Vendor John = new Vendor(VendorIDJohn, "John");
            Vendor Bobby = new Vendor(VendorIDBobby, "Bobby");

            John.VendorItemInventory.Add(new InventoryItem(FindItemByID(1), 5));
            John.VendorItemInventory.Add(new InventoryItem(FindItemByID(2), 3));
            John.VendorItemInventory.Add(new InventoryItem(FindItemByID(3), 2));

            John.VendorEquipmentInventory.Add(new InventoryEquipment(FindEquipmentByID(1), 1));
            John.VendorEquipmentInventory.Add(new InventoryEquipment(FindEquipmentByID(2), 1));
            John.VendorEquipmentInventory.Add(new InventoryEquipment(FindEquipmentByID(3), 1));
            John.VendorEquipmentInventory.Add(new InventoryEquipment(FindEquipmentByID(4), 17));
            John.VendorEquipmentInventory.Add(new InventoryEquipment(FindEquipmentByID(5), 6));
            John.VendorEquipmentInventory.Add(new InventoryEquipment(FindEquipmentByID(6), 3));

            Bobby.VendorItemInventory.Add(new InventoryItem(FindItemByID(4), 9));
            Bobby.VendorItemInventory.Add(new InventoryItem(FindItemByID(5), 7));
            Bobby.VendorItemInventory.Add(new InventoryItem(FindItemByID(6), 1)); 

            Bobby.VendorEquipmentInventory.Add(new InventoryEquipment(FindEquipmentByID(7), 12));
            Bobby.VendorEquipmentInventory.Add(new InventoryEquipment(FindEquipmentByID(8), 13));
            Bobby.VendorEquipmentInventory.Add(new InventoryEquipment(FindEquipmentByID(9), 4));
            Bobby.VendorEquipmentInventory.Add(new InventoryEquipment(FindEquipmentByID(10), 1));
            Bobby.VendorEquipmentInventory.Add(new InventoryEquipment(FindEquipmentByID(11), 9));
            Bobby.VendorEquipmentInventory.Add(new InventoryEquipment(FindEquipmentByID(12), 4));

            vendors.Add(John);
            vendors.Add(Bobby);
        }

        public static void ViewItems()
        {
            foreach(Item item in items)
            {
                Console.WriteLine(item.ToString());
                Console.ReadKey();
            }
        }
        public static void ViewEquipment()
        {
            foreach (Item equipment in equipments)
            {
                Console.WriteLine(equipment.ToString());
                Console.ReadKey();
            }
        }

        private static void PopulateEnemies()
        {

        }

        //Finds a specific location based on ID
        public static Location FindLocationByID(int ID)
        {
            foreach(Location location in locations)
            {
                if(location.ID == ID)
                {
                    return location;
                }
            }
            return null;
        }

        //Finds a specific item based on ID
        public static Item FindItemByID(int ID)
        {
            foreach(Item item in items)
            {
                if(item.ID == ID)
                {
                    return item;
                }
            }
            return null;
        }

        //Finds a specific equipment piece based on ID
        public static Equipment FindEquipmentByID(int ID)
        {
            foreach(Equipment equipment in equipments)
            {
                if(equipment.ID == ID)
                {
                    return equipment;
                }
            }
            return null;
        }

        //Finds a specific vendor based on ID
        public static Vendor FindVendorByID(int ID)
        {
            foreach(Vendor vendor in vendors)
            {
                if(vendor.ID == ID)
                {
                    return vendor;
                }
            }
            return null;
        }
    }
}
