using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    class WrongSelections
    {
        public string RockyOutcropContinue()
        {
            return "You guide your ship toward the rocky outcrop. " +
                "Unfortunately, your hull was not prepared to take such a beating and your crew below deck yell out that the boat is taking on too much water!" +
                "As your ship is breaking apart into the ocean, it occurs to you that sailing toward the rocks was probably a bad idea.";
        }

        public string WhirlpoolContinue()
        {
            return "You guide your ship toward the Spanish Galleon hoping to plunder it." +
                "Unfortunately, the whirlpool's current was far too strong and despite all your crew's efforts, the ship drifts toward the center." +
                "As your ship spirals and sucks your boat deeper into the ocean, it occurs to you that sailing toward the whilrpool was probably a bad idea.";
        }

        public string KrakenContinue()
        {
            return "Suddenly the legendary beast, the Kraken, appears!" +
                "In a flurry of flesh and tentacles it attacks your ship, crushing it to pieces." +
                "As your crew cry out about their demise, it occurs to you that sailing toward the beast was probably a bad idea.";
        }
    }
}
