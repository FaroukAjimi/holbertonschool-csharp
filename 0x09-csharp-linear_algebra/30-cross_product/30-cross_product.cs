using System;
/// <summary> VectorMath is a class for vectors calculations </summary>
class VectorMath{
    /// <summary> crossProduct is a function that calculates the crossproduct of two vectors </summary>
    public static double[] CrossProduct(double[] vector1, double[] vector2)
    {
    if (vector1.Length != 3 || vector2.Length != 3)
        return(new double[] {-1});
    double s1 = vector1[1]*vector2[2] - vector1[2]*vector2[1];
    double s2 = vector1[2]*vector2[0] - vector1[0]*vector2[2];
    double s3 = vector1[0]*vector2[1] - vector1[1]*vector2[0];
    return(new double[] {Math.Round(s1, 2), Math.Round(s2, 2), Math.Round(s3, 2)});
    }
}