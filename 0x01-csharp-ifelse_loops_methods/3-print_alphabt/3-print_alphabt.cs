using System;

namespace _3_print_alphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 97;
            while (i <= 122)
            {
                if (i == 101 || i == 113)
                {
                    i++;
                    continue;
                }
                Console.Write(Convert.ToChar(i));
                i++;
            }
        }
    }
}
