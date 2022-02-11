using System;

namespace WizNinSam{
    public class Wizard : Human
    {
        //add unique features to being a Wizard if any
        public Wizard(string name, int str, int dex) : base(name, str, 25, dex, 50)
        {
            
        }

        public override int Attack(Human target)
        {
            int dmg = target.Intelligence * 5;
            target.health -= dmg;
            this.health += dmg;
            return target.health;
        }

        public int Heal(Human target)
        {
            int healeth = target.Intelligence * 10;
            target.health += healeth;
            return target.health;
        }
    }
}