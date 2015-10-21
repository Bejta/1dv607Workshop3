using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.model
{
    interface IObserver
    {
        void cardDrawn(Card a_card);
    }
}
