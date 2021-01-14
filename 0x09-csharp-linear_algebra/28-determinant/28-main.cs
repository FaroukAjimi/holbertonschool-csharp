using System;

    class Program
    {
        static void Main(string[] args)
        {
           double[,] mat1 = {{2,2},{-9,4}};
           double[,] mat2 = {{11, 8, 7},{2, 13, 1},{4, 0, 17}};
           Console.WriteLine(MatrixMath.Determinant(mat1));
           Console.WriteLine(MatrixMath.Determinant(mat2));
        }
    }

