using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.model.rules
{
    class TiePlayerWins:IWinningStrategy
    {
        public bool Win(Player a_player, Dealer a_dealer, int maxScore)
        {
            if (a_player.CalcScore() > maxScore)
            {
                return true;
            }
            else if (a_dealer.CalcScore() > maxScore)
            {
                return false;
            }
            return a_player.CalcScore() >= a_dealer.CalcScore();
        }
    }
}
