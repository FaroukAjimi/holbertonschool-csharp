using System;
/// <summary>
/// VectorMath is a class specified for vectors caluculations 
/// </summary>
class VectorMath
{
    /// <summary> 
    /// multiply is an instance that performs vectors multiplication by sclar 
    /// </summary>
    public static double[] Multiply(double[] vector, double scalar){
        if (vector.Length > 3 || vector.Length < 2)
            return(new double[] {-1});
        double[] s = new double[vector.Length];
        for (var i = 0; i < vector.Length; i++)
        {
            s[i] = Math.Round((vector[i] * scalar), 2);
        }
        return(s);
    }
}