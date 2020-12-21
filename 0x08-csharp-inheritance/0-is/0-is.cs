using System;
using System.Collections.Generic;

    /// <summary> class obj </summary> 
    class Obj
    {
        /// <summary> check if type is int method </summary>
        public static bool IsOfTypeInt(object obj)
        {
            if (obj is int)
            {
                return(true);
            }
            return(false);
        }
    }

