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
                if (Convert.ToChar(i) != 'q' || Convert.ToChar(i) != 'e')
                    Console.Write(Convert.ToChar(i));
                i++;
            }
        }
    }
}
