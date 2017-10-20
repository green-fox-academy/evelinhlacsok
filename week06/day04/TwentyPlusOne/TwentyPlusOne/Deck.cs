using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyPlusOne
{
    class Deck
    {
        Random random = new Random();
        List<Card> cardPack = new List<Card>();

        int randomColorMax = Enum.GetValues(typeof(Color)).Length;
        int randomSuitMax = Enum.GetValues(typeof(Suit)).Length;
        int randomRankMax = Enum.GetValues(typeof(Rank)).Length;

        int totalCardNumber = 104;

        public void ShuffleIt()
        {
            for (int i = 1; i <= totalCardNumber; i++)
            {
                cardPack.Add(new Card((Color)random.Next(randomColorMax), (Suit)random.Next(randomSuitMax), (Rank)random.Next(randomRankMax)));
            }

            Console.WriteLine("list of cards: ");
            Console.ReadLine();
        }
    

        //public List<Card> CreateCardList ()
        //{
        //    for (int color = 1; color <= 2; color++)
        //    {
        //        for (int suit = 1; suit <= 4; suit++)
        //        {
        //            for (int rank = 1; rank <= 13; rank++)
        //            {
        //                cardPack.Add(new Card((Card.
        //            }
        //        }
        //    }
        //}
    }
}
