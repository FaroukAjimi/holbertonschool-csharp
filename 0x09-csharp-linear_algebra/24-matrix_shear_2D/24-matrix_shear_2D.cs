using System;
/// <summary>
/// MatrixMath is a class for matrices operations
/// </summary>
class MatrixMath{
    /// <summary>
    /// Shear2D is an instance that shears a matrix
    /// </summary>
    public static double[,] Shear2D(double[,] matrix, char direction, double factor){
        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
            return (new double[,] {{-1}});
        if (direction == 'x')
        {
            matrix[0,0] = Math.Round(matrix[0,0] + factor * matrix[0,1], 2);
            matrix[1,0] = Math.Round(matrix[1,0] + factor * matrix[1,1], 2);
        }
        if (direction == 'y')
        {
            matrix[0,1] = Math.Round(matrix[0,1] + factor * matrix[0,0], 2);
            matrix[1,1] = Math.Round(matrix[1,1] + factor * matrix[1,0], 2);
        }
        else
            return(new double[,] {{-1}});
        return(matrix);
    }
}