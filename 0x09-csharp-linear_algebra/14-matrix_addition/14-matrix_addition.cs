using System;
class MatrixMath
{
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
                s[i,y] = matrix1[i,y] + matrix2[i,y];
            }
        return(s);
    }
}