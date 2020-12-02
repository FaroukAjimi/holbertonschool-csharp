using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> myList1 = new List<int>() {-1};
        List<int> myList2 = new List<int>() {98, 972, 971, -32, 972, 972, -727};

        Console.WriteLine("Max: " + List.MaxInteger(myList1));
        Console.WriteLine("Max: " + List.MaxInteger(myList2));
    }
}