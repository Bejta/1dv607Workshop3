using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.model.rules
{
    class RulesFactory
    {
        public IHitStrategy GetHitRule()
        {
            // Change here to SoftSeventeenGameRule if needed
            // return new SoftSeventeenGameRule
            return new BasicHitStrategy();
        }

        public INewGameStrategy GetNewGameRule()
        {
            return new AmericanNewGameStrategy();
        }

        public IWinningStrategy GetWinningRule()
        {
            // return new TieDealerWins() in case we wont Dealer victory on equal score
            return new TiePlayerWins();
        }
    }
}
