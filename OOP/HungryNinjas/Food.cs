using System;

namespace HungryNinjas
{
    public class Food
    {
        public string Name;
        public int Calories;
        // Foods can be Spicy and/or Sweet
        public bool IsSpicy;
        public bool IsSweet;
        // add a constructor that takes in all four parameters: Name, Calories, IsSpicy, IsSweet
        public Food(string nm, int cal, bool spc, bool swt)
        {
            Name = nm;
            Calories = cal;
            IsSpicy = spc;
            IsSweet = swt;
        }
    }

}

