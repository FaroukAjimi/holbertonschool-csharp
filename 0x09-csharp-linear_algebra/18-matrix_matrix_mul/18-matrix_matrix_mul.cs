using System;
 class MatrixMath{
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2){
        double[,] mul1 = new double[matrix1.GetLength(0), matrix2.GetLength(1)];
        if (matrix1.GetLength(1) != matrix2.GetLength(0))
                return(new double[,] {{-1}});
        int t = (matrix1.GetLength(0) * matrix2.GetLength(1)) * 2;
            for(var i = 0; i < matrix1.GetLength(0); i++)
                for(var y = 0; y < matrix1.GetLength(1); y++)
                    for(var z = 0; z < matrix2.GetLength(1); z++)
                            mul1[i, z] = mul1[i, z] + matrix1[i , y] * matrix2[y, z];
        return(mul1);
     }   
 }