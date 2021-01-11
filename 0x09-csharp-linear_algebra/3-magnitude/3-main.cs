using System;
    class Program
    {

    static void Main(string[] args)
        {
            double[] vector = {3, 9};
            double[] vector2 = {7, -3, -9};
            double[] vector3 = {7};
            Console.WriteLine(VectorMath.Magnitude(vector));
            Console.WriteLine(VectorMath.Magnitude(vector2));
            Console.WriteLine(VectorMath.Magnitude(vector3));
        }
    }

