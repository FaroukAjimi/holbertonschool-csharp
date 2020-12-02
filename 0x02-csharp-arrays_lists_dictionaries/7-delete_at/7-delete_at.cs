using System;
using System.Collections.Generic;
    class List
    {
        public static List<int> DeleteAt(List<int> myList, int index)
        {
            if (index >= 0 && index < myList.Count)
            {
            int rm = myList[index];
            myList.Remove(rm);
            return(myList);
            }
            else
                Console.WriteLine("Index is out of range");
                return(myList);  
        }
    }
    