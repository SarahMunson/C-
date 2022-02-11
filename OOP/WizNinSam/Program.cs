using System;

namespace WizNinSam
{
    class Program
    {
        static void Main(string[] args)
        {
            Ninja Alfredo = new Ninja("Alfredo", 25, 9, 100);
            Wizard Luigi = new Wizard("Luigi", 15, 80);
            Samurai Karma = new Samurai("Karma", 20, 30, 85);

            Console.WriteLine(Luigi.Attack(Karma));
            Console.WriteLine(Alfredo.Attack(Karma));
            Console.WriteLine(Luigi.Heal(Karma));
            Alfredo.Attack(Karma);
            Console.WriteLine(Karma.health);
        }
    }
}
