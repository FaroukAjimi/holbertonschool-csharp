using System;

    class Program
    {
        static void Main(string[] args)
        {
            double[] mat1 = {2, 4, 5};
            double[] mat2 = {1, -2};
            double[] res = VectorMath.CrossProduct(mat1, mat2);
            foreach(var itm in res)
                Console.Write(itm + " ");
        }
    }
