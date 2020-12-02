using System;

namespace _100_jagged_array
{
    class Program
    {
        static void Main(string[] args)
        {
           int[][] jagged =
           {
               new int[] {0, 1, 2, 3},
               new int[] {0, 1, 2, 3, 4, 5, 6},
               new int[] {0, 1}
           };
           for(int i = 0; i < jagged.GetLength(0); i++)
           {
               for(int y = 0;y < jagged[i].GetLength(0); y++)
               {
                   if (y == jagged[i].GetLength(0) - 1)
                   {
                      Console.Write("{0}", jagged[i][y]);
                      continue; 
                   }
                   Console.Write("{0} ", jagged[i][y]);
               }
               Console.WriteLine();
           }
            
        }
    }
}
