using Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the World of Blarg!");
            Console.WriteLine("You are a hero on a quest, what a surprise!");
            Console.WriteLine("Every hero needs a name.");
            Console.WriteLine("What is your name unproven hero?");
            Console.Write("Name:");
            string name;
            name = Console.ReadLine();
            bool playerNameIsCorrect = false;
            string answerToNameClarification;
            while (!playerNameIsCorrect)
            {
                Console.WriteLine("Is " + name + " the correct name?");
                Console.WriteLine("yes or no");
                answerToNameClarification = Console.ReadLine();
                answerToNameClarification = answerToNameClarification.ToLower();

                if(answerToNameClarification == "yes")
                {
                    playerNameIsCorrect = true;
                }
                else if (answerToNameClarification == "no")
                {
                    Console.WriteLine("What is your name then unproven hero?");
                    Console.Write("Name:");
                    name = Console.ReadLine();
                }
                else
                {
                    
                }
            }

            string classChoice = "";
            Console.WriteLine("Well, " + name + " that's a pretty terrible name but, we'll move on.");
            Console.WriteLine("What class would you like to be?");
            Console.WriteLine("Warrior   |   Mage   |   Thief");
            classChoice = Console.ReadLine();
            classChoice = classChoice.ToLower();
            bool classChoiceIsCorrect = false;
            string answerToClassClarification = "";
            bool classChoiceIsDone = false;

            while (!classChoiceIsDone)
            {
                if (classChoice != "warrior" && classChoice != "mage" && classChoice != "thief")
                {
                    Console.WriteLine("Invalid class name");
                    classChoice = Console.ReadLine();
                    classChoice = classChoice.ToLower();
                }
                else
                {
                    if (!classChoiceIsCorrect)
                    {
                        Console.WriteLine("Is " + classChoice + " the correct class?");
                        Console.WriteLine("yes or no");
                        answerToClassClarification = Console.ReadLine();
                        answerToClassClarification = answerToClassClarification.ToLower();

                        if (answerToClassClarification == "yes")
                        {
                            classChoiceIsDone = true;
                        }
                        else if (answerToClassClarification == "no")
                        {
                            Console.WriteLine("What class are you then unproven hero?");
                            Console.Write("Class:");
                            classChoice = Console.ReadLine();
                        }
                        else
                        {

                        }
                    }
                }
            }

            Player.Class playerClass = Player.Class.Warrior;

            switch (classChoice)
            {
                case "warrior":
                    playerClass = Player.Class.Warrior;
                    break;
                case "mage":
                    playerClass = Player.Class.Mage;
                    break;
                case "thief":
                    playerClass = Player.Class.Thief;
                    break;
            }

            Player player = new Player(1, name, playerClass);

            

            //Forcibly run the world static constructor
            //Type type = typeof(World);
            //System.Runtime.CompilerServices.RuntimeHelpers.RunClassConstructor(type.TypeHandle);

            // Console.Write(player.ToString());

            Console.WriteLine(player.ToString());
            Console.ReadKey();

            string command = ""; 

            while (true)
            {
                command = Console.ReadLine();
                command = command.ToLower();
                switch (command)
                {
                    case "north":
                        player.MoveNorth();
                        break;
                    case "south":
                        player.MoveSouth();
                        break;
                    case "west":
                        player.MoveWest();
                        break;
                    case "east":
                        player.MoveEast();
                        break;
                    case "vendor":
                        if(player.CurrentLocation.VendorInLocation != null)
                        {
                            Console.WriteLine(player.CurrentLocation.VendorInLocation.ToString());
                        }
                        break;
                    case "stats":
                        player.ToString();
                        break;
                    case "inventory":
                        player.PlayerEquipmentInventory.ToString();
                        break;
                    case "100":
                        player.GainExperience(100);
                        Console.WriteLine(player.ToString());
                        break;
                    case "1000":
                        player.GainExperience(1000);
                        Console.WriteLine(player.ToString());
                        break;
                }
            }
        }
    }
}
