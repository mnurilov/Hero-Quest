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
        #endregion

        static World()
        {
            PopulateLocations();
            PopulateItems();
            /*
            PopulateEnemies();
            LoadEquipment();
            LoadSpells();
            LoadItems();
            LoadQuests();
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

        public static void ViewItems()
        {
            foreach(Item item in items)
            {
                Console.WriteLine(item.ToString());
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
    }
}
