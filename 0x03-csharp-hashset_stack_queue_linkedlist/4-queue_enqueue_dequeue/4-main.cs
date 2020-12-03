using System;
using System.Collections.Generic;

class Program
{
    // Main - entry point
    static void Main(string[] args)
    {
        Queue<string> aQueue = new Queue<string>();

        aQueue.Enqueue("Javascript");

        foreach (string item in aQueue)
            Console.WriteLine(item);

        Console.WriteLine("------");

        MyQueue.Info(aQueue, "C#", "Javascript");

        Console.WriteLine("------");

        foreach (string item in aQueue)
            Console.WriteLine(item);
    }
}
