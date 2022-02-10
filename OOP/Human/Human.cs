using System;

namespace Human
{
    public class Human
    {
        // Fields for Human
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        private int health;

        // add a public "getter" property to access health
        public int Health
        {
            get {return health;}
        }


        // Add a constructor that takes a value to set Name, and set the remaining fields to default values
        public Human(string nm)
        {
            Name = nm;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            health = 100;
        }

        // Add a constructor to assign custom values to all fields
        public Human(string nm, int st, int iq, int dx, int hlt)
        {
            Name = nm;
            Strength = st;
            Intelligence = iq;
            Dexterity = dx;
            health = hlt;
        }

        // Build Attack method
        public int Attack(Human target)
        {
            return this.health - (this.Strength * 5);
        }
    }

}

