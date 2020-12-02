﻿using System;

    class Array
    {
                public static int[] CreatePrint(int size)
        {
            if (size < 0)
             {
                Console.WriteLine("Size cannot be negative");
                return(null);
             }
            int [] ar = new int[size];
            if (size >= 0)
            {
            for(int i = 0; i < size; i++)
                ar[i] = i;
            Console.WriteLine(string.Join(" ", ar));
            }     
            return(ar);
        }
    }
