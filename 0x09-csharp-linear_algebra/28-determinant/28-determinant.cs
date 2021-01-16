using System;
/// <summary>
/// MatrixMath is a class for matrices operations
/// </summary>
class MatrixMath{
    /// <summary>
    /// Determinant is a function that calculates the matrix determinant
    /// </summary>
    public static double Determinant(double[,] matrix){
        if (matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2)
            return Math.Round(matrix[0,0] * matrix[1,1] - matrix[0,1] * matrix[1,0], 2);
        else if (matrix.GetLength(0) == 3 && matrix.GetLength(1) == 3)
        {
            double s1 = matrix[0,0] * (matrix[1,1] * matrix[2,2] - matrix[1,2] * matrix[2,1]);
            double s2 = matrix[0,1] * (matrix[1,0] * matrix[2,2] - matrix[1,2] * matrix[2,0]);
            double s3 = matrix[0,2] * (matrix[1,0] * matrix[2,1] - matrix[1,1] * matrix[2,0]);
            return(Math.Round(s1 - s2 + s3, 2));
        }
        else
            return(-1);
    }
}