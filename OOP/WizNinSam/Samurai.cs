using System;

namespace WizNinSam{
    public class Samurai : Human
    {
        public Samurai(string name, int str, int intel, int dex) : base (name, str, intel, dex, 200)
        {
        }

        public override int Attack(Human target)
        {
            base.Attack(target);
            if(target.health < 50){
                target.health = 0;
            }
            return target.health;
        }

        public int Meditate()
        {
            this.health = 200;
            return this.health;
        }
    }
}