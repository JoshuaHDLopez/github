using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Durak_Group3
{
    class Player
    {
        //player's cards
        public Card[] cards;
        //current number of cards in hand
        public int numberOfCards;

        public Player()
        {
            cards = new Card[52]; //player will never have more than this number of cards
            numberOfCards = 0;
        }
    }
}
