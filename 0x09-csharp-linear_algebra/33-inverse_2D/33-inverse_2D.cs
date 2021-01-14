using System;

class MatrixMath{
    public static double[,] Inverse2D(double[,] matrix){
        double a = matrix[0,0];
        double b = matrix[0,1];
        double c = matrix[1,0];
        double d = matrix[1,1];
        double fmla = a*d-b*c;
        double[,] inverted = new double[,] {{d/fmla,-b/fmla},{-c/fmla,a/fmla}};
        return(inverted);        
    }
}