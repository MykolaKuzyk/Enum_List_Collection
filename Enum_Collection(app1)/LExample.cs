using System;
using System.Collections.Generic;
using System.Text;

namespace Enum_Collection_app1_
{
    class LExample
    {
        List<Card> newCard = new List<Card>();

        public LExample()
        {
            newCard.Add(new Card("Ace", "Spades"));
            newCard.Add(new Card("Peek", "NewExmple"));


        }

        public void runList()
        {
            bool cardNo = false;

            foreach (Card card in newCard)
            {
                if (card is Card)
                {
                    Console.WriteLine("---- {0}", card.Name);
                }
                else
                {
                    Console.WriteLine("--------");
                }
            }
        }
        

        
    }

}
