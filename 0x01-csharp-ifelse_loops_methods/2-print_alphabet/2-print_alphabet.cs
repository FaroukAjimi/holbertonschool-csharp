using System;

namespace _2_print_alphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 97;
            while(i <=122)
            { 
                Console.Write(Convert.ToChar(i));
                i++;
            }
         }
    }
}