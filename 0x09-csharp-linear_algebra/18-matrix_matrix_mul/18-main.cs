using System;

    class Program
    {
        static void Main(string[] args)
        {
            double[,] matrix1 = {{4,2}};
            double[,] matrix2 = {{5, 5,1},{2, 3,6},{6,8,2}};
            double[,] matrix = MatrixMath.Multiply(matrix1, matrix2);
            for (var i = 0; i < matrix.GetLength(0); i++)
            {
                for (var y = 0; y < matrix.GetLength(1); y++)
                {
                    Console.Write(matrix[i, y] + " ");
                }
                Console.WriteLine();
            }            
        }
    }
