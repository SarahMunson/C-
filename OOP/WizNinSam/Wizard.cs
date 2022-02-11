using System;

namespace WizNinSam{
    public class Wizard : Human
    {
        //add unique features to being a Wizard if any

        //I'm wondering WHY this works with my arguments until I try to delete everything up to name I realized that I had to hard code the base values. I'm just confused ;(
        public Wizard(string name, int str, int dex) : base(name, 3, 25, 3, 50)
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