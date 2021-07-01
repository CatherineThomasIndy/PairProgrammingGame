using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pair_Programing_Console_Game
{
    class ProgramUI
    {
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
            }

            string GetMenuSelection()
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
                        //Give Creidts to Catie, Jared, and Rob (Probably just Catie and Rob)
                        DisplayCredit();
                        break;
                    case "5":
                        //Console close.
                        _isRunning = false;
                        return;
                    default:
                        Console.WriteLine("You couldn't read the map ya scallywag! Return to your treasure and startover!");
                        GetMenuSelection();
                        return;
                }

            }

        }


        /*Start location: probably somewhere in the ocean, real place?
        Will probably read like: "You are currently sailing off the coast of [island], which is to your [direction].
        To your [other direction] is a vast, open sea. There are tales of dangers lurking beneath the water, and no one has ever made it back.
        To your [other direction] is the tropical gulf of [country]. 
        To your [other direction] is [another island]. 
        Where would you like to go?
        list of possible commands: west, go west, sail west, north, go north, sail north, etc. for east & south; sing, drink*/

    }
}
