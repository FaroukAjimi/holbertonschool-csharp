using System;
using System.Collections.Generic;

    class List
    {
        public static List<int> CreatePrint(int size)
        {
            List<int> l = new List<int>();
            int i = 0;
            if (size >= 0)
            {
                for(i = 0; i < size; i++)
            {
                l.Add(i);
            }
            Console.WriteLine(string.Join(" ", l));
            return(l);
            }
            else
            {
                Console.WriteLine("Size cannot be negative");
                return(null);
            }
        }
    }
