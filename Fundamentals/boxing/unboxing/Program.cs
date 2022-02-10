using System;
using System.Collections.Generic;

namespace unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<object> assignment = new List<object>();
            assignment.Add(7);
            assignment.Add(28);
            assignment.Add(-1);
            assignment.Add(true);
            assignment.Add("chair");
            int sum = 0;
            foreach(var j in assignment)
            {
                if(j is int)
                {
                    int jj = (int)j;
                    sum += jj;
                }
                Console.WriteLine(j);
            }
            Console.WriteLine(sum);
        }
    }
}
