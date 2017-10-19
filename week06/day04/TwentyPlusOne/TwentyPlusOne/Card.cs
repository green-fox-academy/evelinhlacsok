using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyPlusOne
{
    public enum Color
    {
        Red,
        Black
    }

    public enum Suit
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades
    }

    public enum Rank
    {
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        J,
        Q,
        K,
        A
    }
    class Card
    {
        public Color Color;
        public Suit Suit;
        public Rank Rank;

        public Card(Color color, Suit suit, Rank rank)
        {
            Color = color;
            Suit = suit;
            Rank = rank;
        }

        public string GetCard()
        {
            return String.Format("{0} { 1} { 2}", Color, Suit, Rank);
        }
    }
}
