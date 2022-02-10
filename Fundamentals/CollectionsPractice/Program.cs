using System;
using System.Collections.Generic;

namespace CollectionsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] array = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            string[] strArray = new string[] { "why", "you", "so", "awesome", "??" };
            bool[] sooTrue = new bool[] { true, false, true, false, true, false, true, false, true, false };

            List<String> iceScream = new List<String>() { "Chocochip", "Caramel Pretzel Crunch", "Ganache Berry", "Ooohyummy", "Cotton Candy" };
            Console.WriteLine(iceScream.Count);
            Console.WriteLine(iceScream[2]);
            // iceScream.Remove("Ganache Berry");
            Console.WriteLine(iceScream.Count);
            Dictionary<string, string> diction = new Dictionary<string, string>();
            diction.Add($"{strArray[0]}", $"{iceScream[0]}");
            diction.Add($"{strArray[1]}", $"{iceScream[1]}");
            diction.Add($"{strArray[2]}", $"{iceScream[2]}");
            diction.Add($"{strArray[3]}", $"{iceScream[3]}");
            diction.Add($"{strArray[4]}", $"{iceScream[4]}");
            foreach (KeyValuePair<string, string> entry in diction)
            {
                Console.WriteLine(entry.Key + " - " + entry.Value);
            }
        }
    }
}
