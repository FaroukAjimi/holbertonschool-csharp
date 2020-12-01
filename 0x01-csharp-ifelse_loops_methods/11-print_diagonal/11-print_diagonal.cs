using System;

    class Line
    {
        public static void PrintDiagonal(int length)
        {
            string tabs = new String(' ', 0);
            if (length > 0)
            { 
                for (int i = 0; i < length; i++)
                {
                    tabs = new String(' ', i);
                    Console.Write(tabs);
                    Console.WriteLine("\\");    
                }
            }    
            Console.WriteLine();
        }
    }