using System;
class MatrixMath{
    public static double Determinant(double[,] matrix){
        if (matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2)
            return ((matrix[0,0] * matrix[1,1]) - (matrix[0,1] * matrix[1,0]));
        else if (matrix.GetLength(0) == 3 && matrix.GetLength(1) == 3)
        {
            double s1 = matrix[0,0] * (matrix[1,1] * matrix[2,2] - matrix[1,2] * matrix[2,1]);
            double s2 = matrix[0,1] * (matrix[1,0] * matrix[2,2] - matrix[1,2] * matrix[2,0]);
            double s3 = matrix[0,2] * (matrix[1,0] * matrix[2,1] - matrix[1,1] * matrix[2,0]);
            return(s1 - s2 + s3);
        }
        else
            return(-1);
    }
}