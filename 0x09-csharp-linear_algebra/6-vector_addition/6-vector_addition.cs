using System;


    class VectorMath
    {
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
                double[] sum2 = {vector1[0]+vector2[0],
                                vector1[1]+vector2[1],
                                vector1[2]+vector2[2]};
                return(sum2);
            }
            else
                return(no);
        }
    }

