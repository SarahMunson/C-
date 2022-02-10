using System;

namespace Fundamentals1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // int i = 0;
            // int max = 255;
            // while (i <= max)
            // {
            //     Console.WriteLine(i);
            //     i++;
            // }

            // int j = 1;
            // int max = 100;
            // while(j <= max){
            //     if(j % 3 == 0 && j % 5 == 0){
            //         j++;
            //     }
            //     if( j % 3 == 0){
            //         Console.WriteLine(j);
            //     }
            //     if ( j % 5 == 0){
            //         Console.WriteLine(j);
            //     }
            //     j++;
            // }

            int k = 1;
            int max = 100;
            while(k <= max){
                if(k % 3 == 0 && k % 5 == 0){
                    Console.WriteLine("FizzBuzz");
                }
                if(k % 3 == 0){
                    Console.WriteLine("Fizz");
                }
                if(k % 5 == 0){
                    Console.WriteLine("Buzz");
                }
                k++;
            }
        }
    }
}
