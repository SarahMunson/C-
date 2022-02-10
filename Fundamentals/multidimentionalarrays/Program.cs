using System;

namespace multidimentionalarrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[,] array2D = new int[3, 2];
            int[,,] array3D = new int[2, 3, 4]
    {
        {  { 45,1,16,17 }, { 4,47,21,68 }, { 21,28,32,76 }  },
        {  { 11,0,85,42 }, { 9,10,14,96 }, { 66,99,33,12 }  }
    };
            // Directly accessing a multidimensional array
            Console.WriteLine(array2D[0, 1]);  
            Console.WriteLine(array3D[1, 0, 3]);
            int[,,] array10D = new int[10,1,10]
            {
                {{1,2,3,4,5,6,7,8,9,10}},
                {{11,12,13,14,15,16,17,18,19,20}},
                {{21,22,23,24,25,26,27,28,29,30}},
                {{31,32,33,34,35,36,37,38,39,40}},
                {{41,42,43,44,45,46,47,48,49,50}},
                {{51,52,53,54,55,56,57,58,59,60}},
                {{61,62,63,64,65,66,67,68,69,70}},
                {{71,72,73,74,75,76,77,78,79,80}},
                {{81,82,83,84,85,86,87,88,89,90}},
                {{91,92,93,94,95,96,97,98,99,100}}
            };
            foreach(var j in array10D)
            {
            Console.Write(j);
            }
        }
    }
}
