using System;


    class Int
    {
        public static void divide(int a, int b)
        {   
            int r = 0;
            string t = "";
            string e = "";           
            try{
            r = a / b;
            e = string.Format("{0} / {1} = {2}", a, b, r); 
            }
            catch (DivideByZeroException){
            e = string.Format("{0} / {1} = {2}", a, b, 0);
            t = "Cannot divide by zero";
            }
            finally {
                Console.WriteLine(t);
                Console.WriteLine(e);
            }            
        }
    }
