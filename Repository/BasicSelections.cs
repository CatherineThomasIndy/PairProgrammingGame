using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class BasicSelections
    {
        public string InvalidDirection()
        {
            return "Argh, that's not a direction!";
        }

        public void InvalidSelection()
        {
            Console.Clear();
            Console.WriteLine("'Invalid selection!' *Squawk* 'Pick again!'");
            Console.ReadKey();
        }

        public string GetAllDirections()
        {
            Console.WriteLine("Select the direction you wish to travel, or look at the other options:\n" +
                "1. North\n" +
                "2. South\n" +
                "3. East\n" +
                "4. West\n" +
                "5. Other Options\n");

            string userInput = Console.ReadLine();
            return userInput;
        }

        public string OtherOptions()
        {
            Console.WriteLine("What would you like to do?\n" +
                "1. Check inventory\n" +
                "2. Go back to main menu\n");

            string userInput = Console.ReadLine();
            return userInput;
        }

        public string Inventory()
        {
            return "You currently have a compass, a knife, a cutlass, and a pistol.";
        }

        public string InventoryWithMap()
        {
            return "You currently have a compass, a knife, a cutlass, and a pistol, as well as the map you grabbed in the cave.";
        }


        public string TravelWest()
        {
            return "You decide to go westward.";
        }

        public string TravelNorth()
        {
            return "You decide to go northward.";
        }

        public string TravelEast()
        {
            return "You decide to go eastward.";
        }

        public string TravelSouth()
        {
            return "You decide to go southward.";
        }

        public string DangerousSituation()
        {
            return "Your crew could not survive. Start Over?";
        }
    }

}