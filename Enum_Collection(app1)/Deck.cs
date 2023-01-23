using System;
using System.Collections.Generic;
using System.Text;

namespace Enum_Collection_app1_
{
    class Deck
    {
        private readonly Card[] cards = new Card[52];

        public Deck()
        {
            int index = 0;
            for (int suit = 0; suit <= 3; suit++)
            {
                for (int value = 1; value <=13; value++)
                {
                    cards[index++] = new Card( value.ToString(),
                                              suit.ToString());
                }
            }
        }

        public void PrnitCards()
        {
            for (int i = 0; i< cards.Length; i++)
            {
                Console.WriteLine(cards[i].Name);
            }
        }
    }   
}
