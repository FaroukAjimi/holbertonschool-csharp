using System;
/// <summary>
/// VectorMath is a class specified for vector calculations
/// </summary>
class VectorMath
{
    /// <summary>
    /// DotProduct is an instance that performs vectors dot product
    /// </summary>
    public static double DotProduct(double[] vector1, double[] vector2){
        if (vector1.Length != vector2.Length || vector1.Length < 2 || vector1.Length > 3)
            return(-1);
        double[] s = new double[vector1.Length];
        double dot = 0;
        for(var i = 0; i < vector1.Length; i++)
        {
            s[i] = vector1[i] * vector2[i];
        }
        foreach (var itm in s)
            dot = dot + itm;
        return(Math.Round(dot,2));
    }
}