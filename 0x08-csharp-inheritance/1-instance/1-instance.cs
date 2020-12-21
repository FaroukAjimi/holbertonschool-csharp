using System;
using System.Collections.Generic;
    /// <summary> class obj </summary>
    
    class Obj
    {
        /// <summary> check instance </summary>
         public static bool IsInstanceOfArray(object obj)
        {
           if (typeof(Array).IsInstanceOfType(obj))
           {
               return(true);
           } 
           return(false);
        }
    }

