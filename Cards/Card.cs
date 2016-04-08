using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards
{
    class Card
    {
        private string Suit;
        private int FaceValue;

        public Card(string suit, int facevalue)
        {
            Suit = suit;
            FaceValue = facevalue;
        }

        public string getSuit()
        {
            return Suit;
        }

        public int getFaceValue()
        {
            return FaceValue;
        }
    }
}
