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

        int totalCardNumber = 52;

        public List<Card> CreateCardList()
        {
            for (int color = 0; color < 2; color++)
            {
                for (int suit = 0; suit < 4; suit++)
                {
                    for (int rank = 0; rank < 13; rank++)
                    {
                        cardPack.Add(new Card((Color)color, (Suit)suit, (Rank)rank));
                    }
                }
            }
            return cardPack;
        }
    }
}
