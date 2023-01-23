using System;

namespace Enum_Collection_app1_
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Deck deck = new Deck();
            Card aceOfSpades = new Card("Ace", "Spades");
            Console.WriteLine(aceOfSpades.Name);
            
            Random random = new Random();
            int randomSuits = random.Next(1, 4);
            int randomValue = random.Next(1, 14);
                
            Card myCard = new Card(randomSuits.ToString(), randomValue.ToString());
            Console.WriteLine(myCard.Name);
            deck.PrnitCards();


            LExample newExample = new LExample();
            newExample.runList();

            

            
            




        }


    }
}
