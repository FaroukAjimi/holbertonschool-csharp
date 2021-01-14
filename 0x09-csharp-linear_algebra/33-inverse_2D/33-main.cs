using System;

    class Program
    {
        static void Main(string[] args)
        {
            double[,] matrix = {{1,2},{3,4}};
            double[,] inv = MatrixMath.Inverse2D(matrix);
            for (var i = 0; i < 2; i++)
            {
                for (var y = 0; y < 2; y++)
                    Console.Write(inv[i, y] + " ");
                Console.WriteLine();
            }
        }
    }

