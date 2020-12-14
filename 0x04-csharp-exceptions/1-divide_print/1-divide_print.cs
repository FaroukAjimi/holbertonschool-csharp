using System;


    class Int
    {
        public static void divide(int a, int b)
        {   
            int r = 0;           
            try{
                r = a / b;
            }
            catch (DivideByZeroException){
                r = 0;
                Console.WriteLine("Cannot divide by zero");
            }
            finally {
                Console.WriteLine("{0} / {1} = {2}", a, b, r);
            }            
        }
    }
