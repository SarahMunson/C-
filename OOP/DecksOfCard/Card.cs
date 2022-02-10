using System;
using System.Collections.Generic;

namespace DecksOfCard
{
    public class Card
    {
        public string stringVal;
        public string suit;
        public int val;
        public Card(string sv, string st, int vl)
        {
            stringVal = sv;
            suit = st;
            val = vl;
        }
    }
}