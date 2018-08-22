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
            string answerToNameQuestion;
            while (!playerNameIsCorrect)
            {
                Console.WriteLine("Is " + name + " the correct name?");
                Console.WriteLine("yes or no");
                answerToNameQuestion = Console.ReadLine();
                answerToNameQuestion = answerToNameQuestion.ToLower();

                if(answerToNameQuestion == "yes")
                {
                    playerNameIsCorrect = true;
                }
                else if (answerToNameQuestion == "no")
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
            Console.WriteLine("Well " + name + " while thats a pretty terrible name we'll move on.");
            Console.WriteLine("What class would you like to be?");
            Console.WriteLine("Warrior   |   Mage   |   Thief");
            classChoice = Console.ReadLine();
            classChoice = classChoice.ToLower();
            bool classChoiceIsCorrect = false;

            while (!classChoiceIsCorrect)
            {
                switch (classChoice)
                {
                    case "warrior":
                        Console.WriteLine("Is Warrior your class choice?");
                        
                        break;
                    case "mage":
                        break;
                    case "thief":
                        break;
                    default:
                        classChoice = Console.ReadLine();
                        classChoice = classChoice.ToLower();
                        break;
                }
            }

            Player player = new Player(1, name, Player.Class.Warrior);

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
