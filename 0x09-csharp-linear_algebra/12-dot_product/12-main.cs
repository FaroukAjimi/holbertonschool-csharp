using System;

    class Program
    {
        static void Main(string[] args)
        {
            double[] s = {-4, 0, 10};
            double[] s2 = {3, 7, -9};
            Console.WriteLine(VectorMath.DotProduct(s, s2));
        }
    }
