using System;


    class Program
    {
        static void Main(string[] args)
        {
            double scalar = 4;
            double[,] mat = {{-13, 10, 8},{2, 0, 14}};
            double[,] s = MatrixMath.MultiplyScalar(mat, scalar);
            for (var i = 0; i < s.GetLength(0); i++)
            {
                for (var y = 0; y < s.GetLength(1); y++)
                {
                    Console.Write(s[i, y] + " ");
                }
                Console.WriteLine();
            }            
        }
    }
