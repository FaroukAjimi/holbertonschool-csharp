using System;
using System.Collections.Generic;
    class LList
    {
        public static int Sum(LinkedList<int> myLList)
        {
            int y = 0;
            foreach(var i in myLList)
            {
                y += i;
            }
            return(y);
        }
    }

