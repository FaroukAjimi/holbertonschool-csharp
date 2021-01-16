using System;
/// <summary>
/// MatrixMath is a class for matrices operations
/// </summary>
class MatrixMath{
    /// <summary>
    /// Transpode is an instance that performs matrix tranposition
    /// </summary>
    public static double[,] Transpose(double[,] matrix){
        double[,] mat2 = new double[matrix.GetLength(1),matrix.GetLength(0)];
        for(var i = 0; i < matrix.GetLength(0); i++)
            for(var y = 0; y < matrix.GetLength(1); y++)
                mat2[y,i] = Math.Round(matrix[i,y], 2);
        return(mat2);
    }
}