using System;
using System.Collections.Generic;

namespace basic13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //All your code writing happens here
            // Print1to255();
            // PrintAllOdds1to255();
            // printSum();
            // int[] myarray = { -1, 2, 3, 2, 1, 6 };
            // int[] myarray2 = new int[5];
            // printArray(myarray);
            // List<int> myList = new List<int>() { 3, 5, 4, 1, 2, 5 };
            // printList(myList);
            int[] numbers = { 1, -4, -6, -2, -8 };
            // FindMax(numbers);
            // GetAverage(numbers);
            // OddArray();
            // GreaterThanY(numbers, 0);
            // SquareArrayValues(numbers);
            // EliminateNegatives(numbers);
            // MinMaxAverage(numbers);
            // ShiftValues(numbers);
            // dojoReplace(myarray);
        }
        //BASIC 13
        public static void Print1to255()
        {
            for (int i = 1; i <= 255; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void PrintAllOdds1to255()
        {
            for (int i = 1; i <= 255; i += 2)
            {
                Console.WriteLine(i);
            }
        }

        public static void printSum()
        {
            int sum = 0;
            for (int i = 0; i <= 255; i++)
            {
                sum += i;
                Console.WriteLine(sum);
                Console.WriteLine(i);
            }
        }

        public static void printArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        public static int FindMax(int[] numbers)
        {
            int max = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            Console.WriteLine(max);
            return max;
        }

        public static void printList(List<int> listArr)
        {
            for (int i = 0; i < listArr.Count; i++)
            {
                Console.WriteLine(listArr[i]);
            }
        }

        public static float GetAverage(int[] numbers)
        {
            float sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine(sum / numbers.Length);
            return sum / numbers.Length;
        }

        public static int[] OddArray()
        {
            // List<int> temp = new List<int>();
            // for (int i = 1; i <= 255; i += 2)
            // {
            //     temp.Add(i);
            // }
            // int[] oddArray = temp.ToArray();
            // foreach (var j in oddArray)
            // {
            //     Console.WriteLine(j);
            // }
            // return oddArray;
            int size = (255 / 2) + 1;
            int[] odds = new int[size];
            int i = 0;
            for (int num = 1; i <= 255; num += 2)
            {
                odds[i] = num;
                i++;
            }
            return odds;
        }

        public static int GreaterThanY(int[] numbers, int y)
        {
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > y)
                {
                    count += 1;
                }
            }
            Console.WriteLine(count);
            return count;
        }

        public static void SquareArrayValues(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = numbers[i] * numbers[i];
            }
            foreach (var j in numbers)
            {
                Console.WriteLine(j);
            }
        }

        public static void EliminateNegatives(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0)
                {
                    numbers[i] = 0;
                }
            }
            foreach (var j in numbers)
            {
                Console.WriteLine(j);
            }
        }


        public static void MinMaxAverage(int[] numbers)
        {
            int min = numbers[0];
            int max = numbers[0];
            float sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
                sum += numbers[i];
            }
            Console.WriteLine($"min: {min}");
            Console.WriteLine("max " + max);
            Console.WriteLine("average " + sum / numbers.Length);
        }

        public static void ShiftValues(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                numbers[i] = numbers[i + 1];
            }
            numbers[numbers.Length - 1] = 0;
            foreach (int j in numbers)
            {
                Console.WriteLine(j);
            }
        }

        public static object[] dojoReplace(int[] arr)
        {
            //we need to convert our integer array into an object array
            object[] newArray = new object[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    newArray[i] = "dojo";
                }
                else
                {
                    newArray[i] = arr[i];
                }
            }
            foreach (var j in newArray)
            {
                Console.WriteLine(j);
            }
            return newArray;
        }
    }
}
