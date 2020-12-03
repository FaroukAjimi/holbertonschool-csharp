using System;

using System.Collections.Generic;
    class LList
    {
        public static int Length(LinkedList<int> myLList)
        {
            int c = 0;
            foreach(var i in myLList)
                c++;
            return(c);
        }
    }

