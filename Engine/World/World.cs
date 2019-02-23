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
        

        private const int ItemIDApple = 12;
        private const int ItemIDMilk = 13;
        private const int ItemIDFireInJar = 14;

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
        private const int NegativeHealthEquipmentID = 14;
        private const int NegativeManaEquipmentID = 15;
        private const int NegativeAttackEquipmentID = 16;
        private const int NegativeDefenseEquipmentID = 17;
        private const int NegativeLuckEquipmentID = 18;
        private const int NegativeSpeedEquipmentID = 19;
        private const int NegativeIntellectEquipmentID = 20;
        private const int NegativeResistanceEquipmentID = 21;

        //Starting Gear
        private const int HeadEquipmentIDLeatherCoif = 22;
        private const int ChestEquipmentIDLeatherBody = 23;
        private const int LegEquipmentIDLeatherChaps = 24;
        private const int SwordIDWoodenSword = 25;
        private const int StaffIDWoodenStaff = 26;
        private const int DaggerIDWoodenDagger = 27;

        //<----------Spell ID's---------->
        private const int SpellIDFire = 1;

        //<----------Vendor ID's---------->
        private const int VendorIDHermitBill = 1;

        //<----------Inn ID's---------->
        private const int InnIDRustyShack = 1;

        //<----------Enemy ID's---------->
        private const int EnemyIDAnt = 1;
        private const int EnemyIDWorm = 2;
        private const int EnemyIDBoar = 3;
        private const int EnemyIDSnake = 4;
        private const int EnemyIDSpider = 5;
        private const int EnemyIDMonkey = 6; //Boss


        //<----------Quest ID's---------->
        private const int QuestIDJimmysErrand = 1;
        private const int QuestIDCleanTheBarn = 2;
        private const int QuestIDTestLocation = 3;

        //<----------Location ID's---------->
        //Tutorial Area
        private const int LocationIDHome = 1;
        private const int LocationIDDirtPath = 2;
        private const int LocationIDJimmysHouse = 3;
        private const int LocationIDAppleOrchard1 = 4;
        private const int LocationIDAppleOrchard2 = 5;
        private const int LocationIDAppleOrchard3 = 6;
        private const int LocationIDHermitVillage = 7;
        private const int LocationIDFarmersHut = 8;
        private const int LocationIDFarm = 9;
        private const int LocationIDWoods1 = 10;
        private const int LocationIDWoods2 = 11;
        private const int LocationIDWoods3 = 12;
        private const int LocationIDWoods4 = 13;
        private const int LocationIDWoods5 = 14;
        private const int LocationIDRiver = 15;
        private const int LocationIDBridge = 16;

        //Route to the Kingdom
        private const int LocationIDGrassyPlains = 17;
        private const int LocationIDCrossRoads = 18;
        private const int LocationIDWestRoads = 19;
        private const int LocationIDEastRoads = 20;
        private const int LocationIDRiver1 = 21;
        private const int LocationIDRiver2 = 22;
        private const int LocationIDRiver3 = 23;
        private const int LocationIDRiver4 = 24;
        private const int LocationIDPond = 25;
        private const int LocationIDHazyForest1 = 26;
        private const int LocationIDHazyForest2 = 27;
        private const int LocationIDHazyForest3 = 28;
        private const int LocationIDHazyForest4 = 29;
        private const int LocationIDHazyForest5 = 30;
        private const int LocationIDHazyForest6 = 31;
        private const int LocationIDWitchsHouse = 32;
        private const int LocationIDMainRoad1 = 33;
        private const int LocationIDMainRoad2 = 34;
        private const int LocationIDMainRoad3 = 35;
        private const int LocationIDMainRoad4 = 36;

        //Kingdom
        private const int LocationIDHextopia =  37;
        private const int LocationIDResidentialDistrict = 38;
        private const int LocationIDShoppingDistrict1 = 39;
        private const int LocationIDShoppingDistrict2 = 40;
        private const int LocationIDShoppingDistrict3 = 41;
        private const int LocationIDGrandWizardsHouse = 42;
        private const int LocationIDHextopiaCastle = 43;
        private const int LocationIDBackRoads1 = 44;
        private const int LocationIDBackRoads2 = 45;
        private const int LocationIDBackRoads3 = 46;
        private const int LocationIDBackRoads4 = 47;
        private const int LocationIDBackRoads5 = 48;

        //Shard Area 1
        private const int LocationIDWilbursGym = 49;
        private const int LocationIDBenchs1 = 50;
        private const int LocationIDBenchs2 = 51;
        private const int LocationIDBenchs3 = 52;
        private const int LocationIDCardioArea1 = 53;
        private const int LocationIDCardioArea2 = 54;
        private const int LocationIDCardioArea3 = 55;
        private const int LocationIDManagersOffice = 56;
        private const int LocationIDFreeWeightArea1 = 57;
        private const int LocationIDFreeWeightArea2 = 58;
        private const int LocationIDFreeWeightArea3 = 59;
        private const int LocationIDBicepCurlMachine = 60;
        private const int LocationIDMirrors1 = 61;
        private const int LocationIDMirrors2 = 62;
        private const int LocationIDMirrors3 = 63;
        private const int LocationIDSquatRacks1 = 64;
        private const int LocationIDSquatRacks2 = 65;
        private const int LocationIDSquatRacks3 = 66;
        private const int LocationIDSquatRacks4 = 67;
        private const int LocationIDBathroom = 68;
        private const int LocationIDShadyCorner = 69;
        private const int LocationIDAbsArea1 = 70;
        private const int LocationIDAbsArea2 = 71;
        private const int LocationIDAbsArea3 = 72;
        private const int LocationIDSmithMachine = 73;
        private const int LocationIDBackAlley = 74;

        //Shard Area 2
        private const int LocationIDDock1 = 75;
        private const int LocationIDDock2 = 76;
        private const int LocationIDShipyard = 77;
        private const int LocationIDOcean1 = 78;
        private const int LocationIDOcean2 = 79;
        private const int LocationIDColorfulSands = 80;
        private const int LocationIDCupcakeHouse = 81;
        private const int LocationIDFlapjacksHouse = 82;
        private const int LocationIDCandyCanePlains1 = 83;
        private const int LocationIDCandyCanePlains2 = 84;
        private const int LocationIDCandyCanePlains3 = 85;
        private const int LocationIDCandyCanePlains4 = 86;
        private const int LocationIDCandyCanePlains5 = 87;
        private const int LocationIDCandyCanePlains6 = 88;
        private const int LocationIDChocolateRiver1 = 89;
        private const int LocationIDChocolateRiver2 = 90;
        private const int LocationIDChocolateRiver3 = 91;
        private const int LocationIDChocolateRiver4 = 92;
        private const int LocationIDPuddingSwamp1 = 93; 
        private const int LocationIDPuddingSwamp2 = 94;
        private const int LocationIDPuddingSwamp3 = 95;
        private const int LocationIDPuddingSwamp4 = 96;
        private const int LocationIDLollipopJungle1 = 97;
        private const int LocationIDLollipopJungle2 = 98;
        private const int LocationIDLollipopJungle3 = 99;
        private const int LocationIDLollipopJungle4 = 100;
        private const int LocationIDLollipopJungle5 = 101;
        private const int LocationIDLollipopJungle6 = 102;
        private const int LocationIDBlandBerrysHouse = 103;
        private const int LocationIDGingerBreadHouse = 104;
        private const int LocationIDFrostedTree = 105; //Magic Apple here to give you spell
        private const int LocationIDCottonCandyHills1 = 106;
        private const int LocationIDCottonCandyHills2 = 107;
        private const int LocationIDCottonCandyHills3 = 108;
        private const int LocationIDMarshallowMountain1 = 109;
        private const int LocationIDMarshallowMountain2 = 110;
        private const int LocationIDMarshallowMountain3 = 111;
        private const int LocationIDMarshallowMountainPeak = 112;

        //<----------List's which hold all things in the game world---------->
        private static readonly List<Item> items = new List<Item>();
        private static readonly List<Equipment> equipments = new List<Equipment>();
        private static readonly List<Spell> spells = new List<Spell>();
        private static readonly List<Vendor> vendors = new List<Vendor>();
        private static readonly List<Person> persons = new List<Person>();
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

            PopulatePeople();

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

        public static Item FindItemByName(string name)
        {
            foreach (Item item in items)
            {
                if (item.Name == name)
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

        public static Equipment FindEquipmentByName(string name)
        {
            foreach (Equipment equipment in equipments)
            {
                if (equipment.Name == name)
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

        public static Spell FindSpellByName(string name)
        {
            foreach (Spell spell in spells)
            {
                if (spell.Name == name)
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

        public static Vendor FindVendorByName(string name)
        {
            foreach (Vendor vendor in vendors)
            {
                if (vendor.Name == name)
                {
                    return vendor;
                }
            }
            return null;
        }

        public static Person FindPersonByName(string name)
        {
            foreach (Person person in persons)
            {
                if (person.Name == name)
                {
                    return person;
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

        public static Inn FindInnByName(string name)
        {
            foreach (Inn inn in inns)
            {
                if (inn.Name == name)
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

        public static Enemy FindEnemyByName(string name)
        {
            foreach (Enemy enemy in enemies)
            {
                if (enemy.Name == name)
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

        public static Quest FindQuestByName(string name)
        {
            foreach (Quest quest in quests)
            {
                if (quest.Name == name)
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


            items.Add(new QuestItem(ItemIDApple, "Apple", "You know what they say one a day", 3));
            items.Add(new HealthReplenishingItem(ItemIDMilk, "Milk", "Good for the bones", 5, 10));
            items.Add(new DamageItem(ItemIDFireInJar, "Fire in Jar", "It is literally fire in a jar chuck it at an enemy", 10, 20));
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

            equipments.Add(new HeadEquipment(NegativeHealthEquipmentID, "Negative Health", "", 10, -100, 0, 0, 0, 0,0,0,0));
            equipments.Add(new ChestEquipment(NegativeManaEquipmentID, "Negative Mana", "", 10, 0, -100, 0,0,0,0,0,0));
            equipments.Add(new LegEquipment(NegativeAttackEquipmentID, "Negative Attack", "", 10, 0, 0, -100, 0,0,0,0,0));
            equipments.Add(new HeadEquipment(NegativeDefenseEquipmentID, "Negative Defense", "", 10, 0, 0, 0, -50, 0,0,0,0));
            equipments.Add(new ChestEquipment(NegativeLuckEquipmentID, "Negative Luck", "", 10, 0,0,0,0, -100,0,0,0));
            equipments.Add(new LegEquipment(NegativeSpeedEquipmentID, "Negative Speed", "", 10, 0,0,0,0,0,-100,0,0));
            equipments.Add(new HeadEquipment(NegativeIntellectEquipmentID, "Negative Intellect", "", 10,0,0,0,0,0,0,-100,0));
            equipments.Add(new ChestEquipment(NegativeResistanceEquipmentID, "Negative Resistance", "", 10, 0,0,0,0,0,0,0,-50));


            //Starting Equipment
            equipments.Add(new HeadEquipment(HeadEquipmentIDLeatherCoif, "Leather Coif", "Slightly protects your precious head", 10, 2, 0, 0, 1, 0, 0, 0, 1));
            equipments.Add(new ChestEquipment(ChestEquipmentIDLeatherBody, "Leather Body", "Slightly protects your precious body", 30, 5, 0, 0, 3, 0, 0, 0, 3));
            equipments.Add(new LegEquipment(LegEquipmentIDLeatherChaps, "Leather Chaps", "Slightly protects your precious booty", 20, 3, 0, 0, 2, 0, 0, 0, 2));
            equipments.Add(new Sword(SwordIDWoodenSword, "Wooden Sword", "It can't even cut through broccoli", 20, 0, 0, 3, 0, 0, 0, 0, 0));
            equipments.Add(new Staff(StaffIDWoodenStaff, "Wooden Staff", "Kinda small to be called a staff", 20, 0, 0, 0, 0, 0, 0, 3, 0));
            equipments.Add(new Dagger(DaggerIDWoodenDagger, "Wooden Dagger", "Is this just a t-shaped branch", 20, 0, 0, 1, 0, 1, 1, 0, 0));
        }

        private static void PopulateSpells()
        {
            //Format of Spell Creation:
            //(Spell ID, Name, Description, Gold Value, Mana Cost, Spell Affect Value)
            spells.Add(new DamageSpell(SpellIDFire, "Fire", "Summons fire to burn your enemy", 10, 3, 3));
        }

        private static void PopulateVendors()
        {
            //Format of Vendor Creation:
            //(Vendor ID, Name, Description, Optional: Item Inventory, Optional: Equipment Inventory, Optional: Spell Inventory)

            List<Equipment> hermitBillInventory = new List<Equipment>()
            {
                { FindEquipmentByName("Leather Coif")},
                {FindEquipmentByName("Leather Body")},
                {FindEquipmentByName("Leather Chaps")},
                {FindEquipmentByName("Wooden Sword")},
                {FindEquipmentByName("Wooden Staff")},
                {FindEquipmentByName("Wooden Dagger")},
            };
            Vendor hermitBill = new Vendor(VendorIDHermitBill, "Hermit Bill", "This is some good stuff right here", null, hermitBillInventory);

            vendors.Add(hermitBill);
        }

        private static void PopulatePeople()
        {
            persons.Add(new Person("Jimmy", "", "My mom needs 3 apples. So you can't pass until you get me those 3 apples!"));
            persons.Add(new Person("Bobby", "", "Don't go north! Their is a crazy monkey stopping anyone from leaving the village!"));
        }

        private static void PopulateInns()
        {
            //Format of Inn Creation:
            //(Inn ID, Name, Description, Gold Cost For Admission, Inn Keeper)

            //<----------Inn Creation---------->
            Inn rustyShack = new Inn(InnIDRustyShack, "Rusty Shack", "How long ago was this built?", 10, null);

            //<----------Add inns to the inn list---------->
            inns.Add(rustyShack); 
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
            Enemy ant = new Enemy(EnemyIDAnt, "Ant", "To many of these things", 4, 0, 1, 0, 1, 1, 1, 1, 0, 0, 1, 1, 0, null, "head");
            Enemy worm = new Enemy(EnemyIDWorm, "Worm", "Icky slimy crawlers", 6, 0, 2, 0, 1, 1, 1, 1, 0, 0, 3, 3, 0, null, "body");
            Enemy boar = new Enemy(EnemyIDBoar, "Boar", "Is that a pig", 10, 0, 3, 3, 1, 7, 1, 4, 0, 0, 7, 7, 0, null, "tusks");
            Enemy snake = new Enemy(EnemyIDSnake, "Snake", "Slippery snek", 15, 0, 6, 2, 5, 5, 1, 3, 2, 2, 8, 8, 0, null, "tail");
            Enemy spider = new Enemy(EnemyIDSpider, "Spider", "Maybe if I let it bite me...", 15, 0, 3, 7, 1, 5, 1, 3, 2, 2, 8, 8, 0, null, "web");
            Enemy monkey = new Enemy(EnemyIDMonkey, "Monkey", "Oooo Oooo Ahhh Ahhh", 30, 10, 10, 10, 0, 10, 10, 10, 5, 5, 50, 50, 25, null);

            //<-----------Making a boss monster--------------->
            monkey.IsBoss = true;

            //<----------Add enemies to the enemy list---------->
            enemies.Add(ant);
            enemies.Add(worm);
            enemies.Add(boar);
            enemies.Add(snake);
            enemies.Add(spider);
            enemies.Add(monkey);
        }

        private static void PopulateQuests()
        {
            //Format of Quest Creation:
            //(Quest ID, Name, Description, Quest Giver, Quest Requirements, Optional: Quest Gold Reward, 
            //Optional: Quest Experience Points Reward, Optional: Quest Reward Item, Optional: Quest Reward Equipment,
            //Optional: Quest Reward Spell)


            //<-----------Quest Creation---------->
            Dictionary<Item, int> jimmysErrandRequirements = new Dictionary<Item, int>()
            {
                { FindItemByName("Apple"), 3 },
            };
            Quest jimmysErrand = new GatherQuest(QuestIDJimmysErrand, "Jimmy's Errand", "Collect 3 apples from the apple orchard", null, 
                jimmysErrandRequirements, 5, 10, null, null, FindSpellByName("Fire"));


            Dictionary<Enemy, int> cleanTheBarnRequirements = new Dictionary<Enemy, int>()
            {
                { FindEnemyByName("Boar"), 3}
            };
            Quest cleanTheBarn = new KillQuest(QuestIDCleanTheBarn, "Clean the Barn", "Kill 3 boars at the farm", null,
                cleanTheBarnRequirements, 10, 20, FindItemByName("Fire in Jar"));


            Quest testLocation = new TravelQuest(QuestIDTestLocation, "Test Location", "Go to the home", null, FindLocationByName("Home"),
                10, 10);

            
            
            /*Quest antidoteConcoction = new GatherQuest(QuestIDAntidoteConcoction, "Antidote Concoction",
                "Bring me 3 snake fangs so I can make the antidote", mary, loots,
                5, 10, null, FindEquipmentByID(4));

            Quest findTheSewers = new TravelQuest(QuestIDFindTheSewers, "Find the Sewers", "Go to the sewers and come back", garry,
                FindLocationByID(8), 10, 100, null, FindEquipmentByID(5));

            Quest fuckYoBitch = new KillQuest(4, "Fuck those Bitches", "Man bitches ain't shit but hoes and tricks", null, new Dictionary<Enemy, int>
            { { FindEnemyByID(2), 4}}, 50, 26, FindItemByID(4), FindEquipmentByID(7), FindSpellByID(3));*/

            //<----------Add quests to the quest list---------->
            quests.Add(jimmysErrand);
            quests.Add(cleanTheBarn);
            quests.Add(testLocation);
        }

        private static void PopulateLocations()
        {
            //Format of Location Creation:
            //(Location ID, Name, Description, Chance of Encountering an Enemy, X Coordinate, Y Coordinate)


            //<----------Creation of Locations----------->
            //Tutorial Area
            Location home = new Location(LocationIDHome, "Home", "It's your home, sadly you won't be seeing much of it", 0, 0, 0);
            Location dirtPath = new Location(LocationIDDirtPath, "Dirt Path", "A winding path", 100, 1, 0);
            Location jimmysHouse = new Location(LocationIDJimmysHouse, "Jimmy's House", "It's that little shit Jimmy's house", 0, 2, 0);
            Location appleOrchard1 = new Location(LocationIDAppleOrchard1, "Apple Orchard", "Who put all these apples here", 50, 2, -1);
            Location appleOrchard2 = new Location(LocationIDAppleOrchard2, "Apple Orchard", "Who put all these apples here", 50, 1, -1);
            Location appleOrchard3 = new Location(LocationIDAppleOrchard3, "Apple Orchard", "Who put all these apples here", 50, 2, -2);
            Location hermitVillage = new Location(LocationIDHermitVillage, "Hermit Village", "So this is where all those hermits go", 0, 3, 0);
            Location farmersHut = new Location(LocationIDFarmersHut, "Farmer's Hut", "It is a hut where a farmer resides", 0, 3, 1);
            Location farm = new Location(LocationIDFarm, "Farm", "Smells like shit", 100, 4, 1);
            Location woods1 = new Location(LocationIDWoods1, "Woods", "Who put all these trees here", 0, 2, 1);
            Location woods2 = new Location(LocationIDWoods2, "Woods", "Who put all these trees here", 60, 1, 1);
            Location woods3 = new Location(LocationIDWoods3, "Woods", "Who put all these trees here", 60, 1, 2);
            Location woods4 = new Location(LocationIDWoods4, "Woods", "Who put all these trees here", 60, 0, 1);
            Location woods5 = new Location(LocationIDWoods5, "Woods", "Who put all these trees here", 60, 0, 2);
            Location river = new Location(LocationIDRiver, "River", "Whoooooooshhhhhhh", 0, -1, 2);
            Location bridge = new Location(LocationIDBridge, "Bridge", "Connects hermit village with the outside world", 100, 2, 2);

            //Route to Kingdom
            Location grassyPlains = new Location(LocationIDGrassyPlains, "Grassy Plains", "FREEEEEEEEDOM", 0, 2, 3);
            Location crossRoads = new Location(LocationIDCrossRoads, "Cross Roads", "Two roads diverged in a yellow wood", 0, 2, 4);
            Location westRoads = new Location(LocationIDWestRoads, "West Roads", "To the left to the left", 0, 1, 4);
            Location eastRoads = new Location(LocationIDEastRoads, "East Roads", "You are going in the right direction", 0, 3, 4);
            Location river1 = new Location(LocationIDRiver1, "River", "This river filled with debris", 50, 0, 4);
            Location river2 = new Location(LocationIDRiver2, "River", "This river filled with debris", 50, 0, 5);
            Location river3 = new Location(LocationIDRiver3, "River", "This river filled with debris", 50, 0, 6);
            Location river4 = new Location(LocationIDRiver4, "River", "This river filled with debris", 50, 0, 7);
            Location pond = new Location(LocationIDPond, "Pond", "A quiet and serene pond", 100, -1, 7);
            Location hazyForest1 = new Location(LocationIDHazyForest1, "Hazy Forest", "This place makes your skin crawl", 75, 4, 4);
            Location hazyForest2 = new Location(LocationIDHazyForest2, "Hazy Forest", "This place makes your skin crawl", 75, 5, 4);
            Location hazyForest3 = new Location(LocationIDHazyForest3, "Hazy Forest", "This place makes your skin crawl", 75, 4, 5);
            Location hazyForest4 = new Location(LocationIDHazyForest4, "Hazy Forest", "This place makes your skin crawl", 75, 5, 5);
            Location hazyForest5 = new Location(LocationIDHazyForest5, "Hazy Forest", "This place makes your skin crawl", 75, 4, 6);
            Location hazyForest6 = new Location(LocationIDHazyForest6, "Hazy Forest", "This place makes your skin crawl", 75, 5, 6);
            Location witchsHouse = new Location(LocationIDWitchsHouse, "Witch's House", "It smells like candy!", 0, 6, 5);
            Location mainroad1 = new Location(LocationIDMainRoad1, "Main Road", "This road is well maintained", 0, 1, 7);
            Location mainroad2 = new Location(LocationIDMainRoad2, "Main Road", "This road is well maintained", 0, 2, 7);
            Location mainroad3 = new Location(LocationIDMainRoad3, "Main Road", "This road is well maintained", 0, 3, 7);
            Location mainroad4 = new Location(LocationIDMainRoad4, "Main Road", "This road is well maintained", 0, 4, 7);

            //Kingdom
            Location hextopia = new Location(LocationIDHextopia, "Hextopia", "Kingdom of the strongest civilization in the world", 0, 2, 8);
            Location residentialDistrict = new Location(LocationIDResidentialDistrict, "Residential District", "You can take a nice nap here", 0, 1, 8);
            Location shoppingDistrict1 = new Location(LocationIDShoppingDistrict1, "Shopping District", "Look at all the nice things", 0, 3, 9);
            Location shoppingDistrict2 = new Location(LocationIDShoppingDistrict2, "Shopping District", "Look at all the nice things", 0, 3, 8);
            Location shoppingDistrict3 = new Location(LocationIDShoppingDistrict3, "Shopping District", "Look at all the nice things", 0, 4, 8);
            Location grandWizardsHouse = new Location(LocationIDGrandWizardsHouse, "Grand Wizard's House", "Its the GRAND WIZZZORRRRRD BABYYYY", 0, 1, 9);
            Location hextopiaCastle = new Location(LocationIDHextopiaCastle, "Hextopia Castle", "Its so shiny!", 0, 2, 9);
            Location backRoads1 = new Location(LocationIDBackRoads1, "Back Roads", "You feel your adventure just starting", 50, 2, 10);
            Location backRoads2 = new Location(LocationIDBackRoads2, "Back Roads", "You feel your adventure just starting", 50, 3, 10);
            Location backRoads3 = new Location(LocationIDBackRoads3, "Back Roads", "You feel your adventure just starting", 50, 3, 11);
            Location backRoads4 = new Location(LocationIDBackRoads4, "Back Roads", "You feel your adventure just starting", 50, 4, 11);
            Location backRoads5 = new Location(LocationIDBackRoads5, "Back Roads", "You feel your adventure just starting", 50, 4, 12);

            //Shard Area 1
            Location wilbursGym = new Location(LocationIDWilbursGym, "Wilbur's Gym", "You feel pumped!", 0, 5, 12);
            Location benchs1 = new Location(LocationIDBenchs1, "Benchs", "No one is putting their weights back", 75, 6, 12);
            Location benchs2 = new Location(LocationIDBenchs2, "Benchs", "No one is putting their weights back", 75, 7, 12);
            Location benchs3 = new Location(LocationIDBenchs3, "Benchs", "No one is putting their weights back", 75, 8, 12);
            Location cardioArea1 = new Location(LocationIDCardioArea1, "Cardio Area", "They're killing their gains!", 75, 6, 13);
            Location cardioArea2 = new Location(LocationIDCardioArea2, "Cardio Area", "They're killing their gains!", 75, 7, 13);
            Location cardioArea3 = new Location(LocationIDCardioArea3, "Cardio Area", "They're killing their gains!", 75, 8, 13);
            Location managersOffice = new Location(LocationIDManagersOffice, "Managers Office", "He's old and angry", 0, 6, 11);
            Location freeWeightArea1 = new Location(LocationIDFreeWeightArea1, "Free Weight Area", "Where the fuck are all the 10's", 75, 7, 11);
            Location freeWeightArea2 = new Location(LocationIDFreeWeightArea2, "Free Weight Area", "Where the fuck are all the 10's", 75, 8, 11);
            Location freeWeightArea3 = new Location(LocationIDFreeWeightArea3, "Free Weight Area", "Where the fuck are all the 10's", 75, 9, 11);
            Location bicepCurlMachine = new Location(LocationIDBicepCurlMachine, "Bicep Curl Machine", "Everyones favorite", 0, 9, 12);
            Location mirrors1 = new Location(LocationIDMirrors1, "Mirrors", "Look how good they look", 75, 10, 13);
            Location mirrors2 = new Location(LocationIDMirrors2, "Mirrors", "Look how good they look", 75, 10, 12);
            Location mirrors3 = new Location(LocationIDMirrors3, "Mirrors", "Look how good they look", 75, 10, 11);
            Location squatRacks1 = new Location(LocationIDSquatRacks1, "Squat Racks", "Bubble butt bubble bubble bubble butt", 75, 9, 13);
            Location squatRacks2 = new Location(LocationIDSquatRacks2, "Squat Racks", "Bubble butt bubble bubble bubble butt", 75, 9, 14);
            Location squatRacks3 = new Location(LocationIDSquatRacks3, "Squat Racks", "Bubble butt bubble bubble bubble butt", 75, 10, 14);
            Location squatRacks4 = new Location(LocationIDSquatRacks4, "Squat Racks", "Bubble butt bubble bubble bubble butt", 75, 9, 15);
            Location bathroom = new Location(LocationIDBathroom, "Bathroom", "This place is pretty shitty", 0, 8, 14);
            Location shadyCorner = new Location(LocationIDShadyCorner, "Shady Corner", "Smells like a doctor's office", 0, 10, 15);
            Location absArea1 = new Location(LocationIDAbsArea1, "Abs Area", "Look at all the washboards", 75, 11, 15);
            Location absArea2 = new Location(LocationIDAbsArea2, "Abs Area", "Look at all the washboards", 75, 12, 15);
            Location absArea3 = new Location(LocationIDAbsArea3, "Abs Area", "Look at all the washboards", 75, 12, 14);
            Location smithMachine = new Location(LocationIDSmithMachine, "Smith Machine", "Balance is for poopy heads", 0, 12, 13);
            Location backAlley = new Location(LocationIDBackAlley, "Back Alley", "Alpha male's territory", 100, 12, 12);

            //Shard Area 2
            //Muffin man final boss
            Location dock1 = new Location(LocationIDDock1, "Dock", "I wonder where this leads to", 0, 13, 12);
            Location dock2 = new Location(LocationIDDock2, "Dock", "I wonder where this leads to", 0, 14, 12);
            Location shipyard = new Location(LocationIDShipyard, "Shipyard", "What a surprise!", 0, 15, 12);
            Location ocean1 = new Location(LocationIDOcean1, "Ocean", "duunnn dunnn... duuuunnnn duun... duuunnnnnnnn dun dun dun dun dun dun dun dun dun dun dunnnnnnnnnnn dunnnn", 0, 15, 13);
            Location ocean2 = new Location(LocationIDOcean2, "Ocean", "duunnn dunnn... duuuunnnn duun... duuunnnnnnnn dun dun dun dun dun dun dun dun dun dun dunnnnnnnnnnn dunnnn", 0, 15, 14);
            Location colorfulSands = new Location(LocationIDColorfulSands, "Colorful Sands", "I think it has crabs", 0, 15, 15); 
            Location cupcakeHouse = new Location(LocationIDCupcakeHouse, "CupcakeHouse", "The interior design is exquisite", 0, 14, 15);
            Location flapjacksHouse = new Location(LocationIDFlapjacksHouse, "Flapjack's House", "I found Candy Island, Captain K'nuckles!", 0, 16, 15);
            Location candyCanePlains1 = new Location(LocationIDCandyCanePlains1, "Candy Cane Plains", "It's beginning to feel a lot like Christmasssss", 75, 15, 16);
            Location candyCanePlains2 = new Location(LocationIDCandyCanePlains2, "Candy Cane Plains", "It's beginning to feel a lot like Christmasssss", 75, 14, 16);
            Location candyCanePlains3 = new Location(LocationIDCandyCanePlains3, "Candy Cane Plains", "It's beginning to feel a lot like Christmasssss", 75, 14, 17);
            Location candyCanePlains4 = new Location(LocationIDCandyCanePlains4, "Candy Cane Plains", "It's beginning to feel a lot like Christmasssss", 75, 15, 17);
            Location candyCanePlains5 = new Location(LocationIDCandyCanePlains5, "Candy Cane Plains", "It's beginning to feel a lot like Christmasssss", 75, 16, 17);
            Location candyCanePlains6 = new Location(LocationIDCandyCanePlains6, "Candy Cane Plains", "It's beginning to feel a lot like Christmasssss", 75, 16, 16);
            Location chocolateRiver1 = new Location(LocationIDChocolateRiver1, "Chocolate River", "That is chocolate right?", 75, 16, 18);
            Location chocolateRiver2 = new Location(LocationIDChocolateRiver2, "Chocolate River", "That is chocolate right?", 75, 17, 18);
            Location chocolateRiver3 = new Location(LocationIDChocolateRiver3, "Chocolate River", "That is chocolate right?", 75, 18, 18);
            Location chocolateRiver4 = new Location(LocationIDChocolateRiver4, "Chocolate River", "That is chocolate right?", 75, 19, 18);
            Location puddingSwamp1 = new Location(LocationIDPuddingSwamp1, "Pudding Swamp", "What are you doing in my swamp?", 50, 18, 17);
            Location puddingSwamp2 = new Location(LocationIDPuddingSwamp2, "Pudding Swamp", "What are you doing in my swamp?", 50, 19, 17);
            Location puddingSwamp3 = new Location(LocationIDPuddingSwamp3, "Pudding Swamp", "What are you doing in my swamp?", 50, 19, 16);
            Location puddingSwamp4 = new Location(LocationIDPuddingSwamp4, "Pudding Swamp", "What are you doing in my swamp?", 50, 18, 16);
            Location lollipopJungle1 = new Location(LocationIDLollipopJungle1, "Lollipop Jungle", "Where are the loli's?", 75, 20, 18);
            Location lollipopJungle2 = new Location(LocationIDLollipopJungle2, "Lollipop Jungle", "Where are the loli's?", 75, 20, 19);
            Location lollipopJungle3 = new Location(LocationIDLollipopJungle3, "Lollipop Jungle", "Where are the loli's?", 75, 20, 20);
            Location lollipopJungle4 = new Location(LocationIDLollipopJungle4, "Lollipop Jungle", "Where are the loli's?", 75, 21, 20);
            Location lollipopJungle5 = new Location(LocationIDLollipopJungle5, "Lollipop Jungle", "Where are the loli's?", 75, 21, 19);
            Location lollipopJungle6 = new Location(LocationIDLollipopJungle6, "Lollipop Jungle", "Where are the loli's?", 75, 21, 18);
            Location blandBerrysHouse = new Location(LocationIDBlandBerrysHouse, "Bland Berry's House", "It smells normal", 0, 21, 17);
            Location gingerBreadHouse = new Location(LocationIDGingerBreadHouse, "Ginger Bread House", "This seems fishy", 0, 20, 21);
            Location frostedTree = new Location(LocationIDFrostedTree, "Frosted Tree", "Lick ittt", 0, 21, 21);
            Location cottonCandyHills1 = new Location(LocationIDCottonCandyHills1, "Cotton Candy Hills", "Uhm ackshually it should be called Sugar Hills", 50, 22, 19);
            Location cottonCandyHills2 = new Location(LocationIDCottonCandyHills2, "Cotton Candy Hills", "Uhm ackshually it should be called Sugar Hills", 50, 23, 19);
            Location cottonCandyHills3 = new Location(LocationIDCottonCandyHills3, "Cotton Candy Hills", "Uhm ackshually it should be called Sugar Hills", 50, 24, 19);
            Location marshallowMountain1 = new Location(LocationIDMarshallowMountain1, "Marshallow Mountain", "Looks like a straight 90 degree climb", 75, 25, 19);
            Location marshallowMountain2 = new Location(LocationIDMarshallowMountain2, "Marshallow Mountain", "Looks like a straight 90 degree climb", 75, 25, 20);
            Location marshallowMountain3 = new Location(LocationIDMarshallowMountain3, "Marshallow Mountain", "Looks like a straight 90 degree climb", 75, 25, 21);
            Location marshallowMountainPeak = new Location(LocationIDMarshallowMountainPeak, "Marshallow Mountain Peak", "The view up here is great", 100, 25, 22);

            Person bob = new Person("Bob", "", "I think there is a treasure somewhere in the woods");
            Person marley = new Person("Marley", "", "I don't know what the fuck is going on");


            //<----------Linking up the locations---------->
            home.LocationToTheEast = dirtPath;

            dirtPath.LocationToTheWest = home;
            dirtPath.LocationToTheEast = jimmysHouse;

            jimmysHouse.LocationToTheSouth = appleOrchard1;
            jimmysHouse.LocationToTheEast = hermitVillage;
            jimmysHouse.LocationToTheWest = dirtPath;

            appleOrchard1.LocationToTheNorth = jimmysHouse;
            appleOrchard1.LocationToTheWest = appleOrchard2;
            appleOrchard1.LocationToTheSouth = appleOrchard3;

            appleOrchard2.LocationToTheEast = appleOrchard1;

            appleOrchard3.LocationToTheNorth = appleOrchard1;

            hermitVillage.LocationToTheWest = jimmysHouse;
            hermitVillage.LocationToTheNorth = farmersHut;

            farmersHut.LocationToTheSouth = hermitVillage;
            farmersHut.LocationToTheEast = farm;
            farmersHut.LocationToTheWest = woods1;

            farm.LocationToTheWest = farmersHut;

            woods1.LocationToTheNorth = bridge;
            woods1.LocationToTheWest = woods2;
            woods1.LocationToTheEast = farmersHut;

            woods2.LocationToTheEast = woods1;
            woods2.LocationToTheNorth = woods3;
            woods2.LocationToTheWest = woods4;

            woods3.LocationToTheSouth = woods2;
            woods3.LocationToTheWest = woods5;

            woods4.LocationToTheEast = woods2;
            woods4.LocationToTheNorth = woods5;

            woods5.LocationToTheEast = woods3;
            woods5.LocationToTheSouth = woods4;
            woods5.LocationToTheWest = river;

            river.LocationToTheEast = woods5;

            bridge.LocationToTheSouth = woods1;
            bridge.LocationToTheNorth = grassyPlains;

            grassyPlains.LocationToTheSouth = bridge;
            grassyPlains.LocationToTheNorth = crossRoads;

            crossRoads.LocationToTheSouth = grassyPlains;
            crossRoads.LocationToTheWest = westRoads;
            crossRoads.LocationToTheEast = eastRoads;

            westRoads.LocationToTheWest = river1;
            westRoads.LocationToTheEast = crossRoads;

            eastRoads.LocationToTheWest = crossRoads;
            eastRoads.LocationToTheEast = hazyForest1;

            river1.LocationToTheEast = westRoads;
            river1.LocationToTheNorth = river2;

            river2.LocationToTheSouth = river1;
            river2.LocationToTheNorth = river3;
            
            river3.LocationToTheSouth = river2;
            river3.LocationToTheNorth = river4;

            river4.LocationToTheSouth = river3;
            river4.LocationToTheWest = pond;
            river4.LocationToTheEast = mainroad1;

            pond.LocationToTheEast = river4;

            hazyForest1.LocationToTheWest = eastRoads;
            hazyForest1.LocationToTheEast = hazyForest2;
            hazyForest1.LocationToTheNorth = hazyForest3;

            hazyForest2.LocationToTheWest = hazyForest1;
            hazyForest2.LocationToTheNorth = hazyForest4;

            hazyForest3.LocationToTheSouth = hazyForest1;
            hazyForest3.LocationToTheEast = hazyForest4;
            hazyForest3.LocationToTheNorth = hazyForest5;

            hazyForest4.LocationToTheSouth = hazyForest2;
            hazyForest4.LocationToTheWest = hazyForest3;
            hazyForest4.LocationToTheEast = witchsHouse;
            hazyForest4.LocationToTheNorth = hazyForest6;

            hazyForest5.LocationToTheSouth = hazyForest3;
            hazyForest5.LocationToTheEast = hazyForest6;
            hazyForest5.LocationToTheNorth = mainroad4;

            hazyForest6.LocationToTheSouth = hazyForest4;
            hazyForest6.LocationToTheWest = hazyForest5;

            witchsHouse.LocationToTheWest = hazyForest4;

            mainroad1.LocationToTheWest = river4;
            mainroad1.LocationToTheEast = mainroad2;

            mainroad2.LocationToTheWest = mainroad1;
            mainroad2.LocationToTheEast = mainroad3;
            mainroad2.LocationToTheNorth = hextopia;

            mainroad3.LocationToTheWest = mainroad2;
            mainroad3.LocationToTheEast = mainroad4;

            mainroad4.LocationToTheWest = mainroad3;
            mainroad4.LocationToTheSouth = hazyForest5;

            hextopia.LocationToTheSouth = mainroad2;
            hextopia.LocationToTheWest = residentialDistrict;
            hextopia.LocationToTheEast = shoppingDistrict2;
            hextopia.LocationToTheNorth = hextopiaCastle;

            residentialDistrict.LocationToTheEast = hextopia;
            residentialDistrict.LocationToTheNorth = grandWizardsHouse;
            
            grandWizardsHouse.LocationToTheSouth = residentialDistrict;
            
            shoppingDistrict2.LocationToTheWest = hextopia;
            shoppingDistrict2.LocationToTheNorth = shoppingDistrict1;
            shoppingDistrict2.LocationToTheEast = shoppingDistrict3;

            shoppingDistrict1.LocationToTheSouth = shoppingDistrict2;
            
            shoppingDistrict3.LocationToTheWest = shoppingDistrict2;

            hextopiaCastle.LocationToTheSouth = hextopia;
            hextopiaCastle.LocationToTheNorth = backRoads1;

            backRoads1.LocationToTheSouth = hextopiaCastle;
            backRoads1.LocationToTheEast = backRoads2;

            backRoads2.LocationToTheWest = backRoads1;
            backRoads2.LocationToTheNorth = backRoads3;

            backRoads3.LocationToTheSouth = backRoads2;
            backRoads3.LocationToTheEast = backRoads4;

            backRoads4.LocationToTheWest = backRoads3;
            backRoads4.LocationToTheNorth = backRoads5;

            backRoads5.LocationToTheSouth = backRoads4;
            backRoads5.LocationToTheEast = wilbursGym;

            wilbursGym.LocationToTheWest = backRoads5;
            wilbursGym.LocationToTheEast = benchs1;

            benchs1.LocationToTheEast = benchs2;
            benchs1.LocationToTheWest = wilbursGym;
            benchs1.LocationToTheNorth = cardioArea1;
            benchs1.LocationToTheSouth = managersOffice;

            benchs2.LocationToTheWest = benchs1;
            benchs2.LocationToTheNorth = cardioArea2;
            benchs2.LocationToTheSouth = freeWeightArea1;
            benchs2.LocationToTheEast = benchs3;

            benchs3.LocationToTheWest = benchs2;
            benchs3.LocationToTheNorth = cardioArea3;
            benchs3.LocationToTheSouth = freeWeightArea2;
            benchs3.LocationToTheEast = bicepCurlMachine;

            cardioArea1.LocationToTheSouth = benchs1;
            cardioArea1.LocationToTheEast = cardioArea2;

            cardioArea2.LocationToTheSouth = benchs2;
            cardioArea2.LocationToTheWest = cardioArea1;
            cardioArea2.LocationToTheEast = cardioArea3;

            cardioArea3.LocationToTheWest = cardioArea2;
            cardioArea3.LocationToTheSouth = benchs3;

            managersOffice.LocationToTheNorth = benchs1;
            managersOffice.LocationToTheEast = freeWeightArea1;

            freeWeightArea1.LocationToTheWest = managersOffice;
            freeWeightArea1.LocationToTheNorth = benchs2;
            freeWeightArea1.LocationToTheEast = freeWeightArea2;

            freeWeightArea2.LocationToTheWest = freeWeightArea1;
            freeWeightArea2.LocationToTheNorth = benchs3;
            freeWeightArea2.LocationToTheEast = freeWeightArea3;

            freeWeightArea3.LocationToTheWest = freeWeightArea2;

            bicepCurlMachine.LocationToTheWest = benchs3;
            bicepCurlMachine.LocationToTheEast = mirrors2;
            bicepCurlMachine.LocationToTheNorth = squatRacks1;

            mirrors1.LocationToTheSouth = mirrors2;

            mirrors2.LocationToTheNorth = mirrors1;
            mirrors2.LocationToTheWest = bicepCurlMachine;
            mirrors2.LocationToTheSouth = mirrors3;

            mirrors3.LocationToTheNorth = mirrors2;

            squatRacks1.LocationToTheSouth = bicepCurlMachine;
            squatRacks1.LocationToTheNorth = squatRacks2;

            squatRacks2.LocationToTheWest = bathroom;
            squatRacks2.LocationToTheNorth = squatRacks4;
            squatRacks2.LocationToTheSouth = squatRacks1;
            squatRacks2.LocationToTheEast = squatRacks3;

            squatRacks3.LocationToTheWest = squatRacks2;
            squatRacks3.LocationToTheNorth = shadyCorner;

            squatRacks4.LocationToTheSouth = squatRacks2;
            squatRacks4.LocationToTheEast = shadyCorner;

            bathroom.LocationToTheEast = squatRacks2;

            shadyCorner.LocationToTheWest = squatRacks4;
            shadyCorner.LocationToTheSouth = squatRacks3;
            shadyCorner.LocationToTheEast = absArea1;

            absArea1.LocationToTheWest = shadyCorner;
            absArea1.LocationToTheEast = absArea2;

            absArea2.LocationToTheWest = absArea1;
            absArea2.LocationToTheSouth = absArea3;

            absArea3.LocationToTheNorth = absArea2;
            absArea3.LocationToTheSouth = smithMachine;

            smithMachine.LocationToTheNorth = absArea3;
            smithMachine.LocationToTheSouth = backAlley;

            backAlley.LocationToTheNorth = smithMachine;
            backAlley.LocationToTheEast = dock1;

            dock1.LocationToTheWest = backAlley;
            dock1.LocationToTheEast = dock2;

            dock2.LocationToTheWest = dock1;
            dock2.LocationToTheEast = shipyard;

            shipyard.LocationToTheWest = dock2;
            shipyard.LocationToTheNorth = ocean1;

            ocean1.LocationToTheSouth = shipyard;
            ocean1.LocationToTheNorth = ocean2;

            ocean2.LocationToTheSouth = ocean1;
            ocean2.LocationToTheNorth = colorfulSands;

            colorfulSands.LocationToTheSouth = ocean2;
            colorfulSands.LocationToTheWest = cupcakeHouse;
            colorfulSands.LocationToTheEast = flapjacksHouse;
            colorfulSands.LocationToTheNorth = candyCanePlains1;

            cupcakeHouse.LocationToTheEast = colorfulSands;

            flapjacksHouse.LocationToTheWest = colorfulSands;

            candyCanePlains1.LocationToTheSouth = colorfulSands;
            candyCanePlains1.LocationToTheWest = candyCanePlains2;
            candyCanePlains1.LocationToTheNorth = candyCanePlains4;
            candyCanePlains1.LocationToTheEast = candyCanePlains6;

            candyCanePlains2.LocationToTheEast = candyCanePlains1;
            candyCanePlains2.LocationToTheNorth = candyCanePlains3;

            candyCanePlains3.LocationToTheSouth = candyCanePlains2;
            candyCanePlains3.LocationToTheEast = candyCanePlains4;

            candyCanePlains4.LocationToTheWest = candyCanePlains3;
            candyCanePlains4.LocationToTheSouth = candyCanePlains1;
            candyCanePlains4.LocationToTheEast = candyCanePlains5;

            candyCanePlains5.LocationToTheWest = candyCanePlains4;
            candyCanePlains5.LocationToTheSouth = candyCanePlains6;
            candyCanePlains5.LocationToTheNorth = chocolateRiver1;

            candyCanePlains6.LocationToTheNorth = candyCanePlains5;
            candyCanePlains6.LocationToTheWest = candyCanePlains1;

            chocolateRiver1.LocationToTheSouth = candyCanePlains5;
            chocolateRiver1.LocationToTheEast = chocolateRiver2;

            chocolateRiver2.LocationToTheWest = chocolateRiver1;
            chocolateRiver2.LocationToTheEast = chocolateRiver3;

            chocolateRiver3.LocationToTheWest = chocolateRiver2;
            chocolateRiver3.LocationToTheEast = chocolateRiver4;
            chocolateRiver3.LocationToTheSouth = puddingSwamp1;

            chocolateRiver4.LocationToTheWest = chocolateRiver3;
            chocolateRiver4.LocationToTheEast = lollipopJungle1;

            puddingSwamp1.LocationToTheNorth = chocolateRiver3;
            puddingSwamp1.LocationToTheEast = puddingSwamp2;
            puddingSwamp1.LocationToTheSouth = puddingSwamp4;
            
            puddingSwamp2.LocationToTheWest = puddingSwamp1;
            puddingSwamp2.LocationToTheSouth = puddingSwamp3;

            puddingSwamp3.LocationToTheNorth = puddingSwamp2;
            puddingSwamp3.LocationToTheWest = puddingSwamp4;

            puddingSwamp4.LocationToTheEast = puddingSwamp3;
            puddingSwamp4.LocationToTheNorth = puddingSwamp1;

            lollipopJungle1.LocationToTheWest = chocolateRiver4;
            lollipopJungle1.LocationToTheNorth = lollipopJungle2;
            lollipopJungle1.LocationToTheEast = lollipopJungle6;

            lollipopJungle2.LocationToTheSouth = lollipopJungle1;
            lollipopJungle2.LocationToTheNorth = lollipopJungle3;
            lollipopJungle2.LocationToTheEast = lollipopJungle5;

            lollipopJungle3.LocationToTheSouth = lollipopJungle2;
            lollipopJungle3.LocationToTheEast = lollipopJungle4;
            lollipopJungle3.LocationToTheNorth = gingerBreadHouse;

            lollipopJungle4.LocationToTheWest = lollipopJungle3;
            lollipopJungle4.LocationToTheSouth = lollipopJungle5;
            lollipopJungle4.LocationToTheNorth = frostedTree;

            lollipopJungle5.LocationToTheWest = lollipopJungle2;
            lollipopJungle5.LocationToTheNorth = lollipopJungle4;
            lollipopJungle5.LocationToTheSouth = lollipopJungle6;
            lollipopJungle5.LocationToTheEast = cottonCandyHills1;

            lollipopJungle6.LocationToTheNorth = lollipopJungle5;
            lollipopJungle6.LocationToTheWest = lollipopJungle1;
            lollipopJungle6.LocationToTheSouth = blandBerrysHouse;

            blandBerrysHouse.LocationToTheNorth = lollipopJungle6;

            gingerBreadHouse.LocationToTheSouth = lollipopJungle3;

            frostedTree.LocationToTheSouth = lollipopJungle4;

            cottonCandyHills1.LocationToTheWest = lollipopJungle5;
            cottonCandyHills1.LocationToTheEast = cottonCandyHills2;
            
            cottonCandyHills2.LocationToTheWest = cottonCandyHills1;
            cottonCandyHills2.LocationToTheEast = cottonCandyHills3;

            cottonCandyHills3.LocationToTheWest = cottonCandyHills2;
            cottonCandyHills3.LocationToTheEast = marshallowMountain1;

            marshallowMountain1.LocationToTheWest = cottonCandyHills3;
            marshallowMountain1.LocationToTheNorth = marshallowMountain2;

            marshallowMountain2.LocationToTheSouth = marshallowMountain1;
            marshallowMountain2.LocationToTheNorth = marshallowMountain3;

            marshallowMountain3.LocationToTheSouth = marshallowMountain2;
            marshallowMountain3.LocationToTheNorth = marshallowMountainPeak;

            marshallowMountainPeak.LocationToTheSouth = marshallowMountain3;


            //<----------Check if player is allowed to enter------------->
            hermitVillage.IsAllowedToEnter = false;
            hermitVillage.RequiredObjectToEnter = FindQuestByName("Jimmy's Errand");

            woods1.IsAllowedToEnter = false;
            woods1.RequiredObjectToEnter = FindQuestByName("Clean the Barn");


            //<----------Adding loot to locations------------->
            home.ItemInLocation = FindItemByName("Milk");
            appleOrchard1.ItemInLocation = FindItemByName("Apple");
            appleOrchard2.ItemInLocation = FindItemByName("Apple");
            appleOrchard3.ItemInLocation = FindItemByName("Apple");
            farm.ItemInLocation = FindItemByName("Milk");
            river.ItemInLocation = FindItemByName("Fire in Jar");


            //<----------Adding people to locations------------->
            jimmysHouse.PersonInLocation = FindPersonByName("Jimmy");
            woods1.PersonInLocation = FindPersonByName("Bobby");


            //<----------Add vendors to the locations---------->
            hermitVillage.VendorInLocation = FindVendorByName("Hermit Bill");


            //<----------Add inns to the locations---------->
            hermitVillage.InnInLocation = FindInnByName("Rusty Shack");


            //<----------Add enemies to the locations---------->
            //Note: Enemy weights must be ordered from least to greatest
            dirtPath.EnemiesInLocation = new Dictionary<Enemy, int>
            {
                { FindEnemyByName("Ant"), 1 },
            };
            appleOrchard1.EnemiesInLocation = new Dictionary<Enemy, int>
            {
                { FindEnemyByName("Worm"), 1},
            };
            appleOrchard2.EnemiesInLocation = new Dictionary<Enemy, int>
            {
                { FindEnemyByName("Worm"), 1},
            };
            appleOrchard3.EnemiesInLocation = new Dictionary<Enemy, int>
            {
                { FindEnemyByName("Worm"), 1},
            };
            farm.EnemiesInLocation = new Dictionary<Enemy, int>
            {
                { FindEnemyByName("Boar"), 1},
            };
            woods2.EnemiesInLocation = new Dictionary<Enemy, int>
            {
                { FindEnemyByName("Snake"), 1 },
                { FindEnemyByName("Spider"), 1},
            };
            woods3.EnemiesInLocation = new Dictionary<Enemy, int>
            {
                { FindEnemyByName("Snake"), 1 },
                { FindEnemyByName("Spider"), 1},
            };
            woods4.EnemiesInLocation = new Dictionary<Enemy, int>
            {
                { FindEnemyByName("Snake"), 1 },
                { FindEnemyByName("Spider"), 1},
            };
            woods5.EnemiesInLocation = new Dictionary<Enemy, int>
            {
                { FindEnemyByName("Snake"), 1 },
                { FindEnemyByName("Spider"), 1},
            };
            bridge.BossInLocation = FindEnemyByName("Monkey");


            //<----------Add quests to the locations---------->
            jimmysHouse.QuestInLocation = FindQuestByName("Jimmy's Errand");
            farmersHut.QuestInLocation = FindQuestByName("Clean the Barn");
            hermitVillage.QuestInLocation = FindQuestByName("Test Location");


            //<-----------Add locations to the location list---------->
            locations.Add(home);
            locations.Add(dirtPath);
            locations.Add(jimmysHouse);
            locations.Add(appleOrchard1);
            locations.Add(appleOrchard2);
            locations.Add(appleOrchard3);
            locations.Add(hermitVillage);
            locations.Add(farmersHut);
            locations.Add(farm);
            locations.Add(woods1);
            locations.Add(woods2);
            locations.Add(woods3);
            locations.Add(woods4);
            locations.Add(woods5);
            locations.Add(river);
            locations.Add(bridge);
            locations.Add(grassyPlains);
            locations.Add(crossRoads);
            locations.Add(westRoads);
            locations.Add(eastRoads);
            locations.Add(river1);
            locations.Add(river2);
            locations.Add(river3);
            locations.Add(river4);
            locations.Add(pond);
            locations.Add(hazyForest1);
            locations.Add(hazyForest2);
            locations.Add(hazyForest3);
            locations.Add(hazyForest4);
            locations.Add(hazyForest5);
            locations.Add(hazyForest6);
            locations.Add(witchsHouse);
            locations.Add(mainroad1);
            locations.Add(mainroad2);
            locations.Add(mainroad3);
            locations.Add(mainroad4);
            locations.Add(hextopia);
            locations.Add(residentialDistrict);
            locations.Add(shoppingDistrict1);
            locations.Add(shoppingDistrict2);
            locations.Add(shoppingDistrict3);
            locations.Add(grandWizardsHouse);
            locations.Add(hextopiaCastle);
            locations.Add(backRoads1);
            locations.Add(backRoads2);
            locations.Add(backRoads3);
            locations.Add(backRoads4);
            locations.Add(backRoads5);
            locations.Add(wilbursGym);
            locations.Add(benchs1);
            locations.Add(benchs2);
            locations.Add(benchs3);
            locations.Add(cardioArea1);
            locations.Add(cardioArea2);
            locations.Add(cardioArea3);
            locations.Add(managersOffice);
            locations.Add(freeWeightArea1);
            locations.Add(freeWeightArea2);
            locations.Add(freeWeightArea3);
            locations.Add(bicepCurlMachine);
            locations.Add(mirrors1);
            locations.Add(mirrors2);
            locations.Add(mirrors3);
            locations.Add(squatRacks1);
            locations.Add(squatRacks2);
            locations.Add(squatRacks3);
            locations.Add(squatRacks4);
            locations.Add(bathroom);
            locations.Add(shadyCorner);
            locations.Add(absArea1);
            locations.Add(absArea2);
            locations.Add(absArea3);
            locations.Add(smithMachine);
            locations.Add(backAlley);
            locations.Add(dock1);
            locations.Add(dock2);
            locations.Add(shipyard);
            locations.Add(ocean1);
            locations.Add(ocean2);
            locations.Add(colorfulSands);
            locations.Add(cupcakeHouse);
            locations.Add(flapjacksHouse);
            locations.Add(candyCanePlains1);
            locations.Add(candyCanePlains2);
            locations.Add(candyCanePlains3);
            locations.Add(candyCanePlains4);
            locations.Add(candyCanePlains5);
            locations.Add(candyCanePlains6);
            locations.Add(chocolateRiver1);
            locations.Add(chocolateRiver2);
            locations.Add(chocolateRiver3);
            locations.Add(chocolateRiver4);
            locations.Add(puddingSwamp1);
            locations.Add(puddingSwamp2);
            locations.Add(puddingSwamp3);
            locations.Add(puddingSwamp4);
            locations.Add(lollipopJungle1);
            locations.Add(lollipopJungle2);
            locations.Add(lollipopJungle3);
            locations.Add(lollipopJungle4);
            locations.Add(lollipopJungle5);
            locations.Add(lollipopJungle6);
            locations.Add(blandBerrysHouse);
            locations.Add(gingerBreadHouse);
            locations.Add(frostedTree);
            locations.Add(cottonCandyHills1);
            locations.Add(cottonCandyHills2);
            locations.Add(cottonCandyHills3);
            locations.Add(marshallowMountain1);
            locations.Add(marshallowMountain2);
            locations.Add(marshallowMountain3);
            locations.Add(marshallowMountainPeak);


            //Link Travel Quests with their Destination Location
            UpdateTravelQuests();
            //((TravelQuest)quests[2]).RequiredLocation = FindLocationByID(8);
        }

        private static void UpdateTravelQuests()
        {
            ((TravelQuest)FindQuestByName("Test Location")).RequiredLocation = FindLocationByName("Home");
        }
    }
}