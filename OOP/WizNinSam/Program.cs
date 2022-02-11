using System;

namespace WizNinSam
{
    class Program
    {
        static void Main(string[] args)
        {
            Ninja Alfredo = new Ninja("Alfredo");
            Wizard Luigi = new Wizard("Luigi");
            Samurai Karma = new Samurai("Karma");

            Console.WriteLine(Luigi.Attack(Karma));
            Console.WriteLine(Alfredo.Attack(Karma));
            Console.WriteLine(Luigi.Heal(Karma));
            Alfredo.Attack(Karma);
            Console.WriteLine(Karma.health);
        }
    }
}
