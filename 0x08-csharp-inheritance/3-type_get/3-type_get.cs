using System;
using System.Collections.Generic;
using System.Reflection;
    /// <summary> class obj </summary>
    class Obj
    {
        /// <summary> class obj </summary>
        public static void Print(object myObj)
        {
            TypeInfo t =  myObj.GetType().GetTypeInfo();
            IEnumerable<PropertyInfo> l = t.GetProperties();
            IEnumerable<MethodInfo> m = t.GetMethods();
        Console.WriteLine(t.Name + " Properties:");
           foreach(PropertyInfo i in l)
                Console.WriteLine(i.Name);
        Console.WriteLine(t.Name + " Methods:");
           foreach (MethodInfo x in m)
                    Console.WriteLine(x.Name);
        }
    }
