using System;
using System.Collections.Generic;

namespace DecksOfCard
{
    public class Deck
    {

        string[] stringCards = {"Ace","2","3","4","5","6","7","8","9","10","Jack","Queen","King"};

        string[] suits = {"Clubs", "Spades", "Hearts", "Diamonds"};

        public List<Card> cards = new List<Card>();
        public Deck()
        {
            foreach(string suit in suits)
            {
                int cardValue = 1;
                foreach(var stringVal in stringCards)
                {
                    Card newCard = new Card(stringVal, suit, cardValue);
                    cards.Add(newCard);
                    cardValue++;
                }
            }
        }

        public Card Deal()
        {
            Card dealCard = cards[0];
            cards.Remove(dealCard);
            Console.WriteLine($"{dealCard.stringVal} of {dealCard.suit}");
            return dealCard;
        }

        public void Reset()
        {
            cards.Clear();
            foreach (string suit in suits)
            {
                int val = 1;
                foreach(var stringVal in stringCards)
                {
                    Card newCard = new Card(stringVal, suit, val);
                    cards.Add(newCard);
                    val++;
                }
            }
        }

        public void Shuffle()
        {
            Random wut = new Random();
            for(int i = 0; i < cards.Count; i++)
            {
                int newVal = wut.Next(cards.Count);
                Card temp = cards[i];
                cards[i] = cards[newVal];
                cards[newVal] = temp;
            }
        }
    }
}