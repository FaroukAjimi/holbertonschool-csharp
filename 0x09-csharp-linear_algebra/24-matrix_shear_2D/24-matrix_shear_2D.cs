using System;

class MatrixMath{
    public static double[,] Shear2D(double[,] matrix, char direction, double factor){
        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
            return (new double[,] {{-1}});
        if (direction == 'x')
        {
            matrix[0,0] = matrix[0,0] + factor * matrix[0,1];
            matrix[1,0] = matrix[1,0] + factor * matrix[1,1];
        }
        if (direction == 'y')
        {
            matrix[0,1] = matrix[0,1] + factor * matrix[0,0];
            matrix[1,1] = matrix[1,1] + factor * matrix[1,0];
        }
        else
            return(new double[,] {{-1}});
        return(matrix);
    }
}