using System;
using System.Collections.Generic;

namespace HungryNinjas
{
    public class Buffet
    {
        public List<Food> Menu;

        //constructor
        public Buffet()
        {
            Menu = new List<Food>()
        {
            new Food("French Fries", 1000, true, false),
            new Food("French pies", 1000, false, true),
            new Food("French Bread", 300, true, false),
            new Food("Frenches Green Beans", 200, false, false),
            new Food("Sweet Potatoes", 400, false, true),
            new Food("Squash", 300, false, true),
            new Food("Broccoli", 100, true, false)
        };
        }
        public Food Serve()
        {
            Random yums = new Random();
            return Menu[yums.Next(Menu.Count)];
        }
    }


}