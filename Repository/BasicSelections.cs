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
        public string GetAllDirections()
        {
            Console.WriteLine("Select the direction you wish to travel:\n" +
                "1. North\n" +
                "2. South\n" +
                "3. East\n" +
                "4. West\n");

            string userInput = Console.ReadLine();
            return userInput;
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

    public class StoryElements
    {
        public string RockyOutcrop()
        {
            return "The crows nest sees a rocky outcropping ahead! Bakctrack or go to the gallows, cross your mind. However there might be treasure located among the wreckages of those who dared to tred its waters. Do you continue?";
        }

        public string MysteriousIsland() //Save Point A
        {
            return "A mysterious island arrises out of the mist. Its mountain overcasts the jungle below. Charles *squawks* 'Turn back! Turn back!' Do you continue?";
        }

        public string GiantWhirlpool()
        {
            return "A whirlpool the size of three ships lies ahead of the Ruby. Its water is choppy and you the see the remnants of an old Spanish vessel. Do you risk going after the gold you know is awaiting you?";
        }

        public string Kraken()
        {
            return "Over the horrizen you see the waves start to move in a forboding motion. A dark shape appears and slowly moves toward the Ruby. Do you continue?";
        }

        public string IslandShipReturn()
        {
            return "You venture into the jungle, and after a day's march you arrive back at your boat. Confused, you wonder if this is all the island has to offer?";
        }

        public string IslandCave() 
        {
            return "Gathering your supplies, you and your crew venture to the junge towards the mountain. Chopping through the dense vegitation your eventually find the enterance to a long forgotten cave. Your crew wants to turn around, but Sir-Hooks-Alot wants to press onaward. Do you?";
        }

        public string Skeleton()
        {
            return "As you and your make your way deeper and deeper into the cave you eventually come accross the bones of old sailer. In the his hands there lies a map and a journel. You take the map and journel, with your tourch providing your only light. You immediately recognize marker on the map, and realize it can lead you to salvation. The only problem is how will you get back to your ship through the jungle?" //Go back to IslandCave Method
        }
        
        public string Ruins() //Save Point B
        {
             return "On the Southern edge of the island there is a old set of Ruins. There have obviously been people here before. You go an investigate the ruins, and find an ornate courtyard. Inside the courtyard in every cardinal direction there statues depicating battles of the past. As you and your crew marvel at the stature, you cannot help and wonder if there something that you are missing."; 
        }

        public string DenseJungle()
        {
            return "A dense jungle lies ahead. Will you continue forward braving, no hoping to see what lies within its shawdows?";
        }

        public string MermaidStature()
        { 
            return "To the North there is a Mermaid statue, with her hand pouting downwards toward the wall. Almost beckoning your crew over. However outside of her artistic beauty there seems to other signs of value. Your crews attention quickly turns elseware.";
        }

        public string Skull()
        {
            return "On the Southern end of the courtyard directly accross from the mermaid, there lie an ornate skull stature. While the smallest of all teh statues, it is jewel and gold encrusted. Your crew drools with greedy, at the emerands in the eye sockets. As you reach towards the skull you cant help but wonder if there is more then meets the eye?";
        }
    }
}