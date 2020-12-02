using System;

namespace _14_rectangular_array
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 5; i++)
            {
                for(int y = 0; y < 5; y++)
                {
                    if (i == 2 && y == 2)
                    {
                        Console.Write("1 ");
                        continue;
                    }
                    if (y == 4)
                    {
                        Console.Write("0");
                        continue;
                    }
                    Console.Write("0 ");
                }
                Console.WriteLine();
            }
        }
    }
}
