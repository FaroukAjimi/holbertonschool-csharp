using System;


    class Program
    {
        static void Main(string[] args)
        {
            double[] vector = {1};
            double scalar = 0.5;
            double[] s = VectorMath.Multiply(vector, scalar);
            foreach(var itm in s)
            {
                Console.Write(itm + " ");
            }
        }
    }