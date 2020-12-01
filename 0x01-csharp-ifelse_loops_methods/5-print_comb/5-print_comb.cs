using System;

namespace _5_print_comb
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 98; i++)
                Console.Write("{0:00}, ", i);
            Console.WriteLine("{0:00}", 99);
        }
    }
}
