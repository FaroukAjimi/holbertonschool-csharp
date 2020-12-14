using System;

    class List
    {
        public static int SafePrint(List<int> myList, int n)
        {
            int i = 0;
            for (i = 0; i < n; i++)
            {
                try {
                Console.WriteLine(myList[i]);
                }
                catch (ArgumentOutOfRangeException) {
                    return (i);
                }
            }   
        return (i);
        }
    }
