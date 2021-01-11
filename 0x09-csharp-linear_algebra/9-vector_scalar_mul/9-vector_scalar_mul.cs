using System;

class VectorMath
{
    public static double[] Multiply(double[] vector, double scalar){
        if (vector.Length > 3 || vector.Length < 2)
            return(new double[] {-1});
        double[] s = new double[vector.Length];
        for (var i = 0; i < vector.Length; i++)
        {
            s[i] = (vector[i] * scalar);
        }
        return(s);
    }
}