using System;
using System.Collections.Generic;

    class Dictionary
    {
        public static void PrintSorted(Dictionary<string, string> myDict)
        {
            List<string> l = new List<string>();
            Dictionary<string, string> n = new Dictionary<string, string>();
            foreach(var item in myDict)
                l.Add(item.Key);
            l.Sort();
            foreach (var i in l)
                Console.WriteLine("{0}: {1}", i, myDict[i]);          
        }
    }

