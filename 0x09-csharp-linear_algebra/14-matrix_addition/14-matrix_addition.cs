using System;
/// <summary> MatrixMath is a class for matrices operations </summary>
class MatrixMath
{
    /// <summary> Add is an instance that adds two matrices </summary>
    public static double[,] Add(double[,] matrix1, double[,] matrix2){
        int c = matrix1.GetLength(0);
        if (c != matrix1.GetLength(1) || c < 2 || c > 3 || c != matrix2.GetLength(0))
        {
            return(new double[,] {{-1}});
        }
        double[,] s = new double[c,c];
        for(var i = 0; i < c; i++)
            for (var y = 0; y < c; y++)
            {
                s[i,y] = Math.Round(matrix1[i,y] + matrix2[i,y], 2);
            }
        return(s);
    }
}