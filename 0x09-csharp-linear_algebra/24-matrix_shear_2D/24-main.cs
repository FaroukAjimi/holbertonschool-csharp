using System;

namespace _24_matrix_shear_2D
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] matrix = {{1,2},{3,4}};
            char direction = 'y';
            double factor = 2;
            double[,] result= MatrixMath.Shear2D(matrix, direction, factor);
            for (var i = 0; i < 2; i++)
            {
                for (var y = 0; y < 2; y++)
                    Console.Write(result[i, y] + " ");
                Console.WriteLine();
            }
        }
    }
}
