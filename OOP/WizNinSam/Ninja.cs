using System;

namespace WizNinSam
{
    public class Ninja : Human
    {
        public Ninja(string name, int str, int intel, int hp) : base(name, str, intel, 175, hp)
        {
        }

        public override int Attack(Human target)
        {
            int dmg = 5 * target.Dexterity;
            Random chance = new Random();
            int i = chance.Next(6);
            if (i == 4)
            {
                dmg += 10;
            }
            Console.WriteLine(dmg);
            target.health -= dmg;
            return target.health;
        }

        public void Steal(Human target)
        {
            target.health -= 5;
            this.health += 5;
        }
    }
}