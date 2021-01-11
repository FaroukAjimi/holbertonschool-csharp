using System;


    class Program
    {
        static void Main(string[] args)
        {
            double[,] mat1 = {{14, -3, 0}, {-11, -5, 3}, {2, -9, 13}};
            double[,] mat2 ={{6, 16, 21}, {5, 2, 0}, {2, -9, 13}};
            double[,] matsum = MatrixMath.Add(mat1, mat2);
            for (var i = 0; i < matsum.GetLength(0); i++)
            {
                for (var y = 0; y < matsum.GetLength(1); y++)
                {
                    Console.Write(matsum[i, y] + " ");
                }
                Console.WriteLine();
            }            
        }
    }
