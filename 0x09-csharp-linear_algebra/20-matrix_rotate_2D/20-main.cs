using System;


    class Program
    {
        static void Main(string[] args)
        {
            double[,] T2D = {{1,2},{3,4}};
            double angle = -1.57;
            double[,] result = MatrixMath.Rotate2D(T2D, angle);
            for (var i = 0; i < 2; i++)
            {
                for (var y = 0; y < 2; y++)
                    Console.Write(result[i, y] + " ");
                Console.WriteLine();
            }
    }
    }

