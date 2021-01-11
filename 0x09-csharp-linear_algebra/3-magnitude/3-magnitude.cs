using System;
    class VectorMath
    {
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

