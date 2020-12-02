using System;

    class Array
    {
        public static void Reverse(int[] array)
        {
            int i = 0;
            if (array == null || array.Length <= 0)
            {
                Console.WriteLine();
                return;
            }
            for (i = array.Length - 1; i > 0; i--)
            {
                Console.Write(array[i]);
                Console.Write(" ");
            }
            Console.WriteLine(array[i]);
        }
    }
