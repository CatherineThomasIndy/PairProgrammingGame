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
        BasicSelections _basicRepo = new BasicSelections();
        WrongSelections _wrongRepo = new WrongSelections();
        StoryElements _storyRepo = new StoryElements();
        private bool _isRunning = true;
        bool hasMap = false;

        public void Start()
        {
            Console.WriteLine("The Pirate Game! ARGGGGGGGGG!");
            Console.ReadKey();
            Menu();
        }

        private void Menu()
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
            Console.WriteLine("What'll ye do, captain?\n" +
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
                    QuitGame();
                    break;
                default:
                    Console.WriteLine("You couldn't read the map ya scallywag! Return to the selection menu and pick again!");
                    Console.ReadKey();
                    GetMenuSelection();
                    return;
            }

        }

        private void DisplayStartPoint()
        {
            Console.WriteLine("You wake as the captain of the Ship Ruby of the Sea, after a long night on the waves.\n" +
                "Your crew has been busy working through the night, as the ocean rocked the Ruby back and forth.");
            Console.ReadKey();
            Console.WriteLine("\nImmediately you feel that something is wrong. You can smell it in the salty air. In the movements of the Ruby.\n" +
                "In the squawking of your parrot, Charles.");
            Console.ReadKey();
            Console.WriteLine("\nStumbling out of bed, you graps for the nearest beverage, and call for your first mate; Sir Hooks Alot.");
            Console.ReadKey();
            Console.WriteLine("\nSir Hooks Alot, in his usual persnickety tone responds loudly 'Captain you rang?'");
            Console.ReadKey();
            Console.WriteLine("\n'Aye, where are we?' You respond in a tone representing your vast expirience at sea.");
            Console.ReadKey();
            Console.WriteLine("\n'Cap, whatever do you mean?' Sir Hooks Alot barks back.");
            Console.ReadKey();
            Console.WriteLine("\nYou say, 'Something is wrong. The sea and ship, they don't seem right!'");
            Console.ReadKey();
            Console.WriteLine("\n'*Squawk* Aint right, aint right.' Charles chirped.");
            Console.ReadKey();
            Console.WriteLine("\nYou collect yourself and command, 'Bring me the map, Sir Hooks Alot, and meet me at the helm!'");
            Console.ReadKey();
            Console.WriteLine("\n'*Squawk* Bring the captain the map, before you walk the plank!' Charles retorts.");
            Console.ReadKey();
            Console.Clear();
            ChapterOne();
        }

        private void ChapterOne()
        {
            Console.WriteLine("Looking at the map and the stars, you realize that you are completely lost.\n" +
                "The only thing to do now is to pick a direction and sail.");
            _basicRepo.GetAllDirections();
            string input = Console.ReadLine();

            switch (input)
            {
                case "1": //n
                    _basicRepo.TravelNorth();
                    
                    break;
                case "2": //s
                    _basicRepo.TravelSouth();
                    break;
                case "3": //e
                    _basicRepo.TravelEast();
                    break;
                case "4": //w
                    _basicRepo.TravelWest();
                    break;
                case "5":
                    _basicRepo.OtherOptions();
                    break;
                default:
                    _basicRepo.InvalidDirection();
                    return;
            }
        }


        private void SelectADirection()
        {
            _basicRepo.GetAllDirections();
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    _basicRepo.TravelNorth();
                    break;
                case "2":
                    _basicRepo.TravelSouth();
                    break;
                case "3":
                    _basicRepo.TravelEast();
                    break;
                case "4":
                    _basicRepo.TravelWest();
                    break;
                default:
                    _basicRepo.InvalidDirection();
                    Console.ReadKey();
                    SelectADirection();
                    break;

            }
        }

        //Display Save Point
        private void DisplaySavePoint()
        {
            Console.WriteLine("Select the area from which you'd like to return:\n" +
                "1. The beach\n" +
                "2. The ruins\n" +
                "3. The temple");
            string userInput = Console.ReadLine();

            switch(userInput)
            {
                case "1":
                    //return //save point island repo;
                break;
                case "2":
                    //return //save point at ruins;
                break;
                case "3":
                    //return //save point Sir Hooks Alot Betryal / Fight;
                break;
                default:
                    _basicRepo.InvalidSelection();
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
            Console.ReadKey();
        }

        private void GetOtherOptions(string userInput)
        {
            _basicRepo.OtherOptions();

            switch (userInput)
            {
                case "1":
                    { if (hasMap = false)
                        {
                            _basicRepo.Inventory();
                        }
                        else _basicRepo.InventoryWithMap();
                    }
                    break;
                case "2": GetMenuSelection();
                    break;
                default:
                    _basicRepo.InvalidSelection();
                    break;
            }
        }

        private void QuitGame()
        {
            Console.WriteLine("Arrrrgh, see you next time, matey!");
            Console.ReadKey();
            _isRunning = false;
        }
    }
}

