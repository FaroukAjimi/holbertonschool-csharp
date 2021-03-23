using System;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        TestObject item = new TestObject();
        Type type = item.GetType();

        Console.WriteLine("Type: " + type);

        Console.WriteLine("Methods:");
        foreach (MethodInfo info in type.GetMethods())
            Console.WriteLine(info.Name);
    }
}