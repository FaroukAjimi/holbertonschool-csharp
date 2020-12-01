using System;

namespace _5_print_comb
{
    class Program
    {
        static void Main(string[] args)
        {
            int y = 0;
            for (int i = 0; i <= 79; i++)
            {
            if (i % 10 == 0)
               {
                    y = y + 1;
                    i = i + y;
                }
            Console.Write("{0:00}, ", i);
            }
            Console.WriteLine("89");
        }
    }
}
