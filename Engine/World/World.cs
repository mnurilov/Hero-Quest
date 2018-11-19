using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public static class World
    {
        //Item ID's
        private const int ItemIDBasicPotion = 1;
        private const int ItemIDMegaPotion = 2;
        private const int ItemIDHyperPotion = 3;
        private const int ItemIDBasicEther = 4;
        private const int ItemIDMegaEther = 5;
        private const int ItemIDHyperEther = 6;
        private const int ItemIDRatTail = 7;
        private const int ItemIDRatCarcass = 8;
        private const int ItemIDSnakeFang = 9;
        private const int ItemIDOgreTooth = 10;

        //Equipment ID's
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
        
        //Spell ID's
        private const int SpellIDFire = 1;
        private const int SpellIDThunder = 2;
        private const int SpellIDCure = 3;
        
        //Enemy ID's
        private const int EnemyIDRat = 1;
        private const int EnemyIDSnake = 2;
        private const int EnemyIDOgre = 3;
        private const int EnemyIDDragon = 4;

        //Person ID's
        private const int PersonIDBob = 1;
        private const int PersonIDMary = 2;

        //Quest ID's
        private const int QuestIDCleanTheSewers = 1;
        private const int QuestIDAntidoteConcoction = 2;

        //Vendor ID's
        private const int VendorIDJohn = 1;
        private const int VendorIDBobby = 2;

        //Location ID's
        private const int LocationIDHome = 1;
        private const int LocationIDGrassPlains = 2;
        private const int LocationIDTown = 3;
        private const int LocationIDFarm = 4;
        private const int LocationIDBarn = 5;
        private const int LocationIDFarmHut = 6;

        


        private static readonly List<Item> items = new List<Item>();
        private static readonly List<Enemy> enemies = new List<Enemy>();
        private static readonly List<Location> locations = new List<Location>();
        private static readonly List<Vendor> vendors = new List<Vendor>();
        private static readonly List<Equipment> equipments = new List<Equipment>();
        private static readonly List<Spell> spells = new List<Spell>();
        private static readonly List<Quest> quests = new List<Quest>();

        static World()
        {
            PopulateItems();
            PopulateEquipments();
            PopulateSpells();
            PopulateEnemies();
            PopulateQuests();
            //Put the vendors after the item and equipment spawns so that it can load the items
            PopulateVendors(); 

            //Put this last because it needs everything else to be loaded first
            PopulateLocations();
        }

        private static void PopulateItems()
        {
            items.Add(new HealthReplenishingItem(ItemIDBasicPotion, "Basic Potion", "A simple potion", 5));
            items.Add(new HealthReplenishingItem(ItemIDMegaPotion, "Mega Potion", "An advanced potion", 15));
            items.Add(new HealthReplenishingItem(ItemIDHyperPotion, "Hyper Potion", "An elite potion", 30));
            items.Add(new ManaReplenishingItem(ItemIDBasicEther, "Basic Ether", "A simple ether", 4));
            items.Add(new ManaReplenishingItem(ItemIDMegaEther, "Mega Ether", "An advanced ether", 16));
            items.Add(new ManaReplenishingItem(ItemIDHyperEther, "Hyper Ether", "An elite ether", 36));
        }

        private static void PopulateEquipments()
        {
            equipments.Add(new HeadEquipment(HeadEquipmentIDBronzeHelmet, "Bronze Helmet", "A crummy helmet", 5, 0, 0, 5, 0, 0, 0, 0));
            equipments.Add(new ChestEquipment(ChestEquipmentIDBronzeChestPlate, "Bronze Chest Plate", "A crummy chest plate", 15, 0, 0, 15, 0, 0, 0, 0));
            equipments.Add(new LegEquipment(LegEquipmentIDBronzeLeggings, "Bronze Leggings", "A crummy leggings", 0, 0, 0, 10, 0, 0, 0, 0));
            equipments.Add(new Sword(WeaponEquipmentIDBronzeSword, "Bronze Sword", "A crummy sword", 0, 0, 10, 0, 0, 0, 0, 0));
            equipments.Add(new Shield(ShieldEquipmentIDBronzeShield, "Bronze Shield", "A crummy shield", 0, 0, 0, 10, 0, 0, 0, 0));
        }

        private static void PopulateSpells()
        {
            spells.Add(new DamageSpell(SpellIDFire, "Fire", "Summons fire to burn your enemy", 5, 10));
            spells.Add(new DamageSpell(SpellIDThunder, "Thunder", "Summons thunder to deafen your enemy", 10, 50));
            spells.Add(new ReplenishSpell(SpellIDCure, "Cure", "Heals you", 10, 20));
        }

        private static void PopulateEnemies()
        {
            List<EnemyLoot> enemyLoots = new List<EnemyLoot>();
            enemyLoots.Add((EnemyLoot)FindItemByID(7));
            
            Enemy rat = new Enemy(EnemyIDRat, "Rat", "A small rodent", 5, 0, 3, 0, 0, 0, 0, 0, 10, 10, 10, 10, enemyLoots);
            Enemy snake = new Enemy(EnemyIDSnake, "Snake", "A slippery snek", 5, 0, 5, 5, 10, 6, 0, 5, 15, 15, 15, 15);
            Enemy ogre = new Enemy(EnemyIDOgre, "Ogre", "A horrendous creature", 30, 0, 15, 10, 0, 0, 0, 0, 5, 5, 100, 100);
            Enemy dragon = new Enemy(EnemyIDDragon, "Dragon", "A fearsome beast", 300, 50, 100, 50, 0, 50, 0, 50, 10, 10, 1000, 1000);

            enemies.Add(rat);
            enemies.Add(snake);
            enemies.Add(ogre);
            enemies.Add(dragon);
        }

        private static void PopulateQuests()
        {
            Person bob = new Person(PersonIDBob, "Bob", "An average joe", "Hey help I got rats!");
            Person mary = new Person(PersonIDMary, "Mary", "A sassy child", "Hey I lost my pet snake");

            Quest cleanTheSewers = new KillQuest(QuestIDCleanTheSewers, "Clean the Sewers", "Kill 3 rats in the sewers to help clean out the place",
                bob, new Dictionary<Enemy, int>{ {FindEnemyByID(1), 3} }, 10, 5);

            Quest antidoteConcoction = new GatherQuest(QuestIDAntidoteConcoction, "Antidote Concoction", 
                "Bring me 3 snake fangs so I can make the antidote", mary, new Dictionary<EnemyLoot, int> { { (EnemyLoot)FindItemByID(9), 3 } },
                5, 10);

            quests.Add(cleanTheSewers);
            quests.Add(antidoteConcoction);
        }

        private static void PopulateVendors()
        {
            Vendor John = new Vendor(VendorIDJohn, "John", "A business man at heart", new Dictionary<Item, int>{ { FindItemByID(1), 4} });
            
            vendors.Add(John);
        }

        private static void PopulateLocations()
        {
            //Creation of locations
            Location home = new Location(LocationIDHome, "House", "Hey it's your house, it's dirty!", 0);
            Location grassPlains = new Location(LocationIDGrassPlains, "Grassy Plains", "A nice vibrant grassy plains", 50);
            Location town = new Location(LocationIDTown, "Town", "What a beautiful town", 0);
            Location farm = new Location(LocationIDFarm, "Farm", "It's a farm! Alright I'm bored back to my phone", 50);
            Location barn = new Location(LocationIDBarn, "Barn", "It smells terrible in here", 50);
            Location farmHut = new Location(LocationIDFarmHut, "Farm Hut", "It's the farmer's hut, say hello!", 100);


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


            //Add enemies to the locations
            grassPlains.EnemiesInLocation = new Dictionary<Enemy, int> { { FindEnemyByID(1), 30 }, { FindEnemyByID(2), 10 } };

            //Add the locations to list
            locations.Add(home);
            locations.Add(grassPlains);
            locations.Add(town);
            locations.Add(farm);
            locations.Add(barn);
            locations.Add(farmHut);
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
            foreach (Equipment equipment in equipments)
            {
                Console.WriteLine(equipment.ToString());
                Console.ReadKey();
            }
        }

        public static void ViewSpells()
        {
            foreach (Spell spell in spells)
            {
                Console.WriteLine(spell.ToString());
                Console.ReadKey();
            }
        }

        public static void ViewQuests()
        {
            foreach(Quest quest in quests)
            {
                Console.WriteLine(quest.ToString());
                Console.ReadKey();
            }
        }

        public static void ViewEnemies()
        {
            foreach(Enemy enemy in enemies)
            {
                Console.WriteLine(enemy.ToString());
                Console.ReadKey();
            }
        }

        //Finds a specific enemy based on ID
        public static Enemy FindEnemyByID(int ID)
        {
            foreach(Enemy enemy in enemies)
            {
                if(enemy.ID == ID)
                {
                    return enemy;
                }
            }
            return null;
        }

        //Finds a specific item based on ID
        public static Item FindItemByID(int ID)
        {
            foreach (Item item in items)
            {
                if (item.ID == ID)
                {
                    return item;
                }
            }
            return null;
        }

        //Finds a specific equipment piece based on ID
        public static Equipment FindEquipmentByID(int ID)
        {
            foreach (Equipment equipment in equipments)
            {
                if (equipment.ID == ID)
                {
                    return equipment;
                }
            }
            return null;
        }

        //Finds a specific spell based on ID
        public static Spell FindSpellByID(int ID)
        {
            foreach(Spell spell in spells)
            {
                if(spell.ID == ID)
                {
                    return spell;
                }
            }
            return null;
        }

        //Finds a specific quest based on ID
        public static Quest FindQuestByID(int ID)
        {
            foreach(Quest quest in quests)
            {
                if(quest.ID == ID)
                {
                    return quest;
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

        //Finds a specific location based on ID
        public static Location FindLocationByID(int ID)
        {
            foreach (Location location in locations)
            {
                if (location.ID == ID)
                {
                    return location;
                }
            }
            return null;
        }
    }
}