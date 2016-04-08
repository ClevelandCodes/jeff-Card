using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Suits = { "Clubs", "Diamonds", "Hearts", "Spades" };
            Card[] deck = new Card[52];
            for (int i = 0; i < Suits.Length; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    deck[i * 13 + j] = new Card(Suits[i], j + 1);
                }
            }


            int nextIndex = 0;
            Random rnd = new Random();
            Card[] shuffledDeck = new Card[52];
            while (nextIndex < 52)
            {
                int randomNumber = rnd.Next(52);
                if (deck[randomNumber] != null)
                {
                    shuffledDeck[nextIndex] = deck[randomNumber];
                    deck[randomNumber] = null;
                    nextIndex++;
                }
            }

            for (int i = 0; i < shuffledDeck.Length; i++)
            {
                Console.WriteLine(shuffledDeck[i].getFaceValue() + " " + shuffledDeck[i].getSuit());
            }
        }
    }
}
