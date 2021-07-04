using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class StoryElements
    {
        public string RockyOutcrop()
        {
            return "The crows nest sees a rocky outcropping ahead! 'Backtrack or cross the gallows,' crosses your mind." + 
                "\nHowever, there might be treasure located among the wreckages of those who dared to tread its waters. Do you continue?";
        }

        public string MysteriousIsland() //Save Point A
        {
            return "A mysterious island arises out of the mist. Its mountain overcasts the jungle below. Charles *squawks* 'Turn back! Turn back!' Do you continue?";
        }

        public string GiantWhirlpool()
        {
            return "A whirlpool the size of three ships lies ahead of the Ruby. Its water is choppy and you the see the remnants of an old Spanish vessel." +
                "\nDo you risk going after the gold you know is awaiting you?";
        }

        public string Kraken()
        {
            return "Over the horizon you see the waves start to move in a forboding motion.\n" + 
                "A dark shape appears and slowly moves toward the Ruby. Do you continue?";
        }

        public string IslandShipReturn()
        {
            return "You venture into the jungle, and after a day's march you arrive back at your boat. Confused, you wonder if this is all the island has to offer?";
        }

        public string IslandCave()
        {
            return "Gathering your supplies, you and your crew venture to the junge towards the mountain.\n" +
                "Chopping through the dense vegetation, you eventually find the entrance to a long forgotten cave.\n" +
                "Your crew wants to turn around, but Sir-Hooks-Alot wants to press onaward. Do you continue?";
        }

        public string Skeleton()
        {
            return "As you and your crew make your way deeper and deeper into the cave you eventually come across the bones of old sailor.\n" +
                "The sailor appears to have been holding on to some things before he died. Do you want to take a look?\n";
        }

        public string Ruins() //Save Point B
        {
            return "On the Southern edge of the island there is a old set of Ruins. There have obviously been people here before.\n" +
                "You go an investigate the ruins, and find an ornate courtyard.\n" +
                "Inside the courtyard in every cardinal direction there statues depicating battles of the past.\n" +
                "As you and your crew marvel at the statues, you cannot help and wonder if there something important here.\n";
        }

        public string DenseJungle()
        {
            return "A dense jungle lies ahead. You think you and your crew could probably cut your way through.\n" +
                "However, you also get a gut feeling that something sinister lurks in there. Do you wish to continue?\n";
        }

        public string MermaidStatue()
        {
            return "To the North there is a Mermaid statue, with her hand pointing towards a mostly-intact wall of the ruins. \n" +
                "Aside from the statue's great beauty, there doesn't seem to be much of value over here.\n";
        }

        public string Skull()
        {
            return "On the Southern end of the courtyard directly accross from the mermaid, there lie an ornate skull stature. While the smallest of all teh statues, it is jewel and gold encrusted. Your crew drools with greedy, at the emerands in the eye sockets. As you reach towards the skull you cant help but wonder if there is more then meets the eye?";
        }
    }
}
