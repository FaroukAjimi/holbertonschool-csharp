using System;
/// <summary> MatrixMath is a class for matrices operations </summary>
 class MatrixMath{
     /// <summary> Multyiply is an instance that multiplies two matrices </summary>
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2){
        double[,] mul1 = new double[matrix1.GetLength(0), matrix2.GetLength(1)];
        if (matrix1.GetLength(1) != matrix2.GetLength(0))
                return(new double[,] {{-1}});
            for(var i = 0; i < matrix1.GetLength(0); i++)
                for(var y = 0; y < matrix1.GetLength(1); y++)
                    for(var z = 0; z < matrix2.GetLength(1); z++)
                            mul1[i, z] = Math.Round(mul1[i, z] + matrix1[i , y] * matrix2[y, z], 2);
        return(mul1);
     }   
 }