using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class WrongSelections
    {
        public string RockyOutcropContinue()
        {
            return "You guide your ship toward the rocky outcrop.\n " +
                "Unfortunately, your hull was not prepared to take such a beating and your crew below deck yell out that the boat is taking on too much water!\n" +
                "As your ship is breaking apart into the ocean, it occurs to you that sailing toward the rocks was probably a bad idea.\n";
        }

        public string WhirlpoolContinue()
        {
            return "You guide your ship toward the Spanish Galleon hoping to plunder it.\n" +
                "Unfortunately, the whirlpool's current was far too strong and despite all your crew's efforts, the ship drifts toward the center.\n" +
                "As your ship spirals and sucks your boat deeper into the ocean, it occurs to you that sailing toward the whilrpool was probably a bad idea.\n";
        }

        public string KrakenContinue()
        {
            return "Suddenly the legendary beast, the Kraken, appears!\n" +
                "In a flurry of flesh and tentacles it attacks your ship, crushing it to pieces.\n" +
                "As your crew cry out about their demise, it occurs to you that sailing toward the beast was probably a bad idea.\n";
        }

        public string JungleContinue()
        {
            return "You and your crew decide to chop your way through the dense jungle.\n" +
                "At first, it doesn't feel so hard and you feel like you've made great progress.\n" +
                "However, as you start to get exhausted, you turn around to see that you've only ventured a few feet.\n" +
                "You know it has been quite a while, and you get a sinking feeling that something is very wrong.\n" +
                "As you look at your crew mates, you notice they have a glazed look on their face.\n" +
                "Vines are curled tightly around their ankles. As you look down, you realize the vines have taken yours as well.\n" +
                "Suddenly, snakes descend from the treetops and attack your crew!\n" +
                "As you are being swallowed by a giant snake, it occurs to you that going into the jungle was probably a bad idea.\n";
        }
    }
}
