using System;

    /// <summary> VectorMath is Class Specified for Vectors Caluculations </summary>
    class VectorMath
    {
        /// <summary> Magnitude is method of Length of a vector </summary>
        public static double Magnitude(double[] vector)
        {
            if (vector.Length < 2)
            {
                return(-1);
            }
            double f = vector[0];
            double s = vector[1];
            double sq = f*f + s*s;
            if (vector.Length == 2)
                return(Math.Round(Math.Sqrt(sq), 2));
            if(vector.Length == 3)
                return(Math.Round(Math.Sqrt(sq + vector[2]*vector[2]),2));
            else 
                return(-1);
        }
    }

