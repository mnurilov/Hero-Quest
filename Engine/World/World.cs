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
        private const int ItemIDFireInJar = 11;

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
        private const int DaggerEquipmentIDBronzeDagger = 13;
        
        //Spell ID's
        private const int SpellIDFire = 1;
        private const int SpellIDThunder = 2;
        private const int SpellIDCure = 3;
        
        //Enemy ID's
        private const int EnemyIDRat = 1;
        private const int EnemyIDSnake = 2;
        private const int EnemyIDOgre = 3;
        private const int EnemyIDDragon = 4;
        private const int EnemyIDSiren = 5;

        //Person ID's
        private const int PersonIDBob = 1;
        private const int PersonIDMary = 2;
        private const int PersonIDGarry = 3;

        //Quest ID's
        private const int QuestIDCleanTheSewers = 1;
        private const int QuestIDAntidoteConcoction = 2;
        private const int QuestIDFindTheSewers = 3;

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
        private const int LocationIDAlley = 7;
        private const int LocationIDSewers = 8;
        private const int LocationIDPond = 9;

        
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
            items.Add(new HealthReplenishingItem(ItemIDBasicPotion, "Basic Potion", "A simple potion", 5, 5));
            items.Add(new HealthReplenishingItem(ItemIDMegaPotion, "Mega Potion", "An advanced potion", 20, 15));
            items.Add(new HealthReplenishingItem(ItemIDHyperPotion, "Hyper Potion", "An elite potion", 50, 30));
            items.Add(new ManaReplenishingItem(ItemIDBasicEther, "Basic Ether", "A simple ether", 5, 4));
            items.Add(new ManaReplenishingItem(ItemIDMegaEther, "Mega Ether", "An advanced ether", 20, 16));
            items.Add(new ManaReplenishingItem(ItemIDHyperEther, "Hyper Ether", "An elite ether", 50, 36));
            items.Add(new EnemyLoot(ItemIDRatTail, "Rat Tail", "A severed tail", 10));
            items.Add(new EnemyLoot(ItemIDSnakeFang, "Snake Fang", "A fang of a snake", 30));
            items.Add(new DamageItem(ItemIDFireInJar, "Fire in Jar", "It's a fire in a jar", 20, 20));
        }

        private static void PopulateEquipments()
        {
            equipments.Add(new HeadEquipment(HeadEquipmentIDBronzeHelmet, "Bronze Helmet", "A crummy helmet", 10, 5, 0, 0, 5, 0, 0, 0, 0));
            equipments.Add(new ChestEquipment(ChestEquipmentIDBronzeChestPlate, "Bronze Chest Plate", "A crummy chest plate", 10, 15, 0, 0, 15, 0, 0, 0, 0));
            equipments.Add(new LegEquipment(LegEquipmentIDBronzeLeggings, "Bronze Leggings", "A crummy leggings", 10, 1000, 0, 0, 0, 0, 0, 0, 0));
            equipments.Add(new Sword(WeaponEquipmentIDBronzeSword, "Bronze Sword", "A crummy sword", 10, 0, 0, 10, 0, 0, 0, 0, 0));
            equipments.Add(new Shield(ShieldEquipmentIDBronzeShield, "Bronze Shield", "A crummy shield", 10, 0, 0, 0, 10, 0, 0, 0, 0));
            equipments.Add(new Dagger(DaggerEquipmentIDBronzeDagger, "Bronze Dagger", "A garbage dagger", 10, 10, 10, 10, 10, 10,10, 10, 10));
        }

        private static void PopulateSpells()
        {
            spells.Add(new DamageSpell(SpellIDFire, "Fire", "Summons fire to burn your enemy", 10, 5, 10));
            spells.Add(new DamageSpell(SpellIDThunder, "Thunder", "Summons thunder to deafen your enemy", 20, 10, 50));
            spells.Add(new ReplenishSpell(SpellIDCure, "Cure", "Heals you", 10, 10, 20));
        }

        private static void PopulateEnemies()
        {
            Dictionary<EnemyLoot, int> ratLoots = new Dictionary<EnemyLoot, int>();
            ratLoots.Add((EnemyLoot)FindItemByID(7), 100);

            Dictionary<EnemyLoot, int> snakeLoots = new Dictionary<EnemyLoot, int>();
            snakeLoots.Add((EnemyLoot)FindItemByID(9), 50);

            List<Spell> sirenSpells = new List<Spell>();
            sirenSpells.Add(FindSpellByID(2));
            sirenSpells.Add(FindSpellByID(3));

            Enemy rat = new Enemy(EnemyIDRat, "Rat", "A small rodent", 5, 0, 3, 0, 0, 0, 0, 0, 10, 10, 10, 10, 0, "claws", null, ratLoots);
            Enemy snake = new Enemy(EnemyIDSnake, "Snake", "A slippery snek", 5, 0, 5, 5, 10, 6, 0, 5, 15, 15, 15, 15, 0, "fangs", null, snakeLoots);
            Enemy ogre = new Enemy(EnemyIDOgre, "Ogre", "A horrendous creature", 30, 0, 15, 10, 0, 0, 0, 0, 5, 5, 100, 100, 0);
            Enemy dragon = new Enemy(EnemyIDDragon, "Dragon", "A fearsome beast", 300, 50, 100, 50, 0, 50, 0, 50, 10, 10, 1000, 1000, 0);
            Enemy siren = new Enemy(EnemyIDSiren, "Siren", "She's hot", 30, 50, 5, 5, 5, 5, 10, 10, 30, 30, 20, 100, 50, "tail", sirenSpells);

            enemies.Add(rat);
            enemies.Add(snake);
            enemies.Add(ogre);
            enemies.Add(dragon);
            enemies.Add(siren);
        }

        private static void PopulateQuests()
        {
            Person bob = new Person(PersonIDBob, "Bob", "An average joe", "Hey help I got rats!");
            Person mary = new Person(PersonIDMary, "Mary", "A sassy child", "Hey I lost my pet snake");
            Person garry = new Person(PersonIDGarry, "Garry", "His grandpa doesn't love him", "Hey go to the sewers");

            Quest cleanTheSewers = new KillQuest(QuestIDCleanTheSewers, "Clean the Sewers", "Kill 3 rats in the sewers to help clean out the place",
                bob, new Dictionary<Enemy, int>{ {FindEnemyByID(1), 3} }, 10, 5, null, null, FindSpellByID(1));

            Quest antidoteConcoction = new GatherQuest(QuestIDAntidoteConcoction, "Antidote Concoction", 
                "Bring me 3 snake fangs so I can make the antidote", mary, new Dictionary<EnemyLoot, int> { { (EnemyLoot)FindItemByID(9), 3 } },
                5, 10, null, FindEquipmentByID(4));

            Quest findTheSewers = new TravelQuest(QuestIDFindTheSewers, "Find the Sewers", "Go to the sewers and come back", garry,
                FindLocationByID(8), 10, 100, null, FindEquipmentByID(5));

            quests.Add(cleanTheSewers);
            quests.Add(antidoteConcoction);
            quests.Add(findTheSewers);
        }

        private static void PopulateVendors()
        {
            Vendor John = new Vendor(VendorIDJohn, "John", "A business man at heart", new Dictionary<Item, int>{ { FindItemByID(1), 4} });
            John.VendorItemInventory.Add(FindItemByID(3), 5);
            
            vendors.Add(John);
        }

        private static void PopulateLocations()
        {
            //Creation of locations
            Location home = new Location(LocationIDHome, "House", "Hey it's your house, it's dirty!", 0);
            Location grassPlains = new Location(LocationIDGrassPlains, "Grassy Plains", "A nice vibrant grassy plains", 100);
            Location town = new Location(LocationIDTown, "Town", "What a beautiful town", 0);
            Location farm = new Location(LocationIDFarm, "Farm", "It's a farm! Alright I'm bored back to my phone", 0);
            Location barn = new Location(LocationIDBarn, "Barn", "It smells terrible in here", 100);
            Location farmHut = new Location(LocationIDFarmHut, "Farm Hut", "It's the farmer's hut, say hello!", 0);
            Location alley = new Location(LocationIDAlley, "Alley", "It is a scary alley way", 0);
            Location sewers = new Location(LocationIDSewers, "Sewers", "Icky and Wicked", 0);
            Location pond = new Location(LocationIDPond, "Pond", "Calming mist", 100);

            //Linking up the locations
            home.LocationToTheNorth = grassPlains;
            home.LocationToTheSouth = pond;

            grassPlains.LocationToTheNorth = town;
            grassPlains.LocationToTheSouth = home;

            town.LocationToTheSouth = grassPlains;
            town.LocationToTheWest = alley;
            town.LocationToTheEast = farm;

            farm.LocationToTheNorth = barn;
            farm.LocationToTheEast = farmHut;
            farm.LocationToTheWest = town;

            barn.LocationToTheSouth = farm;

            farmHut.LocationToTheWest = farm;

            alley.LocationToTheEast = town;
            alley.LocationToTheWest = sewers;

            sewers.LocationToTheEast = alley;

            pond.LocationToTheNorth = home;


            //Added vendors to the locations
            town.VendorInLocation = FindVendorByID(1);


            //Add enemies to the locations ORDER THEM FROM LEAST TO GREATEST
            grassPlains.EnemiesInLocation = new Dictionary<Enemy, int> { { FindEnemyByID(1), 30 } };
            barn.EnemiesInLocation = new Dictionary<Enemy, int> { { FindEnemyByID(2), 1 } };
            pond.EnemiesInLocation = new Dictionary<Enemy, int> { { FindEnemyByID(5), 1 } };

            //Add quests to the locations
            town.QuestInLocation = FindQuestByID(1);
            farmHut.QuestInLocation = FindQuestByID(2);
            alley.QuestInLocation = FindQuestByID(3);

            //Add the locations to list
            locations.Add(home);
            locations.Add(grassPlains);
            locations.Add(town);
            locations.Add(farm);
            locations.Add(barn);
            locations.Add(farmHut);
            locations.Add(alley);
            locations.Add(sewers);
            locations.Add(pond);

            ((TravelQuest)quests[2]).RequiredLocation = FindLocationByID(8);
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