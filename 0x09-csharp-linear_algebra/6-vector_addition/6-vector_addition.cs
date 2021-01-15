using System;

    /// <summary> VectorMath is a class specified for vector calucluations </summary>
    class VectorMath
    {
        /// <summary> Add is an instance that performs the addition of two vectors </summary>
        public static double[] Add(double[] vector1, double[] vector2)
        {   
            double[] no =  {-1};
            if (vector1.Length != vector2.Length)
                return(no);
            if (vector1.Length == 2)
            {
                double[] sum1 = {vector1[0]+vector2[0], vector1[1]+vector2[1]};
                return(sum1);
            }
            if (vector1.Length == 3)
            {
                double[] sum2 = {Math.Round(vector1[0] + vector2[0], 2),
                                Math.Round(vector1[1] + vector2[1], 2),
                                Math.Round(vector1[2] + vector2[2], 2)};
                return(sum2);
            }
            else
                return(no);
        }
    }

