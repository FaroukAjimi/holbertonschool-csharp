using System;

class MatrixMath{
   public static double[,] MultiplyScalar(double[,] matrix, double scalar) {
       int c = matrix.GetLength(0);
       int r = matrix.GetLength(1);
       if (c != r || c < 2 || c > 3)
            return(new double[,] {{-1}});
       double[,] f = new double[c,r];
       for (var i = 0; i < c; i++)
        for(var y = 0; y < r; y++)
            f[i,y] = matrix[i,y] * scalar;
       return(f); 
    }
}