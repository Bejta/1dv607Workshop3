using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.model.rules
{
    class AmericanNewGameStrategy : INewGameStrategy
    {
        public bool NewGame(Deck a_deck, Dealer a_dealer, Player a_player)
        {

            a_dealer.DealCard(a_player, true);
            //dealer deals
            a_dealer.DealCard(null,true);
            a_dealer.DealCard(a_player,true);
            a_dealer.DealCard(null,false);

            return true;
        }
    }
}
