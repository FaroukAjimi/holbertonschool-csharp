using System;

    class Program
    {
        static void Main(string[] args)
        {
            double[] m2D1= {8, -11};
            double[] m2D2= {-4, 9};
            double[] m3D1= {14, -2, 0};
            double[] m3D2= {-3, 23, 50};
            double[] sum = VectorMath.Add(m2D1, m2D2);
            foreach (var item in sum)
              Console.Write(item + " ");  
        }
    }