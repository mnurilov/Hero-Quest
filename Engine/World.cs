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
        #region Variables
        private const int EnemyIDRat = 1;

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
            Location home = new Location(LocationIDHome, "House", "Hey it's your house, it's dirty!");
            Location grassPlains = new Location(LocationIDGrassPlains, "Grassy Plains", "A nice vibrant grassy plains");
            Location town = new Location(LocationIDTown, "Town", "What a beautiful town");
            Location farm = new Location(LocationIDFarm, "Farm", "It's a farm! Alright I'm bored back to my phone");
            Location barn = new Location(LocationIDBarn, "Barn", "It smells terrible in here");
            Location farmHut = new Location(LocationIDFarmHut, "Farm Hut", "It's the farmer's hut, say hello!");

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

            locations.Add(home);
            locations.Add(grassPlains);
            locations.Add(town);
            locations.Add(farm);
            locations.Add(barn);
            locations.Add(farmHut);
        }

        private static void PopulateEnemies()
        {

        }

        public static Location FindLocationByID(int ID)
        {
            foreach(Location loc in locations)
            {
                if(loc.ID == ID)
                {
                    return loc;
                }
            }
            return null;
        }
    }
}
