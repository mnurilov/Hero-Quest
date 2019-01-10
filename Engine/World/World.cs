using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public static class World
    {
        //<----------Item ID's---------->
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

        //<----------Equipment ID's---------->
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

        //<----------Spell ID's---------->
        private const int SpellIDFire = 1;
        private const int SpellIDThunder = 2;
        private const int SpellIDCure = 3;

        //<----------Vendor ID's---------->
        private const int VendorIDJohn = 1;
        private const int VendorIDBobby = 2;

        //<----------Inn ID's---------->
        private const int InnIDParadise = 1;
        private const int InnIDCozyInn = 2;

        //<----------Enemy ID's---------->
        private const int EnemyIDRat = 1;
        private const int EnemyIDSnake = 2;
        private const int EnemyIDOgre = 3;
        private const int EnemyIDDragon = 4;
        private const int EnemyIDSiren = 5;
        private const int EnemyIDSwampMonster = 6;

        //<----------Quest ID's---------->
        private const int QuestIDCleanTheSewers = 1;
        private const int QuestIDAntidoteConcoction = 2;
        private const int QuestIDFindTheSewers = 3;

        //<----------Location ID's---------->
        private const int LocationIDHome = 1;
        private const int LocationIDGrassPlains = 2;
        private const int LocationIDTown = 3;
        private const int LocationIDFarm = 4;
        private const int LocationIDBarn = 5;
        private const int LocationIDFarmHut = 6;
        private const int LocationIDAlley = 7;
        private const int LocationIDSewers = 8;
        private const int LocationIDPond = 9;
        private const int LocationIDSwamp = 10;

        //<----------List's which hold all things in the game world---------->
        private static readonly List<Item> items = new List<Item>();
        private static readonly List<Equipment> equipments = new List<Equipment>();
        private static readonly List<Spell> spells = new List<Spell>();
        private static readonly List<Vendor> vendors = new List<Vendor>();
        private static readonly List<Inn> inns = new List<Inn>();
        private static readonly List<Enemy> enemies = new List<Enemy>();
        private static readonly List<Quest> quests = new List<Quest>();
        private static readonly List<Location> locations = new List<Location>();


        static World()
        {
            PopulateItems();
            PopulateEquipments();
            PopulateSpells();

            //Vendors must be after items, equipments, and spells so that they can have those objects in their shop
            PopulateVendors();

            PopulateInns();
            PopulateEnemies();
            PopulateQuests();

            //Locations are last to populate because everything else must be generated before locations
            PopulateLocations();
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

        //Finds a specific vendor based on ID
        public static Vendor FindVendorByID(int ID)
        {
            foreach (Vendor vendor in vendors)
            {
                if (vendor.ID == ID)
                {
                    return vendor;
                }
            }
            return null;
        }

        //Finds a specific inn based on ID
        public static Inn FindInnByID(int ID)
        {
            foreach (Inn inn in inns)
            {
                if (inn.ID == ID)
                {
                    return inn;
                }
            }
            return null;
        }

        //Finds a specific enemy based on ID
        public static Enemy FindEnemyByID(int ID)
        {
            foreach (Enemy enemy in enemies)
            {
                if (enemy.ID == ID)
                {
                    return enemy;
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

        //Finds a specific location based on (x,y) coordinates, used for displaying the map
        public static Location FindLocationByCoordinate(int x, int y)
        {
            foreach(Location location in locations)
            {
                if(location.XCoordinate == x && location.YCoordinate == y)
                {
                    return location;
                }
            }
            return null;
        }

        //Finds a specific location based on name
        public static Location FindLocationByName(string name)
        {
            foreach (Location location in locations)
            {
                if (location.Name == name)
                {
                    return location;
                }
            }
            return null;
        }

        //<----------Population Functions----------->
        private static void PopulateItems()
        {
            //Format of Item Creation:
            //(Item ID, Name, Description, GoldValue, Optional Item Affect Value)
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
            //Format of Equipment Creation:
            //(Equipment ID, Name, Description, Gold Value, 
            //Health Bonus, Mana Bonus, Strength Bonus, Defense Bonus, Luck Bonus, Speed Bonus, Intellect Bonus, Resistance Bonus)
            equipments.Add(new HeadEquipment(HeadEquipmentIDBronzeHelmet, "Bronze Helmet", "A crummy helmet", 10, 5, 0, 0, 5, 0, 0, 0, 0));
            equipments.Add(new ChestEquipment(ChestEquipmentIDBronzeChestPlate, "Bronze Chest Plate", "A crummy chest plate", 10, 15, 0, 0, 15, 0, 0, 0, 0));
            equipments.Add(new LegEquipment(LegEquipmentIDBronzeLeggings, "Bronze Leggings", "A crummy leggings", 10, 1000, 0, 0, 0, 0, 0, 0, 0));
            equipments.Add(new Sword(WeaponEquipmentIDBronzeSword, "Bronze Sword", "A crummy sword", 10, 0, 0, 10, 0, 0, 0, 0, 0));
            equipments.Add(new Shield(ShieldEquipmentIDBronzeShield, "Bronze Shield", "A crummy shield", 10, 0, 0, 0, 10, 0, 0, 0, 0));
            equipments.Add(new Dagger(DaggerEquipmentIDBronzeDagger, "Bronze Dagger", "A garbage dagger", 10, 10, 10, 10, 10, 10, 10, 10, 10));
            equipments.Add(new HeadEquipment(HeadEquipmentIDRuneHelmet, "Rune Helmet", "A top tier helmet", 100, 30, 0, 5, 30, 0, -5, 0, 0));
        }

        private static void PopulateSpells()
        {
            //Format of Spell Creation:
            //(Spell ID, Name, Description, Gold Value, Mana Cost, Spell Affect Value)
            spells.Add(new DamageSpell(SpellIDFire, "Fire", "Summons fire to burn your enemy", 10, 5, 10));
            spells.Add(new DamageSpell(SpellIDThunder, "Thunder", "Summons thunder to deafen your enemy", 20, 10, 50));
            spells.Add(new ReplenishSpell(SpellIDCure, "Cure", "Heals you", 10, 2, 20));
        }

        private static void PopulateVendors()
        {
            //Format of Vendor Creation:
            //(Vendor ID, Name, Description, Optional: Item Inventory, Optional: Equipment Inventory, Optional: Spell Inventory)
            Vendor john = new Vendor(VendorIDJohn, "John", "A business man at heart", new Dictionary<Item, int> { { FindItemByID(1), 4 } });
            john.AddToInventory(FindItemByID(3));

            Vendor bobby = new Vendor(VendorIDBobby, "Bobby", "A kind soul", null, new List<Equipment> { FindEquipmentByID(9) } );

            vendors.Add(john);
            vendors.Add(bobby);
        }

        private static void PopulateInns()
        {
            //Format of Inn Creation:
            //(Inn ID, Name, Description, Gold Cost For Admission, Inn Keeper)

            //<----------Inn Keeper Creation---------->
            Person innKeeperBilly = new Person("Billy", "Who cares", "Sup faggot");
            Person innKeeperMandy = new Person("Mandy", "Grumpy little shit", "Hates billy");

            //<----------Inn Creation---------->
            Inn paradise = new Inn(InnIDParadise, "Paradise", "Guess what it is", 30, innKeeperBilly);
            Inn cozyInn = new Inn(InnIDCozyInn, "Cozy Inn", "Til 9o'clockerino", 40, innKeeperMandy);

            //<----------Add inns to the inn list---------->
            inns.Add(paradise);
            inns.Add(cozyInn);
        }

        private static void PopulateEnemies()
        {
            //Format of Enemy Creation:
            //(Enemy ID, Name, Description, 
            //Maximum Health, Maximum Mana, Strength, Defense, Luck, Speed, Intellect, Resistance, Critical Rate, Dodge Rate,
            //Reward Gold, Reward Experience Points, Rate of Casting Spell, Optional: Weapon Used For Battle, Optional: List of Spells,
            //Optional: Enemy Loot)

            //<----------Enemy Loot Creation---------->
            Dictionary<Item, int> ratLoots = new Dictionary<Item, int>();
            ratLoots.Add(FindItemByID(7), 100);

            Dictionary<Item, int> snakeLoots = new Dictionary<Item, int>();
            snakeLoots.Add(FindItemByID(9), 50);

            //<-----------Enemy Spell Creation----------->
            List<Spell> sirenSpells = new List<Spell>();
            sirenSpells.Add(FindSpellByID(2));
            sirenSpells.Add(FindSpellByID(3));

            //<----------Enemy Creation---------->
            Enemy rat = new Enemy(EnemyIDRat, "Rat", "A small rodent", 5, 0, 3, 0, 0, 0, 0, 0, 10, 10, 10, 10, 0, null, "claws", ratLoots);
            Enemy snake = new Enemy(EnemyIDSnake, "Snake", "A slippery snek", 5, 0, 5, 5, 10, 6, 0, 5, 15, 15, 15, 15, 0, null, "fangs", snakeLoots);
            //Enemy ogre = new Enemy(EnemyIDOgre, "Ogre", "A horrendous creature", 30, 0, 15, 10, 0, 0, 0, 0, 5, 5, 100, 100, 0);
            //Enemy dragon = new Enemy(EnemyIDDragon, "Dragon", "A fearsome beast", 300, 50, 100, 50, 0, 50, 0, 50, 10, 10, 1000, 1000, 0);
            Enemy siren = new Enemy(EnemyIDSiren, "Siren", "She's hot", 30, 50, 5, 5, 5, 5, 10, 10, 30, 30, 20, 100, 50, sirenSpells, "tail");
            Enemy swampMonster = new Enemy(EnemyIDSwampMonster, "Swamp Monster", "He isa swamp monster", 60, 0, 30, 5, 0, 0, 0, 0, 5, 2, 100, 300, 0);

            //<-----------Making a boss monster--------------->
            swampMonster.IsBoss = true;

            //<----------Add enemies to the enemy list---------->
            enemies.Add(rat);
            enemies.Add(snake);
            //enemies.Add(ogre);
            //enemies.Add(dragon);
            enemies.Add(siren);
            enemies.Add(swampMonster);
        }

        private static void PopulateQuests()
        {
            //Format of Quest Creation:
            //(Quest ID, Name, Description, Quest Giver, Quest Requirements, Optional: Quest Gold Reward, 
            //Optional: Quest Experience Points Reward, Optional: Quest Reward Item, Optional: Quest Reward Equipment,
            //Optional: Quest Reward Spell)

            //<-----------Quest Giver Creation----------->
            Person bob = new Person("Bob", "An average joe", "Hey help I got rats!");
            Person mary = new Person("Mary", "A sassy child", "Hey I lost my pet snake");
            Person garry = new Person("Garry", "His grandpa doesn't love him", "Hey go to the sewers");

            //<-----------Quest Creation---------->
            Quest cleanTheSewers = new KillQuest(QuestIDCleanTheSewers, "Clean the Sewers", "Kill 3 rats in the sewers to help clean out the place",
                bob, new Dictionary<Enemy, int> { { FindEnemyByID(1), 3 } }, 10, 5, null, null, FindSpellByID(1));

            Quest antidoteConcoction = new GatherQuest(QuestIDAntidoteConcoction, "Antidote Concoction",
                "Bring me 3 snake fangs so I can make the antidote", mary, new Dictionary<EnemyLoot, int> { { (EnemyLoot)FindItemByID(9), 3 } },
                5, 10, null, FindEquipmentByID(4));

            Quest findTheSewers = new TravelQuest(QuestIDFindTheSewers, "Find the Sewers", "Go to the sewers and come back", garry,
                FindLocationByID(8), 10, 100, null, FindEquipmentByID(5));

            //<----------Add quests to the quest list---------->
            quests.Add(cleanTheSewers);
            quests.Add(antidoteConcoction);
            quests.Add(findTheSewers);
        }

        private static void PopulateLocations()
        {
            //Format of Location Creation:
            //(Location ID, Name, Description, Chance of Encountering an Enemy, X Coordinate, Y Coordinate)

            //<----------Creation of Locations----------->
            Location house = new Location(LocationIDHome, "House", "Hey it's your house, it's dirty!", 0, 0, 0);
            Location grassyPlains = new Location(LocationIDGrassPlains, "Grassy Plains", "A nice vibrant grassy plains", 100, 0, 1);
            Location town = new Location(LocationIDTown, "Town", "What a beautiful town", 0, 0, 2);
            Location farm = new Location(LocationIDFarm, "Farm", "It's a farm! Alright I'm bored back to my phone", 0, 1, 2);
            Location barn = new Location(LocationIDBarn, "Barn", "It smells terrible in here", 100, 1, 3);
            Location farmHut = new Location(LocationIDFarmHut, "Farm Hut", "It's the farmer's hut, say hello!", 0, 2, 2);
            Location alley = new Location(LocationIDAlley, "Alley", "It is a scary alley way", 0, -1, 2);
            Location sewers = new Location(LocationIDSewers, "Sewers", "Icky and Wicked", 0, -2, 2);
            Location pond = new Location(LocationIDPond, "Pond", "Calming mist", 100, 0, -1);
            Location swamp = new Location(LocationIDSwamp, "Swamp", "A run down sadden place", 100, -1, 0);

            //<----------Linking up the locations---------->
            house.LocationToTheNorth = grassyPlains;
            house.LocationToTheSouth = pond;
            house.LocationToTheWest = swamp;

            grassyPlains.LocationToTheNorth = town;
            grassyPlains.LocationToTheSouth = house;

            town.LocationToTheSouth = grassyPlains;
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

            pond.LocationToTheNorth = house;

            swamp.LocationToTheEast = house;

            //<----------Add vendors to the locations---------->
            town.VendorInLocation = FindVendorByID(1);

            //<----------Add inns to the locations---------->
            town.InnInLocation = FindInnByID(1);
            farmHut.InnInLocation = FindInnByID(2);

            //<----------Add enemies to the locations---------->
            //Note: Enemy weights must be ordered from least to greatest
            grassyPlains.EnemiesInLocation = new Dictionary<Enemy, int> { { FindEnemyByID(1), 30 } };
            barn.EnemiesInLocation = new Dictionary<Enemy, int> { { FindEnemyByID(2), 1 } };
            pond.EnemiesInLocation = new Dictionary<Enemy, int> { { FindEnemyByID(5), 1 } };
            swamp.BossInLocation = FindEnemyByID(6);

            //<----------Add quests to the locations---------->
            town.QuestInLocation = FindQuestByID(1);
            farmHut.QuestInLocation = FindQuestByID(2);
            alley.QuestInLocation = FindQuestByID(3);

            //<-----------Add locations to the location list---------->
            locations.Add(house);
            locations.Add(grassyPlains);
            locations.Add(town);
            locations.Add(farm);
            locations.Add(barn);
            locations.Add(farmHut);
            locations.Add(alley);
            locations.Add(sewers);
            locations.Add(pond);
            locations.Add(swamp);

            //Link Travel Quests with their Destination Location
            UpdateTravelQuests();
            ((TravelQuest)quests[2]).RequiredLocation = FindLocationByID(8);
        }

        private static void UpdateTravelQuests()
        {

        }
    }
}