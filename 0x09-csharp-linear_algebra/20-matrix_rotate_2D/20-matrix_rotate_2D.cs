using System;
/// <summary>
/// MatrixMath is a class for matrices operations
/// </summary>
class MatrixMath {
    /// <summary>
    /// Rotated2D is an instance that roates matrice by angle
    /// </summary>
    public static double[,] Rotate2D(double[,] matrix, double angle){
        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
            return(new double[,] {{-1}});
        double[,] formula = {{Math.Cos(angle), -Math.Sin(angle)},{Math.Sin(angle), Math.Cos(angle)}};
        double[,] rot = new double[2,2];
        for(var i = 0; i < 2; i++)
                for(var y = 0; y < 2; y++)
                    for(var z = 0; z < 2; z++)
                        rot[i, z] = rot[i, z] + matrix[i , y] * formula[y, z];
        for (var i = 0; i < 2; i++)
                for (var y = 0; y < 2; y++)
                    rot[i,y] = Math.Round(rot[i,y], 2);             
        return(rot);
    }
}