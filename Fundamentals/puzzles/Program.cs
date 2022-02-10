using System;
using System.Collections.Generic;

namespace puzzles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MinMaxSum();
            TossCoin();
            TossMultiple(5);
            Names();
        }

        public static int[] RandomArray()
        {
            Random rand = new Random();
            int[] nums = new int[10];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = rand.Next(5, 26);
            }
            return nums;
        }

        public static void MinMaxSum()
        {
            int[] nums = RandomArray();
            int max = nums[0];
            int min = nums[0];
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < min)
                {
                    min = nums[i];
                }
                if (nums[i] > max)
                {
                    max = nums[i];
                }
                sum += nums[i];
            }
            Console.WriteLine($"Min: {min} Max: {max} Sum: {sum}");
        }


        public static string TossCoin()
        {
            Console.WriteLine("Tossing a coin...");
            Random coinToss = new Random();
            string flip;
            if (coinToss.Next(2) == 0)
            {
                flip = "heads";
            }
            else
            {
                flip = "tails";
            }
            Console.WriteLine($"The flip resulted in {flip}");
            return flip;
        }
        public static double TossMultiple(int numTimes)
        {
            int headsCount = 0;
            for (int i = 0; i < numTimes; i++)
            {
                if (TossCoin() == "heads")
                {
                    headsCount++;
                }
            }
            Console.WriteLine((double)headsCount / numTimes);
            return (double)headsCount / numTimes;
        }

        public static List<string> Names()
        {
            List<string> names = new List<string>()
            {
                "Todd", "Tiffany", "Charlie", "Geneva", "Sydney"
            };

            Random mixer = new Random();
            for(int i = 0; i < names.Count; i++)
            {
                int randomIndex = mixer.Next(names.Count);
                string temp = names[randomIndex];
                names[randomIndex] = names[i];
                names[i] = temp;
            }
            foreach(string name in names)
            {
                Console.WriteLine(name);
            }
            for(int i = 0; i < names.Count; i++)
            {
                if(names[i].Length < 6)
                {
                    names.RemoveAt(i);
                }
            }
            return names;
        }
    }
}
