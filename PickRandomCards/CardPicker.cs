using System;
using System.Collections.Generic;
using System.Text;

namespace PickRandomCards
{
    class CardPicker
    {

        static Random random = new Random();

        public static string[] PickSomeCards(int numberOfCards)
        {
            string[] pickedCards = new string[numberOfCards];
            for (int i = 0; i < numberOfCards; i++) 
            {
                pickedCards[i] = RandomValue() + " of " + RandomSuit();
            }
            return pickedCards;
        }

        private static string RandomValue()
        {
            int Value = random.Next(1, 14);
            if (Value == 1) return "Ace";
            if (Value == 11) return "Jack";
            if (Value == 12) return "Queen";
            if (Value == 13) return "King";
            return Value.ToString();
        }

        private static string RandomSuit()
        {
            int Value = random.Next(1, 5);
            if (Value == 1) return "Spades";
            if (Value == 2) return "Hearts";
            if (Value == 3) return "Diamonds";
            return "Clubs";
        }
    }
}
