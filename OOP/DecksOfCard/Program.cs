using System;

namespace DecksOfCard
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            Player yoMama = new Player("yoMama");
            deck.Shuffle();
            yoMama.Draw(deck, yoMama);
            yoMama.Draw(deck, yoMama);
            yoMama.Draw(deck, yoMama);
            yoMama.Draw(deck, yoMama);
            yoMama.Draw(deck, yoMama);
            Console.WriteLine("That was a good poker hand");
        }
    }
}
