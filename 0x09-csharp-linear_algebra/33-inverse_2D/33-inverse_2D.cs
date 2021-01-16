using System;

/// <summary>
/// Class for matrix opertaions 
/// </summary>
class MatrixMath{
    /// <summary> 
    /// inversed 2d matrix 
    /// </summary>
    public static double[,] Inverse2D(double[,] matrix){
        if (matrix.GetLength(0) != 2 && matrix.GetLength(1) != 2)
            return(new double[,] {{-1}});
        double a = matrix[0,0];
        double b = matrix[0,1];
        double c = matrix[1,0];
        double d = matrix[1,1];
        double fmla = a*d-b*c;
        if (fmla == 0)
            return(new double[,] {{-1}});
        double[,] inverted = new double[,] {{Math.Round(d/fmla, 2),Math.Round(-b/fmla, 2)},
                                            {Math.Round(-c/fmla, 2),Math.Round(a/fmla, 2)}};
        return(inverted);        
    }
}