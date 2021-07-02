using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pair_Programing_Console_Game
{
    class ProgramUI
    {
        BasicSelections _repo = new BasicSelections();
        private bool _isRunning = true;
        public void Start()

        {
            Console.WriteLine("The Pirate Game! ARGGGGGGGGG!");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Mysteries of the Seven Seas");
            Menu();
        }

        public void Menu()
        {
            while (_isRunning)
            {
                string userInput = GetMenuSelection();
                OpenMenuItem(userInput);
            }


        }
        private string GetMenuSelection()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Streaming Content Management System.\n" +
                            "Select Menu Item:\n" +
                            "1. Start A New Game\n" +
                            "2. Continue\n" +
                            "3. Extras / Cheats \n" +
                            "4. Credits \n" +
                            "5. Exit");

            string userInput = Console.ReadLine();
            return userInput;
        }

        private void OpenMenuItem(string userInput)
        {
            Console.Clear();

            switch (userInput)
            {
                case "1":
                    //Start the Game
                    DisplayStartPoint();
                    break;
                case "2":
                    //Continue From a Point, Multiple Swtich cases per save point in the content for this  
                    DisplaySavePoint();
                    break;
                case "3":
                    //Extras / Cheats / Display Map
                    DisplayMap();
                    break;
                case "4":
                    //Give Credits to Catie, Jared, and Rob (Probably just Catie and Rob)
                    DisplayCredit();
                    break;
                case "5":
                    //Console close.
                    _isRunning = false;
                    return;
                default:
                    Console.WriteLine("You couldn't read the map ya scallywag! Return to your treasure and start over!");
                    GetMenuSelection();
                    return;
            }

        }

        private void DisplayStartPoint()
        {
            Console.WriteLine("You wake as the captain of the Ship Ruby of the Sea, after a long night at sea. Your crew has been busy working through the night, as the sea rocked the Ruby back and forth.");
            Console.ReadKey();
            Console.WriteLine("Immediately you feel that something is wrong. You can smell it in the salty air. In the movements of the Ruby. In the squawking of your parrot, Charles.");
            Console.ReadKey();
            Console.WriteLine("Stumbling out of bed, you graps for the nearest beverage, and call for your first mate; Sir Hooks Alot.");
            Console.ReadKey();
            Console.WriteLine("Sir Hooks Alot, in his usual persnickety tone responds loudly 'Captain you rang?'");
            Console.ReadKey();
            Console.WriteLine("'Aye, where are we?' You respond in a tone representing your vast expirience at sea.");
            Console.ReadKey();
            Console.WriteLine("Cap whatever do you mean?");
            Console.ReadKey();
            Console.WriteLine("Something is wrong. The sea and ship, they don't seem right!");
            Console.ReadKey();
            Console.WriteLine("*Squawk* 'Aint right, aint right.' Charles chirped");
            Console.ReadKey();
            Console.WriteLine("Bring me the map! Sir Hooks Alot, and meet me at the helm!");
            Console.ReadKey();
            Console.WriteLine("*Squawk* 'Bring the captain the map, before you walk the plank!'");
            Console.ReadKey();
            Console.Clear();
            _repo.GetAllDirections(); //Traveling from the bed to the helm is the "tutorial" for the game.
        }


        private void SelectADirection()
        {
            _repo.GetAllDirections();
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    _repo.TravelNorth();
                    break;
                case "2":
                    _repo.TravelSouth();
                    break;
                case "3":
                    _repo.TravelEast();
                    break;
                case "4":
                    _repo.TravelWest();
                    break;
                default:
                    _repo.InvalidDirection();
                    Console.ReadKey();
                    SelectADirection();
                    break;

            }
        }

        //Display Save Point
        private void DisplaySavePoint()
        {
            Console.WriteLine("Select the area from which you'd like to return:\n" +
                "A. The beach\n" +
                "B. The ruins\n" +
                "C. The temple");
            string userInput = Console.ReadLine().ToLower();

            switch (userInput)
            {
                case "A":
                    return //save point island repo;
                break;
                case "B":
                    return //save point at ruins;
                break;
                case "C":
                    return //save point Sir Hooks Alot Betryal / Fight;
                break;
                default:
                    Console.WriteLine("*Squawk* 'Pick again'");
                    Console.ReadKey();
                    DisplaySavePoint();
                    break;
            }
        }

        //Display Map

        private void DisplayMap()
        {
            Console.WriteLine("Here are the right directions to find your treasure!\n" +
                "1. Travel East\n" +
                "2. Travel North\n" +
                "3. Read the journal\n" +
                "4. Take the map\n" +
                "5. Return to the beach\n" +
                "6. Travel South\n" +
                "7. Select the North statue\n" +
                "8. Draw your pistol\n" +
                "\n" +
                "Press any key to return to the menu selection.");
            Console.ReadKey();
            Menu();
        }

        //Display credits
        private void DisplayCredit()
        {
            Console.WriteLine("By Catie and Rob!");
        }
    }
}

