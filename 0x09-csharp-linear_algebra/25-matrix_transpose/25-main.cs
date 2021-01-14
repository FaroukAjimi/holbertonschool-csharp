using System;


    class Program
    {
        static void Main(string[] args)
        {
            double[,] matrix = {{1, 2, 3, 4},{5, 6, 4, 8}};
            double[,] result= MatrixMath.Transpose(matrix);
            for (var i = 0; i < result.GetLength(0); i++)
            {
                for (var y = 0; y < result.GetLength(1); y++)
                    Console.Write(result[i, y] + " ");
                Console.WriteLine();
            }
        }
    }
