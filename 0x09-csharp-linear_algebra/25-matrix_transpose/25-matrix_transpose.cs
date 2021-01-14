using System;
class MatrixMath{
    public static double[,] Transpose(double[,] matrix){
        double[,] mat2 = new double[matrix.GetLength(1),matrix.GetLength(0)];
        for(var i = 0; i < matrix.GetLength(0); i++)
            for(var y = 0; y < matrix.GetLength(1); y++)
                mat2[y,i] = matrix[i,y];
        return(mat2);
    }
}