using System;
using System.Collections.Generic;

namespace DecksOfCard
{
    public class Player
    {
        public string name;
        public List<Card> hand = new List<Card>();
        public Player(string nm)
        {
            name = nm;
        }

        public Card Draw(Deck deck, Player player)
        {
            string person = player.name;
            Card playCards = deck.Deal();
            hand.Add(playCards);
            return playCards;
        }

        public Card Discard(int card)
        {
                Card disCard = hand[card];
                hand.Remove(disCard);
                return disCard;
        }
    }
}